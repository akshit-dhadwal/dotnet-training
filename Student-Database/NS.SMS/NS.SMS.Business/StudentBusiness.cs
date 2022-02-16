using NS.EMS.Repository;
using NS.SMS.Model;
using NS.SMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.SMS.Business
{
    public class StudentBusiness: IStudentBusiness
    {
        private readonly IStudentRepo _istudentrepo = null;

        public StudentBusiness(IStudentRepo istudentrepo)
        {
            _istudentrepo = istudentrepo;
        }


       public bool AddStudent(StudentModel studentModel)
        {
            return _istudentrepo.AddStudent(studentModel);
        }
       public List<Student> ShowDetail()
        {
            return _istudentrepo.ShowDetail();
        }

        public bool Update(StudentModel studentModel, int Id)
        {
           return  _istudentrepo.Update( studentModel, Id);
        }

        public Student GetById(int Id)
        {
            return _istudentrepo.GetById(Id);
        }

        public bool Delete(StudentModel studentModel, int Id)
        {
            return _istudentrepo.Delete(studentModel, Id);
        }
        public List<StudentDeptModel> GetStudent()
        {
            return _istudentrepo.GetStudent();
        }
    }
}
