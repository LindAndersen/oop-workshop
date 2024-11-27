namespace oop_workshop.domain.equipment {
    class Actuator : Device {
        private int controlValue;
        private string controlType;
        private SetPoint setPoint;
        private Sensor sensor;

        
        public Actuator(long id, string name, int controlValue, string controlType) : base(id, name) {
            this.controlValue = controlValue;
            this.controlType = controlType;
            setPoint = new(id, name, 0, 0);
            sensor = new(id, name);
        }
    }
}