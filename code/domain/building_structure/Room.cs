using System.Numerics;
using oop_workshop.domain.equipment;

namespace oop_workshop.domain.building_structure {
    public class Room {
        public string roomNumber;
        public IList<Producer> producers;

        public Room(string roomNumber) {
            this.roomNumber = roomNumber;
            producers = new List<Producer>();
        }      

        public void PrettyPrint() {
            Console.WriteLine($".. .. .. .. Room({roomNumber})");
            foreach(Producer d in producers) {
                d.PrettyPrint(5);
            }
        }
    }
}