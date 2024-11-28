namespace oop_workshop.domain.equipment {
    class Actuator : Device {
        private int controlValue;
        private string controlType;
        private Sensor sensor;
        private SetPoint setPoint;
        
        public Actuator(long id, string name, int controlValue, string controlType, Sensor sensor, SetPoint setPoint) {
            this.controlValue = controlValue;
            this.controlType = controlType;
            this.sensor = sensor;
            this.setPoint = setPoint;
        }

        
    }
}