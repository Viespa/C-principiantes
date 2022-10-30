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

        song2.Title = "Dark side of moon";
        song2.Seconds = 350;
        song2.Position = new ShelvePosition(1,0);

        
        PlayList<Song> playListSongs = PlayList<Song>();

        playListSongs.Add(song);
        playListSongs.Add(song2);

        WriteLineSpecial<Song>(song, "Start with", "enjoy");

        Console.WriteLine(song2.ToString);

        Console.ReadKey();

        Tuple<int, string, Song> tuple = new Tuple<int, string, Song>(0, "Hola", song);

        ListExplanation();
        StackExplanation();
        QueueExplanation();
       // List<int> numbers =  new List<int>();

    }



    private static void QueueExplanation()
    {
        Queue<int> queueNumbers = new Queue<int>();
        queueNumbers.Enqueue(1);
        int number = queueNumbers.Dequeue();
    }




    private static void StackExplanation()
    {
        Stack<Song> salesSongs =  new Stack<Song>();

        salesSongs.Push(new Song());
        salesSongs.Push(new Song());
        salesSongs song = salesSongs.Pop();
    }

    private static void ListExplanation()
    {
        List<int> numbers = new List<int>();

        numbers.Add(0);
    
    }


    static void WriteLineSpecial<T>(T data, string prefix, string suffix)
    {
        Console.WriteLine($"{prefix} {data} {suffix}");
    }
}