using System;
using System.Collections.Generic;




namespace School
{
    class TeacherDetail
    {
        public  void IsTeacherPromoted(List<TeacherModel> teachers, IsPromoted promoted)
        {
            foreach(TeacherModel teacher in teachers)
            {
                if(promoted(teacher))
                  System.Console.WriteLine("{0} is eligible for promotion", teacher.name);
                else
                  System.Console.WriteLine("{0} is not eligible for promotion", teacher.name);  
            }
        }

      
}
}
