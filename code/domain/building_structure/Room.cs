using System.Numerics;
using oop_workshop.domain.equipment;

namespace oop_workshop.domain.building_structure {
    class Room : IComparable<Room> {
        private long id;
        private string name;
        private List<Device> devices;

        public Room(long id, string name) {
            this.id = id;
            this.name = name;
            devices = new List<Device>();
        }
        
        public Room(long id, string name, List<Device> devices) {
            this.id = id;
            this.name = name;
            this.devices = devices;
        }

        public Device AddActuator(long id, string name, string controlType, int controlValue) {
            Actuator actuator = new(id, name, controlValue, controlType);
            devices.Add(actuator);
            return actuator;
        }

        public int CompareTo(Room? other)
        {
            if(other==null) return -1;
            return this.GetEnergiConsumption().CompareTo(other.GetEnergiConsumption());
        }

        public int GetEnergiConsumption() {
            return 0;
        }
    }
}