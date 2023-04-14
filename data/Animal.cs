namespace FinalWork {

    public class Animal {
        public long id;
        public string name;
        public int age;
        public string voice;
        public Type type;
        public Kind kind;
        public List<Command> commandList;

        public Animal(long id, string name, int age, string voice, Type type, Kind kind, List<Command> commandList) {
            this.id = id;
            this.name = name;
            this.age = age;
            this.voice = voice;
            this.type = type;
            this.kind = kind;
            this.commandList = commandList;
        }

        public void setId(long id) {
            this.id = id;
        }

        public long getId() {
            return this.id;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getName() {
            return this.name;
        }

        public void setAge(int age) {
            this.age = age;
        }

        public int getAge() {
            return this.age;
        }

        public void setVoice(string voice) {
            this.voice = voice;
        }

        public string getVoice() {
            return this.voice;
        }

        public void setType(Type type) {
            this.type = type;
        }

        public Type getType() {
            return this.type;
        }

        public void setKind(Kind kind) {
            this.kind = kind;
        }

        public Kind getKind() {
            return this.kind;
        }

        public void setCommandList(List<Command> commandList) {
            this.commandList = commandList;
        }

        public List<Command> getCommandList() {
            return this.commandList;
        }

        public override string ToString() {
            return "Animal - id: " + this.id + ", Name: " + this.name + " , Age: " + this.age + ", Voice: " 
            + this.voice + ", Type: " + this.type + ", Kind: " + this.kind;
        }
    }
}