using Microsoft.EntityFrameworkCore;
using MySchool.Domain.Models;
using MySchool.Infrastructure.Data;
using MySchool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Handler
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Student CreateStudent(Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                return student;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public Student DeleteStudent(int id)
        {
            try
            {
                var student = _context.Students.Find(id);
                _context.Students.Remove(student);
                _context.SaveChangesAsync();

                return student;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Student GetStudent(int id)
        {
            try
            {
                var stud = _context.Students.Find(id);
                return stud;
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        public List<Student> GetStudents()
        {
            try
            {
                return _context.Students.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Student UpdateStudent(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();

                return student;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
