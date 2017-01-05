using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacheloretteManager.Core;
using BacheloretteManager.Core.Interfaces;

namespace BacheloretteManager.Infrastucture
{
    public class StudentRepository : IStudentRepository
    {
        DatabaseContext database = new DatabaseContext();
        public void Add(Student student)
        {
            database.Students.Add(student);
            database.SaveChangesAsync();
        }

        public void Edit(Student student)
        {
            var toUpdate = database.Students.FirstOrDefault(t => t.Id == student.Id);
            toUpdate.FirstName = student.FirstName;
            toUpdate.LastName = student.LastName;
            toUpdate.Password = student.Password;
            toUpdate.MeanA1 = student.MeanA1;
            toUpdate.MeanA2 = student.MeanA2;
            toUpdate.Preferences = student.Preferences;
            database.SaveChanges();
        }

        public Student FindById(string studentID)
        {
            throw new NotImplementedException();
        }

        public Student FindById(int studentId)
        {
            var student = (from s in database.Students where s.Id.Equals(studentId) select s).FirstOrDefault();
            return student;

        }

        public IEnumerable<Student> GetStudents()
        {
            return database.Students;
        }

        public void Remove(int studentID)
        {
            Student student = (from s in database.Students where s.Id.Equals(studentID) select s).FirstOrDefault();
            database.Students.Remove(student);
            database.SaveChanges();
        }
    }
}
