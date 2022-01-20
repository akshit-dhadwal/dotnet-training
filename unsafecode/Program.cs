using System;
using N2;

namespace N1
{
    class Testing
    {
        static unsafe void Main(string[] args)
        {
            Test s = new Test();
            int n,f;
            f = 1;
            System.Console.WriteLine("Enter n value ");
            n = Convert.ToInt32(Console.ReadLine());
            s.Calc(n, ref f);
            System.Console.WriteLine("Factorial value is: " +f);

            int var = 20;
         int* p = &var;
         
         Console.WriteLine("Data is: {0} ",  var);
         Console.WriteLine("Address is: {0}",  (int)p);
         Console.ReadKey();


         Console.WriteLine("The number of generations are: " +
                                           GC.MaxGeneration);          //  find maximum no of generations supported by system 

         Console.WriteLine("The generation number of object s is: "  
                                          + GC.GetGeneration(s));      // return generation number of target object     


            
            
        }

       
    }
}