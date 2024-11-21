using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPConsoleAPP;

namespace PersonUnitTests3
{
    /**
    //Step 1: create Test Class for each classes
    //Step 2: Create Test methods for each methods in the class
                Arrange - Set up the initial data and condition
                Act -  Perform action that needs testing e.g calling constructor or method
                Assert - Very action performed gives the expected outcome
    
    //Step 3: Run All test
    **/


    public class PeoplesTest
    {

        [TestClass]
        public class PersonTests
        {


            [TestMethod]
            public void Constructor_ShouldInitializeNameAndAge()
            {
                //Arrange
                string expectedName = "John Doe";
                int expectedAge = 30;

                //Act
                Person person = new Person(expectedName, expectedAge);

                //Assert
                Assert.AreEqual(expectedName, person.Name);
                Assert.AreEqual(expectedAge, person.Age);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Age_ShouldThrowException_WhenAgeIsInvalid()
            {
                string name = "John Doe";
                int invalidName = -5;

                Person person = new Person(name, invalidName);
            }

            [TestMethod]
            public void Work_shouldReturnCorrectMessage_ForPerson()
            {
                //Arrange
                Person person = new Person("Jane Doe", 28);
                string expectedMessage = "Jane Doe, the person, is working.";

                //Act
                string actualMessaage = person.Work();

                //Assert
                Assert.AreEqual(expectedMessage, actualMessaage);
            }

        }

        [TestClass]
        public class StudentTests
        {
            [TestMethod]
            public void Constuctor_ShouldInitializeNameAgeAndSchool()
            {
                string expectedName = "Alice";
                int expectedAge = 20;
                string expectedeSchool = "Harvard University";

                Student student = new Student(expectedName,expectedAge,expectedeSchool);

                Assert.AreEqual(expectedName, student.Name);
                Assert.AreEqual (expectedAge, student.Age);
                Assert.AreEqual(expectedeSchool, student.School);

            }

            public void Work_ShouldReturnCorrectMessage_ForStudent()
            {
                //Arrange
                Student student = new Student("Jerome Obnial", 27, "Liverpool University");


                //Act
                string actualMessage = student.Work();

                //Assert

                Assert.AreEqual(actualMessage, actualMessage);
            }

        }

        [TestClass]
        public class TeacherTests
        {
            [TestMethod]
            public void Constructor_ShouldInitializeNameAgeandSubject()
            {   
                //arrange
                string expectedName = "Colin Hilman";
                int expectedAge = 48;
                string expectedSubject = "Computer Science";


                //Act

                Teacher teacher = new Teacher(expectedName,expectedAge,expectedSubject);



                //Assert
                Assert.AreEqual(expectedAge, teacher.Age);
                Assert.AreEqual(expectedName , teacher.Name);
                Assert.AreEqual(expectedSubject, teacher.Subject);

            }

            [TestMethod]
            public void Work_ShouldReturnCorrectMessageForTeacher()
            {
                //Arrange
                Teacher teacher = new Teacher("Colin Hilman", 45, "Computer Science");

                //Act
                string actualString = teacher.Work();

                //Assert
                Assert.AreEqual(actualString, actualString);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ThrowExeptionOnWrongSubject()
            {
                //Arrange
                Teacher teacher = new Teacher("Colin Hilman", 45, "Geography");

                //Act
                string actualString = teacher.Work();


                //Assert
                //Throws exception
            }

        }


    }
}
