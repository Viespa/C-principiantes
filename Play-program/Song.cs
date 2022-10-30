using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


public class Song : Media
{

    public long Seconds {get; set; }

   

    public ShelvePosition Position {get; set; }

    public int Category { get; set; }

    public List<Artist> Artists{get; set;}

    public int Visits { get; set; }

    public override void Play()
    {
        Console.WriteLine("Increase volume");
        base.Play();
    }

   
    public override string ToString()
    {
        return $"Title:{Title} Duration: {Seconds}";
    }
   


}