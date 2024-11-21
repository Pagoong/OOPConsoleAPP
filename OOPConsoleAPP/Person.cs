using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{
    public class Person
    {
        //Fields - MAKE SURE THEY ARE PRIVATE AND USE PROPERTIES TO ACCESS THEM
        private string _name;
        private int _age;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
            }
        }

        //Constructors

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }


        //Method can be overwritten
        public virtual string Work()
        {
            return $"{Name}, the person, is working.";
        }
    }

    public class Student : Person
    {
        private string _school;

        //properties
        public string School
        {
            get { return _school; }
            set { _school = value; }
        }

        //Constructor

        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }


        public override string Work()
        {
            return $"{Name}, a student at {School}, is studying.";
        }
    }

    public class Teacher : Person
    {   
        //field
        private string _subject;

        //properties

        public string Subject
        {
            get { return _subject; }
            set { if (value != "Geography")
                {
                    _subject = value;
                }
                else
                {
                    throw new ArgumentException("Geography is not allowed");
                }
            }
        }

        //constructor

        public Teacher(string name,int age, string subjects) : base(name, age)
        {
            Subject = subjects;
        }
            

        public override string Work()
        {
            return $"{Name}, a teacher of {Subject}, is teaching.";
        }
    }

   



}
