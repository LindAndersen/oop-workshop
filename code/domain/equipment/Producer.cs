namespace oop_workshop.domain.equipment {
    public class Producer : Device
    {
        private string media {get;set;}
        private string modality {get;set;}
        private string unit {get;set;}
        protected Producer(string media, string modality, string unit)
        {
            this.media = media;
            this.modality = modality;
            this.unit = unit;
        }
    }
}