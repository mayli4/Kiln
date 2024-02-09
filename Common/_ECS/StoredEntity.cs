namespace Kiln.Common.ECS {
    /// <summary>
    /// Stores important info about an <see cref="Entity"./>
    /// </summary>
    public record struct StoredEntity {
        public int ID;
        public StoredEntity(int id) {
            ID = id;
        }
    }
}
