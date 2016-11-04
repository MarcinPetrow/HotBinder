using HotBinder.Core.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Input;

namespace BinderPlayground.Core.Binding
{
	public static class BindingHelper
	{
		public static void Bind(object target, BindableInfo binding)
		{
			binding.UiPropertyInfo = target.GetType().GetProperty(binding.UiPropertyName);
			if (binding.UiPropertyInfo == null && (binding.Type == BindableType.Data || binding.Type == BindableType.Collection))
			{
				throw new BindingException($"UI property {binding.UiPropertyName} not found");
			}

			binding.PropertyInfo = binding.Context.GetType().GetProperty(binding.PropertyName);
			if (binding.PropertyInfo == null)
			{
				throw new BindingException($"Model property {binding.PropertyName} not found");
			}

			if (binding.Type == BindableType.Data)
			{
				if (!binding.UiPropertyInfo.PropertyType.IsAssignableFrom(binding.PropertyInfo.PropertyType))
				{
					if (binding.UiPropertyInfo.PropertyType != binding.PropertyInfo.PropertyType)
					{
						ApplyConvertablePropertyChangeEvent(target, binding);
					}
					else
					{
						throw new BindingException($"Cannot bind {binding.PropertyName} to the property of {binding.Context.GetType().Name} because of incompatible type. Property type is {binding.PropertyInfo.PropertyType}. Trying to bind with {binding.UiPropertyInfo.PropertyType}.");
					}

				}
				else
				{
					ApplyPropertyChangeEvent(target, binding);
				}
			}

			if (binding.Type == BindableType.Action && binding.PropertyInfo.PropertyType != typeof(ICommand))
			{
				throw new BindingException($"Cannot bind {binding.PropertyName} to the Action because of incompatible type. Property type is {binding.PropertyInfo.PropertyType}.");
			}

			if (binding.Type == BindableType.Collection)
			{
				if (!binding.PropertyInfo.PropertyType.GetInterfaces().Contains(typeof(IBindingList)))
				{
					throw new BindingException($"Cannot bind {binding.PropertyName} to the Action because of incompatible type. Property type is {binding.PropertyInfo.PropertyType}.");
				}
				ApplyPropertyChangeEvent(target, binding);
			}

			ApplyEventRegister(target, binding);

		}

		public static void BindAll(this IBindable target)
		{
			var type = target.GetType();

			var propertiesInfos = type.GetProperties();
			foreach (var propertyInfo in propertiesInfos)
			{
				if (!propertyInfo.IsDefined(typeof(BindableElement), false))
				{
					continue;
				}

				var propertyAttributes = propertyInfo.GetCustomAttributes(typeof(BindableElement));
				IEnumerable<Attribute> attributes = propertyAttributes as Attribute[] ?? propertyAttributes.ToArray();
				if (attributes.Count() != 1)
				{
					throw new BindingException("BindableElement attributes count mismatch.");
				}
				var bindableElement = attributes.FirstOrDefault() as BindableElement;
				if (bindableElement == null)
				{
					throw new BindingException("Failed to read bindable attribute.");
				}

				var propertyValue = propertyInfo.GetValue(target) as string;
				if (!string.IsNullOrEmpty(propertyValue))
				{
					Bind(target, new BindableInfo
					{
						UiPropertyName = bindableElement.Name,
						PropertyName = propertyValue,
						UiEventName = bindableElement.EventName,
						Type = bindableElement.Type,
						Context = target.Context
					});
				}
			}
		}

		private static void ApplyEventRegister(object target, BindableInfo binding)
		{
			if (binding.Type == BindableType.Collection)
			{
				return;
			}

			var eventInfo = target.GetType().GetEvent(binding.UiEventName);
			if (eventInfo == null)
			{
				throw new BindingException($"Event {binding.UiEventName} not found");
			}

			Delegate eventDelegate = null;

			if (binding.Type == BindableType.Data)
			{
				if (binding.PropertyInfo.PropertyType != binding.UiPropertyInfo.PropertyType)
				{
					eventDelegate = CreateDelegate(eventInfo.EventHandlerType, (obj, args) =>
					{
						var value = binding.UiPropertyInfo.GetValue(target);

						var castedValue = Convert.ChangeType((IConvertible)value, binding.PropertyInfo.PropertyType);

						binding.PropertyInfo.SetValue(binding.Context, castedValue);
					});
				}
				else
				{
					eventDelegate = CreateDelegate(eventInfo.EventHandlerType, (obj, args) =>
					{
						var value = binding.UiPropertyInfo.GetValue(target);
						binding.PropertyInfo.SetValue(binding.Context, value);
					});
				}

			}
			if (binding.Type == BindableType.Action)
			{
				eventDelegate = CreateDelegate(eventInfo.EventHandlerType, (obj, args) =>
				{
					var value = binding.PropertyInfo.GetValue(binding.Context) as ICommand;
					if (value != null && value.CanExecute(args))
					{
						value.Execute(args);
					}
				});
			}

			if (eventDelegate != null)
			{
				eventInfo.AddEventHandler(target, eventDelegate);
				PinManager.Instance.RegisterEvent(eventDelegate);
			}


		}

		private static void ApplyConvertablePropertyChangeEvent(object target, BindableInfo binding)
		{
			PropertyChangedEventHandler propertyChangedEventHanlder = new PropertyChangedEventHandler(
				(sender, args) =>
				{
					if (args.PropertyName != binding.PropertyName || sender == target)
					{
						return;
					}
					var value = binding.PropertyInfo.GetValue(binding.Context);

					//dynamical casting
					if (binding.PropertyInfo.PropertyType != binding.UiPropertyInfo.PropertyType)
					{
						var castedValue = Convert.ChangeType((IConvertible)value, binding.UiPropertyInfo.PropertyType);
						binding.UiPropertyInfo.SetValue(target, castedValue);
					}
					//end of dynamical casting
					else
					{
						binding.UiPropertyInfo.SetValue(target, value);
					}
				}
			);
			binding.Context.PropertyChanged += propertyChangedEventHanlder;
			PinManager.Instance.RegisteredPropertyChangedHandler(propertyChangedEventHanlder);

			binding.Context.NotifyProperty(binding.PropertyName);
		}

		private static void ApplyPropertyChangeEvent(object target, BindableInfo binding)
		{
			PropertyChangedEventHandler propertyChangedEventHanlder = new PropertyChangedEventHandler(
				(sender, args) =>
				{
					if (args.PropertyName != binding.PropertyName || sender == target)
					{
						return;
					}
					var value = binding.PropertyInfo.GetValue(binding.Context);

					try
					{
						binding.UiPropertyInfo.SetValue(target, value);
					}
					catch { }
				});

			binding.Context.PropertyChanged += propertyChangedEventHanlder;
			PinManager.Instance.RegisteredPropertyChangedHandler(propertyChangedEventHanlder);

			binding.Context.NotifyProperty(binding.PropertyName);
		}

		private static Delegate CreateDelegate(Type type, EventHandler handler)
		{
			var constructorInfo = type.GetConstructor(new[] { typeof(object), typeof(IntPtr) });
			if (constructorInfo != null)
			{
				return (Delegate)constructorInfo
									  .Invoke(new[] { handler.Target, handler.Method.MethodHandle.GetFunctionPointer() });
			}
			throw new BindingException("Cannot create delegate for event.");
		}
	}
}