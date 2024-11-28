using Physical;

namespace oop_workshop.domain.equipment {
    class SetPoint : Producer, IChannelSubscriber {
        private int? dayValue = null;
        private int? nightValue = null;
        public SetPoint(string media, string modality, string unit) : base(media, modality, unit) {
            
        }

        public void NewSample(Channel channel, Sample? sample)
        {
            if(sample == null) return;
            Console.WriteLine(this.GetType().Name + " > " + sample.value);
        }
    }
}