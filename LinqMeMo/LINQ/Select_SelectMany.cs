using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo.LINQ
{
    class Select_SelectMany
    {
        public dynamic SelectStudent(IList<Student> studentList)
        {
            var selectResult = from s in studentList
                               select
                               new
                               {
                                   StudentName = "Mr" + s.StudentName,
                                   Age = s.Age
                               };
            return selectResult;
        }

        public dynamic SelectStudentSub(IList<Student> studentList)
        {
            var selectResult = studentList.Select(s => new
            {
                StudentName = "Mrs" + s.StudentName,
                Age = s.Age
            });
            return selectResult;
        }

        public dynamic SelectMany(IList<StudentLanguage> studentLanguages)
        {
            var selectManyResult = studentLanguages.SelectMany(s => s.Programming);
            return selectManyResult.ToList();
        }




    }
}
