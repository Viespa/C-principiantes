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

    T[] mediaList = new T[] { };

    public void Add(T media)
    {

    }
    

    public void PlayAll()
    {
        foreach (T media in mediaList)
        {
            Console.WriteLine(media);
        }
    }
}