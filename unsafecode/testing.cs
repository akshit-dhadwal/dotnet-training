using System;

namespace N2
{
    class Test
    {
       public void Calc(int n, ref int f)
       {
           for(int i=1;i<=n;i++)
           {
               f = f * i;
           }
       }
    }
}