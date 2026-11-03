using PZ4;

namespace PZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");

            Animal animal = dog; // Присвоєння об'єкта Dog змінній типу Animal
            animal.MakeSound(); // Поліморфізм: викликається метод MakeSound() для об'єкта Dog

            Cat cat = new Cat("Whiskers");
            cat.MakeSound(); // Викликається метод MakeSound() для об'єкта Cat

            animal = cat; // Присвоєння об'єкта Cat змінній типу Animal
            animal.MakeSound(); // Не поліморфізм: викликається метод MakeSound() для об'єкта Cat, але через Animal
        }
    } 
}