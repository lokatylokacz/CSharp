using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // diary przechowuje tylko wskaźnik na obiekt => zmienna referencyjna
            diary.AddRating(3);
            diary.AddRating(5);

            diary = new Diary();
            diary.AddRating(8);
        }
    }
}
