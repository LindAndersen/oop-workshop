namespace oop_workshop.domain.equipment {
    class Actuator : Device {
        private int controlValue;
        private string controlType;
        
        public Actuator(long id, string name, int controlValue, string controlType) {
            this.controlValue = controlValue;
            this.controlType = controlType;
        }
    }
}