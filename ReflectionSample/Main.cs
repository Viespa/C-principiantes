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

        PropertyInfo[] properties = sample.GetType().GetProperties();
        properties[0].SetValue(sample, "Jose Manuel");
        properties[0].GetValue(sample);



        MethodInfo[] methods = sample.GetType().GetMethods();

        MethodInfo doSomething =  methods.FirstOrDefault(x => x.Name == "DoSomething");


        if(doSomething != null)
        {
            doSomething.Invoke(sample, null);
        }


        sample.GetType().GetFields();

        Assembly.GetExecutingAssembly().GetManifestResourceNames();

    }
}