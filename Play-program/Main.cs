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


        DownloadSong();

       // WriteLineSpecial<IEnumerable>();

        Console.WriteLine(song2.ToString);

        Console.ReadKey();

        Tuple<int, string, Song> tuple = new Tuple<int, string, Song>(0, "Hola", song);

        ListExplanation();
        StackExplanation();
        QueueExplanation();
        DictionaryExplanation();
       // List<int> numbers =  new List<int>();

    }


    private static void DictionaryExplanation()
    {

        Dictionary<string, Client> clients =  new Dictionary<string, Client>();

        clients.Add("00000000D" , new Client() {Name = "Joseph"});
        
        if(!clients.ContainsKey("00000000D"))
        {
           clients.Add("00000000D" , new Client() {Name = "Joseph"});
        }
        else
        {
            
        }


        clients["00000000D"] = new Client();

        Client myCLient = clients["00000000D"];  

        var elements = new List<KeyValue<string, Client>>();
        elements.Add(new KeyValuePair<string, Client>("001", new Client()));
        elements.Add(new KeyValuePair<string, Client>("002", new Client()));

        //Utils.AddRangeDictionary(clients,elements);    

        clients.AddRange(elements);
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


    private static void DownloadSong()
    {
        DownloadService downloadService = new DownloadService();
        byte[] song =  downloadService.Download("Dark side of the moon");
    }


    private async static void DownloadSongAsync()
    {
        DownloadService downloadService =  new DownloadService();
        byte[] futureSong = await downloadService.DownloadAsync("Dark side of the moon");

       
        
    }
    private static void ListExplanation()
    {
        List<int> numbers = new List<int>();

        numbers.Add(0);
        numbers.Add(1);

       
    }


    static void WriteLineSpecial<T>(T data, string prefix, string suffix) where T : new()
    {
        T myNewType = new T();
        Console.WriteLine($"{prefix} {data.Title} {suffix}");
    }
}