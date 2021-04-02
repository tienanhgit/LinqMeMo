using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqMeMo.LINQ
{
    class GroupBy_ToLookup
    {
        //Group by là gom nhóm, toLookup  giống như group by nhưng khác biệt
        //duy nhất là group by bị hoãn trong khi thực thi ToLookup ngay lập tức
        public dynamic GroupByStudent(List<Student> studentList)
        {
            var groupResult = studentList.GroupBy(s => s.StudentID);
            return groupResult;
        }

        public dynamic ToLookUpStudent(List<Student> studentList)
        {
            var groupedResult = studentList.ToLookup(s => s.Age);
            return groupedResult;
        }
    }
}
