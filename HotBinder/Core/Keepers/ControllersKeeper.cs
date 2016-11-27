using HotBinder.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace HotBinder.Core.Keepers
{
	public class ActionEntry
	{
		public string Name { get; set; }
		public bool Default { get; set; }
		public MethodInfo Method { get; set; }

		public ActionEntry(MethodInfo method, ActionAttribute controllerActionAttribute)
		{
			Method = method;
			Name = method.Name;
			Default = controllerActionAttribute?.IsDefault ?? false;
		}

		public void Execute(Controller scope)
		{
			Method?.Invoke(scope, null);
		}
	}

	public class ControllerEntry
	{
		private Controller instance;
		public string Name { get; set; }
		public Type InstanceType { get; set; }

		public Controller Instance
		{
			get
			{
				if (instance == null)
				{
					CreateInstance();
				}
				return instance;
			}
			set { instance = value; }
		}

		public bool Default { get; set; }

		public List<ActionEntry> ActionEntries { get; set; }

		public ControllerEntry(Type controllerType)
		{
			ActionEntries = new List<ActionEntry>();
			InstanceType = controllerType;
			Name = controllerType.Name;
		}

		public void GatherInformations()
		{
			var controllerAttributes = InstanceType.GetCustomAttributes(typeof(ControllerAttribute), true);
			if (controllerAttributes.Length == 1)
			{
				var controllerAttribute = controllerAttributes[0] as ControllerAttribute;
				if (controllerAttribute != null)
				{
					Default = controllerAttribute.IsDefault;
				}
			}

			ActionEntries.Clear();

			var controllersMethods = InstanceType.GetMethods();
			foreach (var controllersMethod in controllersMethods)
			{
				var controllerActions = controllersMethod.GetCustomAttributes(typeof(ActionAttribute), true);
				if (controllerActions.Length != 1)
				{
					continue;

				}
				var controllerActionAttribute = controllerActions[0] as ActionAttribute;
				if (controllerActionAttribute == null)
				{
					continue;
				}

				var actionEntry = new ActionEntry(controllersMethod, controllerActionAttribute);
				ActionEntries.Add(actionEntry);

			}
		}

		public void CreateInstance()
		{
			Instance = Assembly.GetEntryAssembly().CreateInstance(InstanceType.FullName) as Controller;
		}
	}

	public class ControllersKeeper
	{
		#region Singleton

		private static volatile ControllersKeeper instance;
		private static readonly object SyncRoot = new object();

		private ControllersKeeper()
		{
			controllersRegistry = new Dictionary<string, ControllerEntry>();
		}

		public static ControllersKeeper Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							instance = new ControllersKeeper();
						}
					}
				}

				return instance;
			}
		}

		#endregion Singleton

		private readonly Dictionary<string, ControllerEntry> controllersRegistry;

		internal void Scan()
		{
			controllersRegistry.Clear();
			var controllerTypes = Assembly.GetEntryAssembly().GetTypes().Where(t => typeof(Controller).IsAssignableFrom(t));
			foreach (var controllerType in controllerTypes)
			{
				var typeName = controllerType.Name;
				if (controllersRegistry.ContainsKey(typeName))
				{
					throw new DuplicateNameException(string.Format($"Exists more than one controller type with name {0}", typeName));
				}
				var controllerEntry = new ControllerEntry(controllerType);
				controllerEntry.GatherInformations();
				controllersRegistry.Add(controllerType.Name, controllerEntry);
			}
		}


		public Controller GetController(string controllerName)
		{
			if (controllersRegistry.ContainsKey(controllerName))
			{
				return controllersRegistry[controllerName].Instance;
			}

			var defaultControllerType = Assembly.GetEntryAssembly().GetType(controllerName);

			var controllerEntry = new ControllerEntry(defaultControllerType);

			controllersRegistry.Add(controllerName, controllerEntry);
			return controllerEntry.Instance;
		}

		public ControllerEntry GetDefaultControllerEntry()
		{
			return controllersRegistry.FirstOrDefault(entry => entry.Value != null && entry.Value.Default).Value;
		}

		public ControllerEntry GetControllerEntry(string controllerName)
		{
			return controllersRegistry.FirstOrDefault(entry => entry.Value != null && entry.Value.Name == controllerName).Value;
		}

		public Type GetDefaultControllerType()
		{
			return GetDefaultControllerEntry().InstanceType;
		}

		public Controller GetDefaultController()
		{
			var controllerEntry = GetDefaultControllerEntry();
			return controllerEntry.Instance;
		}

		internal void InvokeDefaultAction(ControllerEntry controllerEntry)
		{
			var defaultAction = controllerEntry.ActionEntries.First(action => action.Default);
			defaultAction.Execute(controllerEntry.Instance);
		}

		internal void InvokeAction(ControllerEntry controllerEntry, string actionName)
		{
			var defaultAction = controllerEntry.ActionEntries.First(action => action.Name == actionName);
			defaultAction.Execute(controllerEntry.Instance);
		}

		public void PerformDefault(AppHost host)
		{
			var defaultController = GetDefaultControllerEntry();
			defaultController.Instance.Host = host;
			InvokeDefaultAction(defaultController);
		}
	}
}
