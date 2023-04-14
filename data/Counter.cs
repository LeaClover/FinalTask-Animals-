namespace FinalWork {

    public class Counter : IDisposable {

        public int sum; 
        public Counter() {
            this.sum = 0;
        }
        public void add() {
            sum++;
        }

        public void Dispose() {
            Console.WriteLine("Counter closed!");
        }
    }
}
