namespace oop_workshop.domain.building_structure {
    class Floor {
        private long id;
        private string levelNumber;

        public Floor(long id, string levelNumber) {
            this.id = id;
            this.levelNumber = levelNumber;
        }

        public int GetEnergiConsumption() {
            return 0;
        }
    }
}