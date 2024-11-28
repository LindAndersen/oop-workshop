using Physical;

namespace oop_workshop.domain.equipment {
    class SetPoint : Producer, IChannelSubscriber {
        private Sample? sample;
        public SetPoint(string media, string modality, string unit) : base(media, modality, unit) {

        }

        public void NewSample(Channel channel, Sample? sample)
        {
            this.sample = sample;
        }
    }
}