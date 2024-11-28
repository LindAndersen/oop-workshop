using oop_workshop.domain.building_structure;
using oop_workshop.domain.equipment;
using oop_workshop.interfaces;
using Physical;

namespace oop_workshop.presentation {
    public class Manager : IManager
    {
        Building? building {get;set;}
        public void ConstructManagerFromChannels(ISet<Channel> channels)
        {
            building = null;

            Floor? floor;
            Room? room;

            foreach(Channel c in channels) {
                bool isFloorSensor = false;
                string producerType = c.Metadata["type"];
                string media = c.Metadata["media"];
                string modality = c.Metadata["modality"];
                string unit = c.Metadata["unit"];

                string buildingName = c.Metadata["building"];
                string levelNumber = c.Metadata["floor"];
                string? roomNumber = null;

                building ??= new Building(buildingName);

                if(!building.FloorExists(levelNumber)) {
                    floor = new Floor(levelNumber);
                    building.floors.Add(floor);
                } else {
                    floor = building.GetFloorByLevel(levelNumber);
                }

                try {
                    roomNumber = c.Metadata["room"];
                } catch(KeyNotFoundException) {
                    isFloorSensor = true;
                }

                if(!isFloorSensor && !floor.RoomExists(roomNumber)) {
                    room = new Room(roomNumber);
                    floor.rooms.Add(room);
                } else {
                    room = floor.GetRoomByRoomNumber(roomNumber);
                }
                
                

                switch (producerType) {
                    case "sensor":
                        Sensor sensor = new Sensor(media, modality, unit);
                        if(isFloorSensor) {
                            floor.electricitySensor.Add(sensor);
                        } else {
                            room.producers.Add(sensor);
                        }
                        c.Subscribe(sensor);
                        break;
                    case "setpoint":
                        SetPoint setPoint = new SetPoint(media, modality, unit);
                        room.producers.Add(setPoint);
                        c.Subscribe(new SetPoint(media, modality, unit));
                        break;
                    default:
                        Console.WriteLine("Could not identify channel type");
                        break;
                }

            }
        }

        public void PrettyPrint()
        {
            building.PrettyPrint();
        }
    }
}