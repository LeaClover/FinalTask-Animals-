namespace FinalWork {

    public class PackAnimalService : ICare, IVoice, ICarry {

        public void caress() {
            Console.WriteLine("Меня погладили. Меня любят! <3");
        }

        public void carry() {
            Console.WriteLine("Я могу перевозить людей и поклажу!");
        }

        public void eat() {
            Console.WriteLine("Меня покормили");
        }

        public void voice(Animal animal) {
            Console.WriteLine(animal.getVoice());
        }
    }
}