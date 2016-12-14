using System.Collections.Generic;

namespace Project.core.Interfaces
{
    public interface ITeacherRepository
    {
        void Add(Teacher teacher);
        void Edit(Teacher teacher);
        void Remove(int teacherID);
        IEnumerable<Teacher> GetTeachers();
        Teacher FindById(int teacherID);
    }
}
