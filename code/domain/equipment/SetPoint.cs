using Physical;

namespace oop_workshop.domain.equipment {
    class SetPoint : Device, IChannelSubscriber {
        private int dayValue;
        private int nightValue;
        public SetPoint(long id, string name, int dayValue, int nightValue) : base(id, name) {
            this.dayValue = dayValue;
            this.nightValue = nightValue;
        }

        public void NewSample(Channel channel, Sample? sample)
        {
            if(sample == null) return;
            Console.WriteLine(this.GetType().Name + " > " + sample.value);
        }
    }
}