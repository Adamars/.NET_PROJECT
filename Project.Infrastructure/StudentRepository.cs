using Project.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.core;

namespace Project.Infrastructure
{
    public class StudentRepository : IStudentRepository
    {
        StudentContext context = new StudentContext();
        public void Add(Student student)
        {
            context.Students.Add(student);
        }

        public void Edit(Student student)
        {
            var toUpdate = context.Students.FirstOrDefault(t => t.StudentId == student.StudentId);
            toUpdate.StudentFirstName = student.StudentFirstName;
            toUpdate.StudentLastName = student.StudentLastName;
            toUpdate.MeanA1 = student.MeanA1;
            toUpdate.MeanA2 = student.MeanA2;
            toUpdate.Preferences = student.Preferences;
            context.SaveChanges();
        }

        public Student FindById(string studentID)
        {
            throw new NotImplementedException();
        }

        public Student FindById(int studentId)
        {
            var student = (from s in context.Students where s.StudentId.Equals(studentId) select s).FirstOrDefault();
            return student;

        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students;
        }

        public void Remove(int studentID)
        {
            Student student = (from s in context.Students where s.StudentId.Equals(studentID) select s).FirstOrDefault();
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
