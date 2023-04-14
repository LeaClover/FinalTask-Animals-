namespace FinalWork {

    public class Hamster : DomesticAnimal
    {
        public Hamster(long id, string name, int age, string voice, Type type, Kind kind, List<Command> commandList) 
            : base(id, name, age, voice, type, kind, commandList) {
                this.kind = Kind.HAMSTER;
        }
    }
}