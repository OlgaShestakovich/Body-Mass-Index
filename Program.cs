using System;
/*
 * Запросить у пользователя: фамилию, имя, возраст, вес, рост.
 * Высчитать ИМТ(индекс массы тела) по формуле ИМТ = вес(кг) / (рост (м) * рост(м))
 * Сформировать единую строку, в следующем формате:

    Your profile:
    Full Name: фамилия, имя
    Age: рост
    Weight: вес
    Height: рост
    Body Mass Index: ИМТ

 * Вывести сформированную строку на консоль.
 
*/
namespace Body_mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу фамилию: ");
            string LastName = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите ваше имя: ");
            string Name = Console.ReadLine();
            Console.Clear();

            Console.Write("Ваш возраст (полных лет): ");
            string Age = Console.ReadLine();
            Console.Clear();

            Console.Write("Ваш вес (кг): ");
            double Weight = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Ваш рост (м): ");
            double Height = double.Parse(Console.ReadLine());
            Console.Clear();

            double MassIndex = Weight / (Height * Height);

            Console.Write("Your profile:\n Full Name: " + LastName + " " + Name + "\n Age: " + Age + "\n Weight: " + Weight + "\n Height: " + Height + "\n Body Mass Index: " + MassIndex);
               
        }
    }
}
