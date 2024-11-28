using oop_workshop.domain.equipment;
using oop_workshop.interfaces;
using oop_workshop.presentation;
using Physical;

// load history
History hist = new History("code/data/data");
hist.PrettyPrint();


// register consumers for events
ISet<Channel> channels = hist.GetChannels();
IManager manager = new Manager();
manager.ConstructManagerFromChannels(channels);
manager.PrettyPrint();

// step through timeline
hist.Replay();


