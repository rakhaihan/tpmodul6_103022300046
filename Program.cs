using System;

namespace tpmodul6_103022300046
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rakha_Raihanurrahman");

            //menampilkan video
            video.PrintVideoDetails();

            //menambahkan playcount
            video.IncreasePlayCount(25);

            Console.WriteLine("\n");
            Console.WriteLine("Setelah ditambahkan playcount");
            //menampilkan video setelah playcount ditambah
            video.PrintVideoDetails();
        }
    }
}