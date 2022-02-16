using DBMigration_test.Context;
using System.Collections.Generic;
using System.Linq;

namespace DBMigration_test.Repository
{
    public class StudentRepository
    {
        private readonly MigrationContext _migrationcontext;

        public StudentRepository(MigrationContext migrationcontext)
        {
            _migrationcontext = migrationcontext;
        }

        public List<Studentcs> GetAllStudents()
        {
            List<Studentcs> students = new List<Studentcs>();
            using (var context = new MigrationContext())
            {
                students = context.Students.ToList();
            }
            return students;
            //return _migrationcontext.Students.Select(student => new Studentcs()
            //{
            //    StudentId = student.StudentId,
            //    StudentAge = student.StudentAge,
            //    StudentName = student.StudentName,
            //    CoverImageUrl = student.CoverImageUrl,


            //}).ToList();
        }

        public bool AddNewStudent(Studentcs studentcs)
        {
            var student = new Studentcs()
            {
                StudentId = studentcs.StudentId,
                StudentName = studentcs.StudentName,
                StudentAge = studentcs.StudentAge,
                CoverImageUrl = studentcs.CoverImageUrl,    

            };
            _migrationcontext.Students.Add(student);
            _migrationcontext.SaveChanges();
            return true;
        }

        public Studentcs GetStudentById(int id)
        {
            var student = _migrationcontext.Students.Find(id);

            if(student != null)
            {
                var newstudent = new Studentcs()
                {
                    StudentId = student.StudentId,
                    StudentName = student.StudentName,
                    StudentAge = student.StudentAge,
                    CoverImageUrl = student.CoverImageUrl,
                };

                return newstudent;
            }
            return null;
        }
    }
}
