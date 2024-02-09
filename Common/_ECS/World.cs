namespace Kiln.Common.ECS {
    public class World {

        public static World[] Worlds { get; private set; } = new World[4];

        public int ID;

        public World(int id) {
            ID = id;
        }

        public static World Instantiate() {
            return new World(-1);
        }

        public ref T Get<T>(Entity entity) {

        }


    }
}
