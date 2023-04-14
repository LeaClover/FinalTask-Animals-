namespace FinalWork {

    public class Command {
        public string name;

        public Command(string name) {
            this.name = name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getName() {
            return this.name;
        }

        public override string ToString() {
            return this.name;
        }
    }
}
