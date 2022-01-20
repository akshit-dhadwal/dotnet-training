using System;
using System.Collections.Generic;

namespace School
{

    public delegate bool IsPromoted(TeacherModel teacher);

    
    class Teacher
    {
        static void Main(string[] args)
        {
            IsPromoted  promoted = new IsPromoted(Example.Ispromoted);
            List<TeacherModel> teachers = new List<TeacherModel>();
            teachers.Add(new TeacherModel(){id = 1, name = "Akash", school = Example.name1, Age = 20, Salary = 40000, Experience = 4});
            teachers.Add(new TeacherModel(){id = 2, name = "ADRSH", school = Example.name2, Age = 40, Salary = 50000, Experience = 7});
            teachers.Add(new TeacherModel(){id = 3, name = "KASHISH", school = Example.name1, Age = 10, Salary = 10000, Experience = 6});
            teachers.Add(new TeacherModel(){id = 4, name = "AkaNSHA", school = Example.name3, Age = 50, Salary = 60000, Experience = 8});
            

            TeacherDetail detail = new TeacherDetail();
            detail.IsTeacherPromoted(teachers, promoted);
        }
    }
      class Example
    {
        public const string name1 = "DAV";

        public const string name2 = "CONVENT";

        public const string name3 = "ABSP";


       
        public static bool Ispromoted(TeacherModel teacher)
        {
              if(teacher.school == "DAV" && teacher.Age > 30)
              return true;
              else if(teacher.school == "CONVENT" && teacher.Experience > 8)
              return true;
              else if(teacher.school == "ABSP" && teacher.Salary > 40000)
              return true;
              else
              return false;
        }
    }
}