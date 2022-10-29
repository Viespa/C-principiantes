class Program
{
    static void Main(string[] args)
    {
      
      switch (switch_on)
      {
        case 1: 
        
        break;

        default:

        break;
      }
    
    }

    static void Declarations()
    {
        int number = 0;
        double numberDecimals = 0.0d;
        bool yayOrNay = true;
        string str = string.Empty;

    }

      static void Conditions()
    {
          int number = 0;
        number += 2;
        //number => 2

        number -= 2;
        //number => 0

        //==
        //!=
        //>=
        //<=
        //<
        //>

        //&& (AND)
        //|| (OR)

        //Saber el tipo de la variable
        typeof(number);

        if(number == 0)
        {
            print("El numero es 0")
        
        }else if(number != 0){

            print("El numero no es 0")

        }else{
            print("El numero no existe")
        }


    }

    static void loop(){
        for (int i = 0; i < length; i++)
      {
        
      }

      while (true)
      {
        
      }

      int [] collection = new int[]{ 1, 2, 3, 4, 5};

      foreach (int item in collection)
      {
        print(item);
      }
    }
}