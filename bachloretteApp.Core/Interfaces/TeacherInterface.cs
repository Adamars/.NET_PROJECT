using System.Collections.Generic;

namespace bachloretteApp.Core.Interfaces
{
    public interface TeacherInterface
    {
        void Add(Teacher teacher);
        void Edit(Teacher teacher);
        void Remove(string teacherID);
        IEnumerable<Teacher> GetTeachers();
    }
}
