namespace FinalWork {

    public  class DomesticAnimalService : ICare, IVoice {

        public void caress() {
            Console.WriteLine("Меня погладили. Меня любят! <3");
        }

        public void eat() {
            Console.WriteLine("Меня покормили");
        }

        public void voice(Animal animal) {
            Console.WriteLine(animal.getVoice());
        }
    }
}
