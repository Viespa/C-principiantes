using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


class Main
{
    public static void Main(string[] args)
    {
        new MySampleFromReflection();
    }

    static void DoSomethingWithMyClass<T>() where T: new()
    {
        Activator.CreateInstance<T>();

    }

    static void SampleWithAttributes()
    {
        MySampleFromReflecrtion sample =  new MySampleFromReflecrtion();
        MyAttribute attr = (MyAttribute)sample.GetType().GetCustomAttributes(false).FirstOrDefault();

       

    }
}