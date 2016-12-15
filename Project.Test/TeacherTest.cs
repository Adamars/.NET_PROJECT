using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Infrastructure;

namespace Project.Test
{
    [TestClass]
    public class TeacherTest
    {
        TeacherRepository repo;
        [TestInitialize]
        public void TestSetUp() {
            TeacherInitializeDb db = new TeacherInitializeDb();
            //System.Data.Entity.Database.SetInitializer(db);
            repo = new TeacherRepository();
        }
        [TestMethod]
        public void WhenTheacherIsAdded_ThenNumberOfRowInRepository_ShouldGrowWithOne() {
            var beforeAdd = repo.GetTeachers();
            repo.Add(new core.Teacher {
                TeacherFirstName = "Nume2",
                TeacherLastName = "Prenume2",
                Avaible = 0
                });
            var afterAdd = repo.GetTeachers();
            Assert.AreNotEqual(beforeAdd, afterAdd);
        }
        [TestMethod]
        public void WhenRepositoryIsInitialized_ThenGetTeachers_ShouldReturnNotNullResult(){
            repo.Add(new core.Teacher
            {
                TeacherFirstName = "Nume1",
                TeacherLastName = "Prenume1",
                Avaible = 0
            });

            var result = repo.GetTeachers();
            Assert.IsNotNull(result);
        }
    }
}
