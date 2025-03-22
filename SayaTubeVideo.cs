using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300046
{
    //membuat class SayaTubeVideo
    internal class SayaTubeVideo
    {
        //atribut
        private int id;
        private string title;
        private int playCount;
        
        //konstruktor
        public SayaTubeVideo(string title)
        {
            //generate id secara random sebanyak 5 digit
            Random random = new Random();
            this.id = random.Next(10000, 99999);

            //inisialisasi atribut
            this.title = title;
            this.playCount = 0;
        }

        //method IncreasePlayCount
        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }


        //method PrintVideoDetail
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }
    }
}
