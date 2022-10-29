using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


class Main{

    static void Main(string[] args)
    {
        Song song = new Song();// 1
        song.Title = "Dark side of moon";
        song.Seconds = 500;
        song.Position = new ShelvePosition(0,0);
        song.Play();


        Song song2 = new Song(); // 2

        song.Title = "Dark side of moon";
        song.Seconds = 35O;
        song.Position = new ShelvePosition(1,0);

     
        Console.WriteLine(song2.ToString);

        Console.ReadKey();
    }
}