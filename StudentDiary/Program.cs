using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); //Diary() - metoda konstruktor; Tworzenie instancji obiektu typu klasa diary 
            // konstreuktor domyślny => publiczny / pola inicjuje wartoścami 0 / false / null
            //diary.AddRating(5); // niejawna konwersja bo nic nie tracimy
            //diary.AddRating(8.5f); // double nie da się przekazać do float dlatego jest f żeby wiedział że to jest typ float
            //diary.AddRating(4.7f);
            //diary.AddRating(3.4f);

            //float avg = diary.CalculateAvarage();
            //float max = diary.MaxRating();
            //float min = diary.MinRating();


            for (; ;)
            {
                Console.WriteLine("Podaj ocene: ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating); 
                if (rating == 11)
                {
                    break;
                }
                if (result && rating <= 10 && rating >= 0) 
                {
                    diary.AddRating(rating);
                }
                else
                {
                    Console.WriteLine("Błędna liczba!");
                }
                
            }

            Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAvarage());
            Console.WriteLine("Max: " + diary.MaxRating());
            Console.WriteLine("Min: " + diary.MinRating());
            Console.ReadKey();
        }
    }
}
