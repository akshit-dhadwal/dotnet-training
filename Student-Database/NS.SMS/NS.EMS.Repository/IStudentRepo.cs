using NS.SMS.Model;
using NS.SMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.EMS.Repository
{
    public interface IStudentRepo
    {
        bool AddStudent(StudentModel studentModel);

        List<Student> ShowDetail();

        Student GetById(int StudentId);
        bool Update(StudentModel studentModel, int Id);

        bool Delete(StudentModel studentModel, int Id);

        List<StudentDeptModel> GetStudent();


    }
}
