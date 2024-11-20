using OOPConsoleAPP;

namespace PersonUnitTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Student_Work_ShouldReturn_Studying()
        {
            // Arrange
            var student = new Student();

            // Act
            var result = student.Work();

            // Assert
            Assert.AreEqual("Student is studying.", result);
        }

        [TestMethod]
        public void Teacher_Work_ShouldReturn_Teaching()
        {
            // Arrange
            var teacher = new Teacher();

            // Act
            var result = teacher.Work();

            // Assert
            Assert.AreEqual("Teacher is teaching.", result);
        }

        [TestMethod]
        public void Person_Work_ShouldReturn_Working()
        {
            // Arrange
            var person = new Person();

            // Act
            var result = person.Work();

            // Assert
            Assert.AreEqual("Person is working.", result);
        }
    }
}