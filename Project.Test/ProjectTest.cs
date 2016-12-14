using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Infrastructure;

namespace Project.Test
{
    [TestClass]
    public class ProjectTest
    {
        TeacherRepository repo;
        [TestInitialize]
        public void TestSetUp() {
            TeacherInitializeDb db = new TeacherInitializeDb();
            //System.Data.Entity.Database.SetInitializer(db);
            repo = new TeacherRepository();
        }
        [TestMethod]
        public void IsRepositoryInitializedWhitValidNumberOfData() {
            repo.Add(new core.Teacher
            {
                TeacherFirstName = "x",
                TeacherLastName = "y",
                Avaible = 0
            });

            var result = repo.GetTeachers();
            Assert.IsNotNull(result);
        }
    }
}
