using MySchool.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        Student DeleteStudent(int id);
    }
}
