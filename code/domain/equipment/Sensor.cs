using System.Runtime.InteropServices;
using Physical;

namespace oop_workshop.domain.equipment {
    public class Sensor : Producer, IChannelSubscriber {

        public Sample? sample;

        public Sensor(string media, string modality , string unit) : base(media, modality, unit) {

        }
        public void NewSample(Channel channel, Sample? sample)
        {
            this.sample = sample;
        }
    }
}