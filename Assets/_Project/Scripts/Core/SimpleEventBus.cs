using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild
{
    public static class SimpleEventBus
    {
        private static Dictionary<Type, Delegate> events = new Dictionary<Type, Delegate>();
        
        public static void Subscribe<T>(Action<T> handler)
        {
            if (!events.ContainsKey(typeof(T))) events[typeof(T)] = null;
            events[typeof(T)] = (Action<T>)events[typeof(T)] + handler;
        }
        
        public static void Unsubscribe<T>(Action<T> handler)
        {
            if (events.ContainsKey(typeof(T))) events[typeof(T)] = (Action<T>)events[typeof(T)] - handler;
        }
        
        public static void Publish<T>(T eventMessage)
        {
            if (events.ContainsKey(typeof(T)) && events[typeof(T)] != null)
                ((Action<T>)events[typeof(T)]).Invoke(eventMessage);
        }
    }
}