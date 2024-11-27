using oop_workshop.domain.building_structure;
using oop_workshop.domain.equipment;
using Physical;

Room room = new(0, "My room");
room.AddActuator(0, "thermostat", "celsius", 20);

// load history
History hist = new History("code/data/data");
hist.PrettyPrint();

// register consumers for events
ISet<Channel> channels = hist.GetChannels();
foreach (Channel channel in channels) {
  channel.Subscribe(new Sensor(0, "test"));
}

// step through timeline
hist.Replay();
