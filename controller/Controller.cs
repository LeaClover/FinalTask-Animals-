namespace FinalWork {
    public class Controller {
        private AnimalService animalS = new AnimalService();
        private AnimalView animalV = new AnimalView();

        public void addAnimal(Animal animal) {
            animalS.addAnimal(animal);
        }

        public void showAllAnimals() {
            animalV.sendOnConsole(animalS.getAllAnimals());
        }

        public void showAllCommands(Animal animal) {
            animalV.sendOnConsoleAnimalComands(animal);
        }

        public void addNewComand(Animal animal, Command command) {
            animalS.trainNewCommand(animal, command);
        }

        public List<Animal> getAllAnimals() {
            return animalS.animalList;
        }
    }
}
