using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo.LINQ
{
    class Join_JoinGroup
    {
        public dynamic JoinDS(IList<string> strList1, IList<string> strList2)
        {
            var innerjoin = strList1.Join(strList2,
                str1 => str1,
                str2 => str2,
                (str1, str2) => str1
                );
            return innerjoin;
        }
        public dynamic JoinDSStudent(IList<Student> studentList, IList<Standard> standardList)
        {
            var innerjoin = standardList.GroupJoin(
                studentList,
                  std => std.StandardID,
                s => s.StandardID,
                (std, studentGroup) => new
                {
                    Students = studentGroup,
                    Standard= std.StandardName
                });
            return innerjoin;
        }



    }
}
