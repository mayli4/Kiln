using System.Text.Json.Serialization;

namespace Kiln.Common._ECS{
    [JsonConverter(typeof(Entity))]
    public struct Entity {
        public int id;
        public Vec2 pos;
        public bool active { get; set; }
        public Entity(int id) { this.id = id; }
    }
}
