using System.Xml.Linq;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Mary";
            byte age = 27;
            bool haveAPet = true;
            double shoeSize = 37.5;

            Console.WriteLine(myName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine($"\t My name is \n {myName}");
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            Console.WriteLine("Как вас зовут?\nСколько вам лет?\nЕсли ли у вас питомец?\nКакой у вас размер ноги?\n");
            Console.WriteLine($"Меня зовут {myName}");
            Console.WriteLine($"Мне {age} лет");
            Console.WriteLine($"У меня есть питомец? {haveAPet}");
            Console.WriteLine($"Мой размер ноги {shoeSize}");

            

            Console.ReadKey();
        }
    }
}
