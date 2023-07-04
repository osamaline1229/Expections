using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class student
    {
        string name { get; set; }
        string registrationNumber { get; set; }

        int age { get; set; }

        public student(string name, string registrationNumber, int age)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.age = age;
        }
        public static Boolean VlodateStudents(student[] students) 
        {
            for (int i = 0; i < students.Length; i++)
            {
                for(int j = 0; j < students.Length; j++)
                {

                    throw new ApplicationException("two Student have the Same RegistrationNumber");
                }
            }
            return true;
        }
    }
}
