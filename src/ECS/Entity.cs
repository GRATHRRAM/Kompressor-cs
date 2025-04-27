using System.ComponentModel;

namespace KP
{
    public class Entity
    {
        public UInt32 Id { get; set; } = 0;
        public UInt32 ZIndex { get; set; } = 0;
        public string Name { get; set; } = "Entity";

        private readonly Dictionary<System.Type, KPC.Component> _components = new();

        public void AddComponent<T>(params object[] args) where T : KPC.Component
        {
            var component = (T)Activator.CreateInstance(typeof(T), args);
            _components[typeof(T)] = component;
        }

        public void RemoveComponent<T>() where T : KPC.Component
        {
            _components.Remove(typeof(T));
        }

        public T GetComponent<T>() where T : KPC.Component
        {
            _components.TryGetValue(typeof(T), out var component);
            return component as T;
        }

        public bool HasComponent<T>() where T : KPC.Component
        {
            return _components.ContainsKey(typeof(T));
        }
    }
}