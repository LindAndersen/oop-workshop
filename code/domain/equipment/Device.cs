namespace oop_workshop.domain.equipment {
    public class Device {
        private static long nextId = 0;
        private long id {get;set;}

        protected Device() {
            this.id = nextId;
            nextId++;
        }

        public void PrettyPrint(int n) {
            Console.WriteLine($"{string.Concat(Enumerable.Repeat(".. ", n))} Device({id})");
        }
    }
}