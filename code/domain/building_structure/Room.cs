using System.Numerics;
using oop_workshop.domain.equipment;

namespace oop_workshop.domain.building_structure {
    public class Room {
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

        

        public void PrettyPrint() {
            Console.WriteLine($".. .. .. .. Room({roomNumber})");
            foreach(Device d in producers) {
                d.PrettyPrint(5);
            }
        }
    }
}