using MySchool.Domain.Models;
using MySchool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentrepo;

        public StudentService(IStudentRepository studentrepo)
        {
            _studentrepo = studentrepo;
        }

        public Student CreateStudent(Student student)
        {
            _studentrepo.CreateStudent(student);
            return student;
        }

        public Student DeleteStudent(int id)
        {
            var student = _studentrepo.DeleteStudent(id);
            return student;
        }

        public Student GetStudent(int id)
        {
            var studentRecord = _studentrepo.GetStudent(id);

            return studentRecord;
        }

        public List<Student> GetStudents()
        {
            var studentList = _studentrepo.GetStudents();

            return studentList;
        }

        public Student UpdateStudent(Student student)
        {
            _studentrepo.UpdateStudent(student);
            return student;
        }
    }
}
