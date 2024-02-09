using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Kiln.Common.ECS {
    public struct Entity : IEquatable<Entity >{
        public int ID;
        public int worldID;

        public static Entity NullEntity = new(-1, 0);

        public Entity(int id, int world) {
            ID = id;
            worldID = world;
        }

        public bool Equals(Entity other) {
            return ID == other.ID;
        }

        //public T Get<T>(in Entity entity) where T : struct {
        //    var world = World.Worlds[entity.worldID];
        //    return (T)world;
        //}


        public override bool Equals([NotNullWhen(true)] object obj) {
            return obj is Entity other && Equals(other);
        }

        public static bool operator ==(Entity one, Entity two) {
            return one.Equals(two);
        }
        public static bool operator !=(Entity one, Entity two) {
            return !one.Equals(two);
        }

    }
}
