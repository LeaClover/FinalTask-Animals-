namespace FinalWork {
    public class AnimalView {
        public DomesticAnimalService domesticAS = new DomesticAnimalService();
        public PackAnimalService packAS = new PackAnimalService();

        public void sendOnConsole(List<Animal> animalList) {

            foreach (Animal animal in animalList) {
                Type type = animal.getType();
                switch(type) {
                case Type.DOMESTIC:
                    Console.WriteLine(animal);
                    if (animal.commandList.Count() > 0) {
                        Console.WriteLine("Команды: ");
                        sendOnConsoleAnimalComands(animal);
                    }
                    domesticAS.caress();
                    domesticAS.eat();
                    domesticAS.voice(animal);
                    break;
                case Type.PACK:
                    Console.WriteLine(animal);
                    if (animal.commandList.Count() > 0) {
                        Console.WriteLine("Команды: ");
                        sendOnConsoleAnimalComands(animal);
                    }
                    packAS.caress();
                    packAS.eat();
                    packAS.carry();
                    packAS.voice(animal);
                    break;
                }
            }
        }

        public void sendOnConsoleAnimalComands(Animal animal) {
            foreach (Command command in animal.commandList) {
                Console.Write(" - " + command + "\n");
            }
        }
    }
}