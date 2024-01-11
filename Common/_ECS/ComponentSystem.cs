namespace Kiln.Common._ECS {
    public class ComponentSystem {
        public static int componentTypeCount { get; set; }

        public static bool HasComponent<T>(int entity) where T : Component {
            if(entity < 0 || entity >= ComponentData<T>.Components.Length)
                return false;
            return ComponentData<T>.Components[entity] != null;
        }

        public static void RemoveComponent<T>(int entity) where T : Component {
            if (entity < 0 || entity >= ComponentData<T>.Components.Length)
                return;
            ComponentData<T>.Components[entity] = null;
        }
    }
}
