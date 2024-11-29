using oop_workshop.domain.building_structure;
using oop_workshop.domain.equipment;
using oop_workshop.interfaces;
using Physical;

namespace oop_workshop.presentation {
    public class Manager : IManager
    {
        IDictionary<String, Building> buildings {get;set;}

        public Manager() {
            buildings = new Dictionary<string, Building>();
        }
        public void ConstructManagerFromChannels(ISet<Channel> channels)
        {
            Building? building = null;
            Floor? floor = null;
            Room? room = null;

            foreach(Channel c in channels) {
                bool isFloorSensor = false;
                string producerType = c.Metadata["type"];
                string media = c.Metadata["media"];
                string modality = c.Metadata["modality"];
                string unit = c.Metadata["unit"];

                string buildingName = c.Metadata["building"];
                string levelNumber = c.Metadata["floor"];
                string? roomNumber = null;

                if(building == null || !buildings.ContainsKey(buildingName)) {
                    building = new(buildingName);
                    buildings.Add(buildingName, building);
                } else {
                    building = buildings[buildingName];
                }

                if(!building.floors.ContainsKey(levelNumber)) {
                    floor = new Floor(levelNumber);
                    building.floors.Add(levelNumber, floor);
                } else {
                    floor = building.floors[levelNumber];
                }

                try {
                    roomNumber = c.Metadata["room"];
                } catch(KeyNotFoundException) {
                    isFloorSensor = true;
                }

                if(!isFloorSensor && !floor.rooms.ContainsKey(roomNumber)) {
                    room = new Room(roomNumber);
                    floor.rooms.Add(roomNumber, room);
                } else if (!isFloorSensor) {
                    room = floor.rooms[roomNumber];
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
            foreach(KeyValuePair<string, Building> b in buildings) {
                b.Value.PrettyPrint();
            }
        }
    }
}