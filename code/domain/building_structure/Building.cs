namespace oop_workshop.domain.building_structure {
    public class Building {
        private static long nextId = 0;
        private long id {get;set;}
        private string name {get;set;}
        public IDictionary<String, Floor> floors {get;set;}

        public Building(string name) {
            this.name = name;
            this.floors = new Dictionary<string, Floor>();
        }

        public int GetEnergyConsumption() {
            return 0;
        }

        public void PrettyPrint() {
            Console.WriteLine($"Building({id}, {name}):");
            Console.WriteLine(".. Floors:");
            foreach(KeyValuePair<string, Floor> f in floors) {
                f.Value.PrettyPrint();
            }
        }
    }
}