using Physical;
using oop_workshop.domain.building_structure;
using oop_workshop.domain.equipment;

namespace oop_workshop.interfaces {
    public interface IManager {
        public void ConstructManagerFromChannels(ISet<Channel> channels);
        public void PrettyPrint();
    }
}