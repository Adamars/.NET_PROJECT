using System.Collections.Generic;

namespace bachloretteApp.Core.Interfaces
{
    public interface StudentInterface
    {
        void Add(Student student);
        void Edit(Student student);
        void Remove(string studnetID);
        IEnumerable<Teacher> GetStudents();
    }
}
