namespace FinalWork {
    public interface IAnimalService {
        void addAnimal(Animal animal);
        List<Animal> getAllAnimals();
        List<Command> showAnimalCommands(Animal animal);
        void trainNewCommand(Animal animal, Command command);
    }
}
