using System.Numerics;
using oop_workshop.domain.equipment;

namespace oop_workshop.domain.building_structure {
    public class Room : IComparable<Room> {
        public string roomNumber;
        public List<Producer> producers;

        public Room(string roomNumber) {
            this.roomNumber = roomNumber;
            producers = new List<Producer>();
        }
        
        public Room(string roomNumber, List<Producer> producers) {
            this.roomNumber = roomNumber;
            this.producers = producers;
        }

        public int CompareTo(Room? other)
        {
            if(other==null) return -1;
            return this.GetEnergiConsumption().CompareTo(other.GetEnergiConsumption());
        }

        public int GetEnergiConsumption() {
            return 0;
        }

        public void PrettyPrint() {
            Console.WriteLine($".. .. .. .. Room({roomNumber})");
            foreach(Device d in producers) {
                d.PrettyPrint(5);
            }
        }
    }
}