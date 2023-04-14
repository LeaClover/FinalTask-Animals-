namespace FinalWork {

    public class DomesticAnimal : Animal {
        public DomesticAnimal(long id, string name, int age, string voice, Type type, Kind kind, List<Command> commandList) 
            : base(id, name, age, voice, type, kind, commandList) {
            
            this.type = Type.DOMESTIC;
        }
    }
}