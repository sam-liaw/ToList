using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Array Тр Dictionary
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            List<Student> StudentList = new List<Student>()
            {
                new Student()
                {
                    Id  = 1,
                    Name = "John",
                    Gender = "man"
                },
                new Student()
                {
                    Id  = 2,
                    Name = "Tom",
                    Gender = "man"
                }
            };
            Student[] StudentArray = StudentList.ToArray();
            Dictionary<int, Student> StudentDictionary = StudentArray.ToDictionary(key => key.Id, Studentobj => Studentobj);
        }
    }
}
