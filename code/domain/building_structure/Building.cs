namespace oop_workshop.domain.building_structure {
    public class Building {
        private static long nextId = 0;
        private long id {get;set;}
        private string name {get;set;}
        public List<Floor> floors {get;set;}

        public Building(string name, List<Floor> floors) {
            this.id = nextId;
            nextId++;
            this.name = name;
            this.floors = floors;
        }

        public Building(string name) {
            this.name = name;
            this.floors = new();
        }

        public Floor? GetFloorByLevel(string levelNumber) {
            foreach(Floor f in floors) {
                if(f.levelNumber.Equals(levelNumber)) {
                    return f;
                }
            }

            return null;
        }

        public bool FloorExists(string levelNumber) {
            foreach(Floor f in floors) {
                if (f.levelNumber.Equals(levelNumber)) {
                    return true;
                }
            }

            return false;
        }

        public int GetEnergyConsumption() {
            return 0;
        }

        public void PrettyPrint() {
            Console.WriteLine($"Building({id}, {name}):");
            Console.WriteLine(".. Floors:");
            foreach(Floor f in floors) {
                f.PrettyPrint();
            }
        }
    }
}