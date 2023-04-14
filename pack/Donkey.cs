namespace FinalWork {

    public class Donkey : PackAnimal
    {
        public Donkey(long id, string name, int age, string voice, Type type, Kind kind, List<Command> commandList) 
            : base(id, name, age, voice, type, kind, commandList) {
                this.kind = Kind.DONKEY;
        }
    }
}