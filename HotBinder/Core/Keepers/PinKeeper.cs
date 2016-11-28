using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HotBinder.Core.Keepers
{
	public sealed class PinManager
	{

		#region Singleton
		private static volatile PinManager instance;
		private static readonly object SyncRoot = new object();

		private PinManager()
		{
			RegisteredEventDelegates = new List<Delegate>();
			RegisteredPropertyChangedHandlers = new List<PropertyChangedEventHandler>();
		}

		public static PinManager Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							instance = new PinManager();
						}
					}
				}

				return instance;
			}
		}


		#endregion Singleton

		public List<Delegate> RegisteredEventDelegates;
		public List<PropertyChangedEventHandler> RegisteredPropertyChangedHandlers;

		internal void RegisterEvent(Delegate eventDelegate)
		{
			RegisteredEventDelegates.Add(eventDelegate);
			Console.WriteLine($"New event delegate registered. Registered event delegates: {RegisteredEventDelegates.Count}");
		}

		internal void RegisteredPropertyChangedHandler(PropertyChangedEventHandler propertyChangedEventHanlder)
		{
			RegisteredPropertyChangedHandlers.Add(propertyChangedEventHanlder);
			Console.WriteLine($"New property changed handler registered. Registered handlers: {RegisteredPropertyChangedHandlers.Count}");
		}
	}
}
