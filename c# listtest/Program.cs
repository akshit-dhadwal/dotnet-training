using System;
using System.Collections.Generic;
using System.Collections;

namespace Program
{
    class Listing
    {
       public  static void Main(string[] args)
        {
          /*  List<int> test =  new List<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);

            foreach(var tst in test)
            {
                if(tst == 3)
                {
                    System.Console.WriteLine(tst);
                }

                else
                {
                    System.Console.WriteLine("values not matching");
                }
            }*/

            TestDetail d = new TestDetail();
            List<Test> tm = d.Details();

            foreach(Test g in tm){
                if(g.code == 1234){
                    System.Console.WriteLine(g.name);
                }
            }
            
             
        }
    }
}