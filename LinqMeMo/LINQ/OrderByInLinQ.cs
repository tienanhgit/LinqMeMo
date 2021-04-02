using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo.LINQ
{
    class OrderByInLinQ
    {
        //Order by sắp xếp các phần tử trong danh sách dựa trên các trường được chỉ định
        //Order by , OrderByDescending,ThenBy,ThenByDescending,Reverse

        public dynamic OrderByStudent(List<Student> studentList)
        {
            var orderByResult = from s in studentList
                                orderby s.Age
                                select (s.StudentName, s.Age);
            return orderByResult.ToList();
        }
        public dynamic OrderByDescending(List<Student> studentList)
        {
            var orderByResult = from s in studentList
                                orderby s.Age descending
                                select (s.StudentName, s.Age);
            return orderByResult.ToList();
        }

        //Then By dùng để sắp xếp danh sách theo thứ tự tăng dần của trường tiếp
        //theo nếu trường đầu tiên có giá trị giống nhau
        public dynamic ThenByStudent(List<Student> studentList)
        {
            //use lambda expressions 
            var multiSortingResult = studentList.OrderBy(w => w.StudentName).ThenBy(w => w.Age);


            return multiSortingResult.ToList();
        }
        //Reverse 
        public dynamic ReverseStudent(IList<Student> studentList)
        {

            var multiSortingResult = studentList.Reverse();

            return multiSortingResult.ToList();

        }









    }
}
