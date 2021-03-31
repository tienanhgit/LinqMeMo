using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo.LINQ
{
    class Where_And_OfType
    {
        private IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 },
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
            };
        public dynamic WhereInLinq()
        {
            //Dùng để lọc danh sách dựa trên các điều kiện
            // Student collection
            // LINQ Query Syntax to find out teenager students
            //var teenAgerStudent = from s in studentList
            //                      where s.Age > 12 && s.Age < 20
            //                      select s;
            var teenAgerStudent = from s in studentList
                                  where studentList.IndexOf(s) % 2 == 0
                                  where s.Age < 16
                                  select s;
            return teenAgerStudent.ToList();
        }
        public dynamic OfTypeInLinq()
        {
            IList mixlist = new ArrayList();
            mixlist.Add(0);
            mixlist.Add("Anh BT ne");
            mixlist.Add(3);
            var intResult = from s in mixlist.OfType<string>()
                            select s;
            return intResult.ToList();
        }
    }
}
