using System.Dynamic;
using oop_workshop.domain.equipment;

namespace oop_workshop.domain.building_structure {
    public class Floor {
        public string levelNumber;
        public IDictionary<string, Room> rooms {get;set;}
        public ISet<Sensor> electricitySensor {get;set;}
        public Floor(string levelNumber) {
            this.levelNumber = levelNumber;
            this.rooms = new Dictionary<string, Room>();
            electricitySensor = new HashSet<Sensor>();
        }

        public int GetEnergiConsumption() {
            return 0;
        }

        public void PrettyPrint() {
            Console.WriteLine($".. .. Floor({levelNumber})");
            Console.WriteLine($".. .. .. Sensors:");
            foreach(Sensor s in electricitySensor) {
                s.PrettyPrint(4);
            }
            Console.WriteLine($".. .. .. Rooms:");
            foreach(KeyValuePair<string, Room> r in rooms) {
                r.Value.PrettyPrint();
            }
        }
    }
}