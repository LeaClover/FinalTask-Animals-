namespace FinalWork {
    public class MenuView {

        private Controller contr = new Controller();
        public MenuView() {}

        public void run() {
            MenuCommands comm = MenuCommands.NONE;
            while (true) {
                try {
                    Console.WriteLine("\nПриложение для ведения реестра домашних и вьючных животных!\nЧто вы хотите сделать?\n");
                    Console.WriteLine("ADD -- добавить новое животное\nLIST -- вывести список животных");
                    Console.WriteLine("TRAIN -- обучить животное новой команде\nCOMM -- показать список команд животного\nEXIT -- выход");
                    Console.Write("Введите команду: ");
                    String command = Console.ReadLine();
                    comm = (MenuCommands) Enum.Parse(typeof(MenuCommands), command.ToUpper());
                } catch (ArgumentNullException) {
                    Console.WriteLine("\nERROR: Команда не найдена! Вы ничего не ввели! Попробуйте снова!");
                    continue;
                } catch (ArgumentException) {
                    Console.WriteLine("\nERROR: Команда не найдена! Попробуйте снова!");
                    continue;
                } catch (FormatException) {
                    Console.WriteLine("\nERROR: Введено неверное значение! Попробуйте снова!");
                    continue;
                } catch (IOException) {
                    Console.WriteLine("\nERROR: Что-то пошло не так! Попробуйте снова!");
                    continue;
                }
                if (comm == MenuCommands.EXIT) return;
                switch(comm) {
                    case MenuCommands.ADD:
                        try {
                            Kind c = Kind.NONE;
                            long id = setAnimalId();
                            Console.Write("Введите наименование животного: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите возраст животного: ");
                            int age = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите звук животного: ");
                            string voice = Console.ReadLine();
                            Console.WriteLine("Какой вид животного добавить?\n1 -- кошка\n2 -- собака\n3 -- хомяк");
                            Console.WriteLine("4 -- лошадь\n5 -- осел\n6 -- верблюд");
                            string kind = Console.ReadLine();
                            c = (Kind) Enum.Parse(typeof(Kind), kind);
                            
                            // while (true) {
                                switch(c) {
                                    case Kind.CAT:
                                        Animal cat = new Cat(id, name, age, voice, Type.DOMESTIC, Kind.CAT, new List<Command>());
                                        contr.addAnimal(cat);
                                        Console.WriteLine("Животное успешно добавленно!");
                                        break;
                                    case Kind.DOG:
                                        Animal dog = new Dog(id, name, age, voice, Type.DOMESTIC, Kind.DOG, new List<Command>());
                                        contr.addAnimal(dog);
                                        Console.WriteLine("Животное успешно добавленно!");
                                        break;
                                    case Kind.HAMSTER:
                                        Animal hamster = new Hamster(id, name, age, voice, Type.DOMESTIC, Kind.HAMSTER, new List<Command>());
                                        contr.addAnimal(hamster);
                                        Console.WriteLine("Животное успешно добавленно!");
                                        break;
                                    case Kind.HORSE:
                                        Animal horse = new Horse(id, name, age, voice, Type.PACK, Kind.HORSE, new List<Command>());
                                        contr.addAnimal(horse);
                                        Console.WriteLine("Животное успешно добавленно!");
                                        break;
                                    case Kind.DONKEY:
                                        Animal donkey = new Donkey(id, name, age, voice, Type.PACK, Kind.DONKEY, new List<Command>());
                                        contr.addAnimal(donkey);
                                        Console.WriteLine("Животное успешно добавленно!");
                                        break;
                                    case Kind.CAMEL:
                                        Animal camel = new Camel(id, name, age, voice, Type.DOMESTIC, Kind.CAMEL, new List<Command>());
                                        contr.addAnimal(camel);
                                        Console.WriteLine("Животное успешно добавленно!");
                                        break;
                                }
                            continue;
                            // }
                        } catch (ArgumentNullException) {
                            Console.WriteLine("\nERROR: Вы ничего не ввели! Попробуйте снова!");
                            continue;
                        } catch (ArgumentException) {
                            Console.WriteLine("\nERROR: Команда не найдена! Попробуйте снова!");
                            continue;
                        } catch (FormatException) {
                            Console.WriteLine("\nERROR: Неверный формат ввода! Попробуйте снова!");
                            continue;
                        }catch (IOException) {
                            Console.WriteLine("\nERROR: Что-то пошло не так! Попробуйте снова!");
                            continue;
                        }
                    case MenuCommands.LIST:
                        contr.showAllAnimals();
                        continue;
                    case MenuCommands.TRAIN:
                        try {
                            Console.WriteLine("Введите ID животного, которому хотите добавить команду: ");
                            long id = long.Parse(Console.ReadLine());
                            List<Animal> animalList = contr.getAllAnimals();
                            foreach (Animal animal in animalList) {
                                if (id == animal.getId()) {
                                    Animal findAnimal = animal;
                                    Console.WriteLine("Введите команду, которую нужно дабавить животному: ");
                                    string str = Console.ReadLine();
                                    Command command = new Command(str);
                                    contr.addNewComand(findAnimal, command);
                                    break;
                                }
                            } 
                            continue;
                        } catch (ArgumentNullException) {
                            Console.WriteLine("\nERROR: Вы ничего не ввели! Попробуйте снова!");
                            continue;
                        } catch (ArgumentException) {
                            Console.WriteLine("\nERROR: Команда не найдена! Попробуйте снова!");
                            continue;
                        } catch (FormatException) {
                            Console.WriteLine("\nERROR: Введено неверное значение! Попробуйте снова!");
                            continue;
                        } catch (IOException) {
                            Console.WriteLine("\nERROR: Что-то пошло не так! Попробуйте снова!");
                            continue;
                        }
                    case MenuCommands.COMM:
                        try {
                            Console.WriteLine("Введите ID животного, команды которого хотите увидеть: ");
                            long id = long.Parse(Console.ReadLine());
                            List<Animal> animalList = contr.getAllAnimals();
                            foreach (Animal animal in animalList) {
                                if (id == animal.getId()) {
                                    Animal findAnimal = animal;
                                    contr.showAllCommands(findAnimal);
                                    break;
                                } 
                            }
                            continue;
                        } catch (ArgumentNullException) {
                            Console.WriteLine("\nERROR: Вы ничего не ввели! Попробуйте снова!");
                            continue;
                        } catch (ArgumentException) {
                            Console.WriteLine("\nERROR: Команда не найдена! Попробуйте снова!");
                            continue;
                        } catch (FormatException) {
                            Console.WriteLine("\nERROR: Введено неверное значение! Попробуйте снова!");
                            continue;
                        } catch (IOException) {
                            Console.WriteLine("\nERROR: Что-то пошло не так! Попробуйте снова!");
                            continue;
                        } catch (Exception) {
                            Console.WriteLine("\nERROR: Что-то пошло не так! Попробуйте снова!");
                            continue;
                        }
                }
            }
        }

        private long setAnimalId() {
            List<Animal> animalList = contr.getAllAnimals();
            long startId = 0;
            foreach (Animal animal in animalList) {
                if (animal.getId() > startId) {
                    startId = animal.getId();
                }
            }
            return startId + 1;
        }
    }
}
