using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();
            for (; ; ) // pusty nieskończony for wymagane 2 ;
            {
                Greeting();
                Age();
                ResetSettings();
            }
        }

        private static void ValueType()
        {
            int maxInt = int.MaxValue; // właściwość nie metoda () 
            int minInt = int.MinValue;
            long maxLong = long.MinValue;
            long minLong = long.MinValue;

            Console.WriteLine("Max Int = " + maxInt);
            Console.WriteLine("Min Int = " + minInt);
            Console.WriteLine("Max long = " + maxLong);
            Console.WriteLine("Min Long = " + minLong);
        }

        /// <summary>
        /// reset ustawien Console
        /// </summary>
        private static void ResetSettings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor(); // lol ? metoda na reset koloru xD 
        }

        /// <summary>
        /// Pobieramy wiek
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age); //tryParse lepsze od Parse
            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pijesz wóde.");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadź odpowiedni wiek!");
            }
            else
            {
                Console.WriteLine("No to mleczki.");
            }
        }

        /// <summary>
        /// Pobieramy Imię
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz imie: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
