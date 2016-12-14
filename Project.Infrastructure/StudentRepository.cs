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
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public Student FindById(string studentID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void Remove(int studentID)
        {
            throw new NotImplementedException();
        }
    }
}
