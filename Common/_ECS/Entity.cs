namespace Kiln.Common._ECS{
    public struct Entity {
        public int id;
        public bool active { get; set; }
        public Entity(int id) { this.id = id; }
    }
}
