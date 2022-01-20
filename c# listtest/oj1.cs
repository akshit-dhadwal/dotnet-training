using System;
using System.Collections.Generic;
using System.Collections;

namespace Program
{
    public class Test
    {
        public int code{get;set;}

        public string? name {get;set;}
    }
    
    public class TestDetail 
    {

       
        public List<Test> Details()
        {
            Test t  = new Test();
            t.code = 1234;
            t.name = "akshit";

            Test t1 = new Test();
            t1.code =  5678;
            t1.name =  "rajesh";

            List<Test> ty = new List<Test>();
            ty.Add(new Test{code = 1235, name = "riya"});
            ty.Add(t1);
            ty.Add(t);

            return ty;

        }
    }

}
