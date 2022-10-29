using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


public class Media
{
    private int ParentRate;

    public long Title {get; set; }


    public virtual void Play()
    {
        COnsole.WriteLine($"Playing {Title}")
    }


    protected bool ThisContentIsCorrectForThisAge(int age)
    {
        if(age >= ParentRate)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

     // override object.Equals
    public override bool Equals(object obj)
    {
    
        var mediaObj = (Media)obj;

        if(mediaObj.Title == this.Title)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}