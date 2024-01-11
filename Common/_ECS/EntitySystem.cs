namespace Kiln.Common._ECS {
    public class EntitySystem {
        public static List<EntityData> date = new();
        public static List<int> activeEntityIds = new();
        public static List<int> inactiveEntityIds = new();
        public static Lazy<int> freeEntityIds = new();
        public static int nextEntityID;
    }
}
