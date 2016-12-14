using System.Collections.Generic;

namespace Project.core.Interfaces
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
