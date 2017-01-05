using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacheloretteManager.Core;
using BacheloretteManager.Core.Interfaces;

namespace BacheloretteManager.Infrastucture
{
    public class TeacherRepository : ITeacherRepository
    {
        DatabaseContext database = new DatabaseContext();
        public void Add(Teacher teacher)
        {
            database.Teachers.Add(teacher);
            database.SaveChangesAsync();
        }

        public void Edit(Teacher teacher)
        {
            var toUpdate = database.Teachers.FirstOrDefault(t => t.Id == teacher.Id);
            toUpdate.FirstName = teacher.FirstName;
            toUpdate.LastName = teacher.LastName;
            toUpdate.Password = teacher.Password;
            toUpdate.Requirements = teacher.Requirements;
            toUpdate.FreeSpaces = teacher.FreeSpaces;
            toUpdate.Available = teacher.Available;
            database.SaveChanges();
        }

        public Teacher FindById(int teacherID)
        {
            var teacher = (from t in database.Teachers where t.Id.Equals(teacherID) select t).FirstOrDefault();
            return teacher;

        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return database.Teachers;
        }

        public void Remove(int teacherID)
        {
            Teacher teacher = (from t in database.Teachers where t.Id.Equals(teacherID) select t).FirstOrDefault();
            database.Teachers.Remove(teacher);
            database.SaveChanges();
        }
    }
}
