using Moq;
using NUnit.Framework;
using SourceCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    internal class GroupControllerTest
    {
        private GroupController? _classUnderTest;
        private Dictionary<string, Trainee> _group;
       
        [Test]
        public void TestGetAllTraineesMethodSoThatItCallsTheReadGroupMethodOfIDatabaseReader()
        {

            //arrange
            Mock<IDatabaseReader> mockDatabaseReader = new Mock<IDatabaseReader>();
            _classUnderTest = new GroupController(mockDatabaseReader.Object, null);
            
            Mock<Trainee> mockTrainee1 = new Mock<Trainee>();
            _group = new Dictionary<string, Trainee>();
            _group.Add("Username1", mockTrainee1.Object);

            mockDatabaseReader.Setup(reader => reader.ReadGroup()).Returns(_group);

            //act
            var dataReceived = _classUnderTest.GetAllTrainees();

            //assert
            Assert.AreEqual(_group, dataReceived);
        }

        [Test]
        public void TestRemoveTraineeByUsernameMethodSoThatItCallsDeleteTraineeByUsername()
        {
            //arrange
            Mock<IDatabaseWriter> mockDatabaseWriter = new Mock<IDatabaseWriter>();
            _classUnderTest = new GroupController(null, mockDatabaseWriter.Object);

            //act
            _classUnderTest.RemoveTraineeByUsername("Username1");

            //assert
            mockDatabaseWriter.Verify(w => w.DeleteTraineeByUsername("Username1"), Times.Once);
            mockDatabaseWriter.Verify(w => w.DeleteTraineeByUsername(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void TestAddTraineeMethodPassesTraineeArgumentToMethodAddTraineeOfIDatabaseWriter()
        {
            //arrange
            Mock<IDatabaseWriter> mockDatabaseWriter = new Mock<IDatabaseWriter>();
            Mock<Trainee> traineeToBeAdded = new Mock<Trainee>();
            _classUnderTest = new GroupController(null, mockDatabaseWriter.Object);

            //act
            _classUnderTest.AddTrainee(traineeToBeAdded.Object);

            //assert
            mockDatabaseWriter.Verify(w => w.AddTrainee(traineeToBeAdded.Object), Times.Once);
            mockDatabaseWriter.Verify(w => w.AddTrainee(It.IsAny<Trainee>()), Times.Once);

        }


    }
}
