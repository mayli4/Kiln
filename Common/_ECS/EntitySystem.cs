using System.Collections.Concurrent;

namespace Kiln.Common._ECS {
    public class EntitySystem {
        public static List<EntityData> date = new();
        public static List<int> activeEntityIds = new();
        public static List<int> inactiveEntityIds = new();
        public static ConcurrentBag<int> freeEntityIds = new();
        public static int nextEntityID;

        public static Entity CreateEntity(bool activated) {
            int entityId;
            if (!freeEntityIds.TryTake(out entityId))
                entityId = nextEntityID++;
            return new Entity(entityId);
        }

    }
}
