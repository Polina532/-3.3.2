// See https://aka.ms/new-console-template for more information
using System; // Подключенное пространство имен
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

namespace Module3 // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool MyPet = true;
            double MySize = 37.5;

            Console.WriteLine("My name is {0}", MyName);
            Console.WriteLine("My age is {0}", MyAge);
            Console.WriteLine("Do I have a pet?  {0}", MyPet);
            Console.WriteLine("My shoe size is {0}", MySize);

            Console.ReadKey();


        }
    }
}