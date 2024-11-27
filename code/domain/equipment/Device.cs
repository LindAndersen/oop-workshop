namespace oop_workshop.domain.equipment {
    public abstract class Device {
        private long id;
        private string name;

        protected Device(long id, string name) {
            this.id = id;
            this.name = name;
        }
    }
}