using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


public class PlayList<T, V, Z>
{
    
}



public class PlayList<T>
{

   List<T> mediaList = new List<T>();
    
    public void Add(T media)
    {
        list.Add(media);
        
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
}