using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
          
            // prekondisi
            Contract.Requires(!string.IsNullOrEmpty(title), "Judul video tidak boleh kosong.");
            Contract.Requires(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");

            //jika contract dilanggar akan terjadi exception
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Judul video tidak boleh kosong.");
            if (title.Length > 100)
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");

            //generate id secara random
            Random random = new Random();
            this.id = random.Next(10000, 99999);

            //inisialisasi atribut
            this.title = title;
            this.playCount = 0;
        }

        //method IncreasePlayCount
        public void IncreasePlayCount(int playCount)
        {
            // prekondisi
            Contract.Requires(playCount > 0 && playCount <= 10000000, "Jumlah play count harus antara 1 dan 10.000.000.");

            //jika contract dilanggar akan terjadi exception
            if (playCount <= 0 || playCount > 10000000)
                throw new ArgumentOutOfRangeException(nameof(playCount), "Jumlah play count harus antara 1 dan 10.000.000.");

            // Menghindari overflow menggunakan checked
            checked
            {
                this.playCount += playCount;
            }
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
