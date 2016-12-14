using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.core.Interfaces
{
    public interface TeacherRepository
    {
        void Add(Teacher teacher);
        void Edit(Teacher teacher);
        void Remove(int teacherID);
        IEnumerable<Teacher> GetTeachers();
        Teacher FindById(int teacherID);
    }
}
