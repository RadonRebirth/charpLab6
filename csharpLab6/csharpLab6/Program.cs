using System;

namespace csharpLab6
{
    public class Animal
    {
        public string name;
        public string food;
        public string location;

        public Animal(string name, string food, string location)
        {
            this.name = name;
            this.food = food;
            this.location = location;
        }
        public void makeNoise() => Console.WriteLine($"{name} шумит");
        public void eat() => Console.WriteLine($"{name} кушает {food}");
        public void sleep() => Console.WriteLine("Животное спит");
    }
    class Cat : Animal 
    {
        public Cat(string name, string food, string location) : base(name, food, location) { }
    }
    class Dog:Animal
    {
        public Dog(string name, string food, string location) : base(name,food,location) { }
    }
    class Horse:Animal
    {
        public Horse(string name, string food, string location) : base(name, food, location) { }
    }
    class Veterinar
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine($"\nИнформация о пациенте: \n" +
                $"На приёме у ветеринара сейчас {animal.name} \n" +
                $"Имя питомца: {animal.name} \nПредпочитаемое питание: {animal.food} \nПоследнее место нахождение: {animal.location}");
        }
    }
    public class main
    {
        static void Main(string[] args)
        {
            Veterinar vet = new Veterinar();
            Console.WriteLine("Как зовут котёнка: ");
            string name = Console.ReadLine();
            Cat cat = new Cat(name, "Кошачий корм", "Дома на кроватке");
            cat.makeNoise();
            vet.treatAnimal(cat);
            
            Console.WriteLine(" ");
            Console.WriteLine("Как зовут собачку: ");
            name = Console.ReadLine();
            Dog dog = new Dog(name, "Собачий корм", "Во дворе в будке");
            dog.sleep();
            vet.treatAnimal(dog);
           
            Console.WriteLine(" ");
            Console.WriteLine("Как зовут лошадь: ");
            name = Console.ReadLine();
            Horse horse = new Horse(name, "Яблоко", "В загоне на конюшне");
            horse.eat();
            vet.treatAnimal(horse);
        }
    }
}