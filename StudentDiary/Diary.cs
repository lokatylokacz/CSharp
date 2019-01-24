using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        // stan klasy (zmienne w klasie pola)
        List<float> ratings; // lista - kolekcja generyczna // 

        // zachowania klasy (zazwyczaj metody)
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        internal DiaryStatistics ComputeStatitsics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.avgGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }
    }
}
