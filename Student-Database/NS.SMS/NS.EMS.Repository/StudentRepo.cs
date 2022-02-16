using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.SMS.Model;
using NS.SMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.EMS.Repository
{
    public class StudentRepo:IStudentRepo
    {
        public bool AddStudent(StudentModel studentModel)
        {
            using (var context = new StudentDBContext())
            {
                //Student student = new Student();
                
                //student.Name = studentModel.Name;
                //student.Email = studentModel.Email; 
                //student.Age = studentModel.Age; 
                //student.Division = studentModel.Division;   
                //student.FatherName = studentModel.FatherName;   
                //student.MotherName = studentModel.MotherName;   
                


                //context.Students.Add(student);
                //context.SaveChanges();

                var paraList =  new List<SqlParameter>();
                paraList.Add(new SqlParameter("@Name",studentModel.Name));
                paraList.Add(new SqlParameter("@Age", studentModel.Age));
                paraList.Add(new SqlParameter("@Division", studentModel.Division));
                paraList.Add(new SqlParameter("@FatherName", studentModel.FatherName));
                paraList.Add(new SqlParameter("@MotherName", studentModel.MotherName));
                paraList.Add(new SqlParameter("@Email", studentModel.Email));
                paraList.Add(new SqlParameter("@DeptId", studentModel.DeptId));
               // paraList.Add(new SqlParameter("@CoverImageUrl", studentModel.CoverImageUrl));

                context.Database.ExecuteSqlRaw("usp_AddStudent @Name,@Age,@Division,@FatherName,@MotherName,@Email,@DeptId", paraList);
            }


            return true;
           
        }
        public List<Student> ShowDetail()
        {
            List<Student> returnList = new List<Student>();
            using(var context = new StudentDBContext())
            {
                returnList = context.Students.ToList();
                 

                // returnList = context.Department.FromSqlRaw("usp_GetStudent").ToList();
                // returnList;

            }
            return returnList;
            
        }
        public bool Update(StudentModel studentModel, int Id)
        {
            using (var context = new StudentDBContext())
            {
               // context.Students.Find(Id);
                Student student = new Student();
                


                student.Name = studentModel.Name;
                student.Email = studentModel.Email;
                student.Age = studentModel.Age;
                student.Division = studentModel.Division;
                student.FatherName = studentModel.FatherName;
                student.MotherName = studentModel.MotherName;
                student.Id = Id;

                context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
               // context.Students.Update(student);
                context.SaveChanges();
            }
            return true;
        }

        public Student GetById(int Id)
        {

            StudentDBContext context = new StudentDBContext();

            
                var sid = context.Students.Where(x => x.Id == Id).FirstOrDefault();
                return sid;


        }
        public bool Delete(StudentModel studentModel, int Id)
        {
            using (var context = new StudentDBContext())
            {
                Student student = new Student();



                student.Name = studentModel.Name;
                student.Email = studentModel.Email;
                student.Age = studentModel.Age;
                student.Division = studentModel.Division;
                student.FatherName = studentModel.FatherName;
                student.MotherName = studentModel.MotherName;
                student.Id = Id;


                //context.Students.Find(Id);
                context.Remove(student);
                context.SaveChanges();
            }
               
            return true;
        }

        public List<StudentDeptModel> GetStudent()

        {
            List<StudentDeptModel> returnList = new List<StudentDeptModel>();
            using (var context = new StudentDBContext())
            {
                returnList  = context.Department.FromSqlRaw("usp_GetStudent").ToList();
                
            }
            return returnList;  
        }
    }
}
