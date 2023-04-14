namespace FinalWork {

    public class PackAnimal : Animal {
        public PackAnimal(long id, string name, int age, string voice, Type type, Kind kind, List<Command> commandList) 
            : base(id, name, age, voice, type, kind, commandList) {

            this.type = Type.PACK;
        }
    }
}
