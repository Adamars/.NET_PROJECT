using Project.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Project.core;

namespace Project.Infrastructure
{
    public class TeacherRepository : ITeacherRepository
    {
        TeacherContext context = new TeacherContext();
        public void Add(Teacher teacher)
        {
            context.Teachers.Add(teacher);
        }

        public void Edit(Teacher teacher)
        {
            var toUpdate = context.Teachers.FirstOrDefault(t => t.TeacherId == teacher.TeacherId);
            toUpdate.TeacherFirstName = teacher.TeacherFirstName;
            toUpdate.TeacherLastName = teacher.TeacherLastName;
            context.SaveChanges();
        }

        public Teacher FindById(int teacherID)
        {
            var teacher = (from t in context.Teachers where t.TeacherId.Equals(teacherID) select t).FirstOrDefault();
            return teacher;

        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return context.Teachers;
        }

        public void Remove(int teacherID)
        {
            Teacher teacher = (from t in context.Teachers where t.TeacherId.Equals(teacherID) select t).FirstOrDefault();
            context.Teachers.Remove(teacher);
            context.SaveChanges();
        }
    }
}
