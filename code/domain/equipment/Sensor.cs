using System.Runtime.InteropServices;
using Physical;

namespace oop_workshop.domain.equipment {
    class Sensor : Device, IChannelSubscriber {

        public Sensor(long id, string name) : base(id, name) {

        }
        public void NewSample(Channel channel, Sample? sample)
        {
            if(sample == null) return;
            Console.WriteLine(this.GetType().Name + " > " + sample.value);
        }
    }
}