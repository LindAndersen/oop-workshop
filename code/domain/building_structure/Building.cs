namespace oop_workshop.domain.building_structure {
    class Building {
        private long id {get;set;}
        private string name {get;set;}
        private List<Floor> floors {get;set;}

        public Building(long id, string name, List<Floor> floors) {
            this.id = id;
            this.name = name;
            this.floors = floors;
        }

        public int GetEnergyConsumption() {
            return 0;
        }
    }
}