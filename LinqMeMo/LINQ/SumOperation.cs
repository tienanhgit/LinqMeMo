using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo.LINQ
{
    class SumOperation
    {
        //Aggregate :Thực hiện một thao tác tổng hợp tùy chỉnh trên các giá trị trong danh sách

        public void AggregateLinq(IList<Student> studentList)
        {
            string result = studentList.Aggregate<Student, Student>(
                     "StudentName",// seed value
                         (str, s) => str += s.StudentName + ",");
            //string result=studentList.Aggregate<Student,string>("a",(s1,s2)=>s2.StudentName+", "+s2.StudentName);
            Console.WriteLine(result);
        }




    }
}
