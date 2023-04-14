namespace FinalWork {
    public class AnimalService : IAnimalService {
        public List<Animal> animalList;

        public AnimalService() {
            this.animalList = new List<Animal>{};
        }

        public void addAnimal(Animal animal) {
            this.animalList.Add(animal);
        }

        public List<Animal> getAllAnimals() {
            return this.animalList;
        }

        public List<Command> showAnimalCommands(Animal animal) {
            return animal.commandList;
        }

        public void trainNewCommand(Animal animal, Command command) {
            animal.commandList.Add(command);
        }
    }
}
