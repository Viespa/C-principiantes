using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


public class PlayList<T, V, Z>
{
    
}



public class PlayList<T> where T : song
{

   List<T> mediaList = new List<T>();
    
    public void Add(T media)
    {
        medialist.Add(media);
        
    }
    

    public void PlayAll()
    {
        foreach (T media in list)
        {
            Console.WriteLine(media);
        }
    }


    public void Preview()
    {
        if (mediaList.Count > 0)
        {
            Console.WriteLine(mediaList[0]);       
        }
    }


    public List<T> SearchForCategory(string category)
    {


        mediaList.Where(x => x.Category == category );

     
        return songs.ToList();
    }


    public List<T> SearchForTitle(string title)
    {
        List<T> songs = new List<T>();

         foreach (Song song in mediaList)
        {
            if (song.Title.contains(title))
            {
                songs.Add(song);
            }
        }
        return songs;
    }

    public List<string> GimmeTitlesFromSongs()
    {

        mediaList.Select(x => x.Title);

        var titles = mediaList.Select(x => new Tuple<string, string>(x.Title, x.Category));

        return titles.ToList();

    }

    public List<string> GimmeNamesOfArtists()
    {
        var nameOfArtists =  mediaList.SelectMany(x => x.Artists)
                                      .Select(x => x.Name);

        return nameOfArtists.ToList();
    }

    public bool HaveATitle(string title)
    {
        return mediaList.Any(x => x.Title == title);
    }


    public Song GetFirstSonfWithLess1Minute()
    {
        var song = mediaList.FirstOrDefault(x => x.Seconds < 60);

        return song;
    }


    public Song GetLasSongWithLess1Minute()
    {
          var song = mediaList.LastOrDefault(x => x.Seconds < 60);
          return song;
    }

    public List<T> Top10()
    {
        return mediaList.OrderByDescending(X => x.Visits)
                                                 .Take(10).ToList();
        
    }

    public Song[] Bottom10()
    {
        return  mediaList.OrderBy(x => x.Visits)
                                        .Take(10).ToArray();
    }


    public void GroupFromCategory()
    {
        mediaList.GroupBy(x => x.Category)
                 .ToDictionary(x => x.Key);
    }


     public List<T> Skip10Top20()
    {
        
        return  mediaList.Skip(10).Take(10).ToList();
    }


    public List<Media> ToConvertMedia()
    {
        return mediaList.OfType<Media>().ToList();
    }

}