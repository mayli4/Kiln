namespace Kiln.Common._ECS {
    public static class ComponentData<T> where T : Component {
        public static T[] Components = Array.Empty<T>();
        public static readonly int id = ComponentSystem.componentTypeCount++;
        public static readonly int mask = 1 << id;
    }
}
