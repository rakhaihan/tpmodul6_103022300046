﻿using System;

namespace tpmodul6_103022300046
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // membuat objek dengan valid
                Console.WriteLine("Contoh input judul video valid");
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rakha_Raihanurrahman");
                video.PrintVideoDetails();
                Console.WriteLine("\n");

                // membuat objek dengan judul tidak valid (lebih dari 100 karakter)
                try
                {
                    Console .WriteLine("Contoh input judul video invalid (lebih dari 100 karakter)");
                    SayaTubeVideo videoInvalid = new SayaTubeVideo(new string('a', 101));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Gagal membuat objek videoInvalid: {ex.Message}");
                }
                Console.WriteLine("\n");


                // membuat objek dengan tidak valid (judul null)
                try
                {
                    Console.WriteLine("Contoh input judul video invalid (null)");
                    SayaTubeVideo videoInvalidNull = new SayaTubeVideo(null);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Gagal membuat objek videoInvalidNull: {ex.Message}");
                }
                Console.WriteLine("\n");


                // Menambahkan play count valid
                Console.WriteLine("Contoh input playcount valid, nilai = 100");
                video.IncreasePlayCount(100);
                Console.WriteLine("Setelah ditambahkan playcount:");
                video.PrintVideoDetails();
                Console.WriteLine("\n");

                // menambahkan play count dengan nilai tidak valid (melebihi batas)
                try
                {
                    Console.WriteLine("Contoh input playcount tidak valid (melebihi batas), nilai = 10000001");
                    video.IncreasePlayCount(10000001);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Gagal menambah play count: {ex.Message}");
                }
                Console.WriteLine("\n");

                // menambahkan play count dengan nilai tidak valid (kurang dari 0)
                try
                {
                    Console.WriteLine("Contoh input playcount tidak valid (kurang dari 0), nilai = -1");
                    video.IncreasePlayCount(-1);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Gagal menambah play count: {ex.Message}");
                }
                Console.WriteLine("\n");

                video.PrintVideoDetails();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal menjalankan program: {ex.Message}");
            }
        }
    }
}
