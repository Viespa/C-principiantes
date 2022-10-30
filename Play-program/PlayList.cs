using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


public class PlayList<T, V, Z>
{
    
}



public class PlayList
{

   List<Song> mediaList = new List<Song>();
    
    public void Add(T media)
    {
        medialist.Add(media);
        
    }
    

    public void PlayAll()
    {
        foreach (Song media in list)
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


    public List<Song> SearchForCategory(string category)
    {


        mediaList.Where(x => x.Category == category );

     
        return songs.ToList();
    }


    public List<Song> SearchForTitle(string title)
    {
        List<Song> songs = new LIst<Song>();

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
}