using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacheloretteManager.Core.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Edit(Student student);
        void Remove(int studentID);
        IEnumerable<Student> GetStudents();
        Student FindById(string studentID);
    }
}
