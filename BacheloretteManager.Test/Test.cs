using BacheloretteManager.Core;
using BacheloretteManager.Infrastucture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BacheloretteManager.Test
{
    [TestClass]
    public class Test
    {
        TeacherRepository repo;
        [TestInitialize]
        public void TestSetUp()
        {
            //DatabaseContext database = new DatabaseContext();
            //System.Data.Entity.Database.SetInitializer(db);
            repo = new TeacherRepository();
        }
        [TestMethod]
        public void WhenRepositoryIsInitialized_ThenGetTeachers_ShoulReturnNotNullResult()
        {
            repo.Add(new Teacher
            {
                Id = new Guid(),
                FirstName = "x",
                LastName = "y",
                Password = "passwordtest",
                Role = 1,
                Requirements = "dhfagdkjfhdsakjf djsk ahfdksaf hkdjsaf ",
                FreeSpaces = 20,
                Available = 0
            });

            var result = repo.GetTeachers();
            Assert.IsNotNull(result);
        }
    }
}
