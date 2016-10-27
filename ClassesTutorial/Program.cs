using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
       // String Nume;
       // String Prenume;

        static void Main(string[] args)
        {
            // sbyte a = -127;

            // Exercise 1 course 2
            Console.WriteLine("This is my first C# project.");

            //AbstractCar aCar = new AbstractCar();

            //EngineStruct engine = new EngineStruct();

            //Exercise 6 course 2
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            // Exercise 7 slide 21 course 2
            Mercedes _mercedes = new Mercedes();

            Console.WriteLine("Mercedes is " + _mercedes.Description);
            Console.WriteLine("Mercedes costs " + _mercedes.Price);

            Console.WriteLine("Model " + _mercedes.Model);
            Console.WriteLine("Consum " + _mercedes.Consum);

            //Exercise 1 slide 10 course 3
            Mercedes.StartEngine();

            //Exercise 3 course 3
            Mercedes m1 = new Mercedes();
            m1.ShowRemainingNoOfKM(10, 7);

            //Exercise 2 course 3
            double numberOfKM = m1.ShowRemainingNoOfKM(10, 7);
            Console.WriteLine(numberOfKM);

            //Exercise 4 slide 19 course 3
            Mercedes m2 = new Mercedes();
            m2.StartEngine(4);

            // Exercise 4 slide 21 course 3
            double km = m2.CalculateConsumption(14);
            Console.WriteLine(km);       

            Console.ReadKey();

            string fizbuz = FizBuz.ShowFizBuz(15);
            Console.WriteLine("fizbuz");

            PrintLogo();
            PrintLogo(1);
            PrintLogo2();
        }

        static void PrintLogo()
        {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great!");
            PrintLogo2();
        }

        static int counter;

        static void PrintLogo(int i)
        {
            Console.WriteLine("Another");
        }

        static void PrintLogo2()
        {
            counter++;

            Console.WriteLine("Logo 2");

            if (counter == 3)
            return;

            //PrintLogo2();
        }
    }
}