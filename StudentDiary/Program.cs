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
            diary.AddRating(4);
            diary.AddRating(9);
            diary.AddRating(4.5f);

            DiaryStatistics stats = diary.ComputeStatitsics();
            Console.WriteLine("Średnia ocena: " + stats.avgGrade);
            Console.WriteLine("Max ocena: " + stats.MaxGrade);
            Console.WriteLine("Min ocena: " + stats.MinGrade);



            //for (; ;)
            //{
            //    Console.WriteLine("Podaj ocene: ");
            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(), out rating); 
            //    if (rating == 11)
            //    {
            //        break;
            //    }
            //    if (result && rating <= 10 && rating >= 0) 
            //    {
            //        diary.AddRating(rating);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Błędna liczba!");
            //    }

            //}
            Console.ReadKey();
        }
    }
}
