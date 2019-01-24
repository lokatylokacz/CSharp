using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // stan klasy (zmienne w klasie pola)
        List<float> ratings = new List<float>(); // lista - kolekcja generyczna // 

        // zachowania klasy (zazwyczaj metody)
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAvarage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count(); // count da ilość elementów kolekcji
            return avg;
        }

        public float MaxRating()
        {
            return ratings.Max();
        }

        public float MinRating()
        {
            return ratings.Min();
        }
    }
}
