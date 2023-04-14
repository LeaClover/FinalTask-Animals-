namespace FinalWork {

    public class Dog : DomesticAnimal
    {
        public Dog(long id, string name, int age, string voice, Type type, Kind kind, List<Command> commandList) 
            : base(id, name, age, voice, type, kind, commandList) {
                this.kind = Kind.DOG;
        }
    }
}