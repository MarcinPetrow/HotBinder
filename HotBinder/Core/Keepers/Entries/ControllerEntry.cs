using System;
using System.Collections.Generic;
using System.Reflection;
using HotBinder.Core.Attributes;

namespace HotBinder.Core.Keepers.Entries
{
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
}