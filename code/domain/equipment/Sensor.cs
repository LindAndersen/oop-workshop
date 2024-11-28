using System.Runtime.InteropServices;
using Physical;

namespace oop_workshop.domain.equipment {
    public class Sensor : Producer, IChannelSubscriber {

        public Sensor(string media, string modality , string unit) : base(media, modality, unit) {

        }
        public void NewSample(Channel channel, Sample? sample)
        {
            if(sample == null) return;
            Console.WriteLine(this.GetType().Name + " > " + sample.value);
        }
    }
}