using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo
{
    class Student
    {
        private int _StudentID;
        private string _StudentName;
        private int _Age;
        private int _StandardID;

        public int StudentID { get => _StudentID; set => _StudentID = value; }
        public string StudentName { get => _StudentName; set => _StudentName = value; }
        public int Age { get => _Age; set => _Age = value; }
        public int StandardID { get => _StandardID; set => _StandardID = value; }

        public Student(int studentID, string studentName, int age, int standardID)
        {
            StudentID = studentID;
            StudentName = studentName;
            Age = age;
            StandardID = standardID;
        }

        public Student()
        {

        } 

    }
}
