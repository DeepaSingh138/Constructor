using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_assignment
{
    public class Student
    {
       
        
            public string name;
            public int rollno;
            public Student()
            {
                Console.WriteLine("Default Constructor invoked");
            }
            public Student(string fullname, int rollnum)
            {
                name = fullname;
                rollno = rollnum;
                Console.WriteLine("Parameterized Constructor is invoked");
            }

        }
    }

