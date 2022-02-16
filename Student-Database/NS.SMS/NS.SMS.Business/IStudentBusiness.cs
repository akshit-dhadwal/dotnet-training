using NS.SMS.Model;
using NS.SMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.SMS.Business
{
    public interface IStudentBusiness
    {
        bool AddStudent(StudentModel studentModel);
        Student GetById(int Id);
        List<Student> ShowDetail();

       public  bool Update(StudentModel studentModel, int Id);
        bool Delete(StudentModel studentModel, int Id);

        List<StudentDeptModel> GetStudent();
    }
}
