using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqMeMo.LINQ;

namespace LinqMeMo
{

    class Program
    {
        //create data
        #region Create Data
        static IList<StudentLanguage> studentListSub = new List<StudentLanguage>()
{
    new StudentLanguage(){ID = 1, Name = "James", Programming = new List<string>() { "C#", ".NET Core" }},
    new StudentLanguage(){ID = 2, Name = "Sam", Programming = new List<string>() { "WCF", "SQL Server" }},
    new StudentLanguage(){ID = 3, Name = "Patrik", Programming = new List<string>() { "MVC" }},
    new StudentLanguage(){ID = 4, Name = "Sara", Programming = new List<string>() { "ADO.NET", "LINQ" }}
};



        // Student collection
        static IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

        static IList<Standard> standardList = new List<Standard>()
            {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

        static IList<string> strList1 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four"
            };
        static IList<string> strList2 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Five",
                "Six"
            };

        #endregion

        #region Event
        public static void ForList(dynamic p)
        {
            //for(int i=0;i<p.Count;i++)
            //{
            //    Console.WriteLine("Name:"+p[i].StudentName);

            //}
            foreach (var s in p)
            {
               
               
                    Console.WriteLine(s);
                
               
            }

        }
        public static void DoubleForList(dynamic p)
        {
            foreach (var agegroup in p)
            {
                // Console.WriteLine(agegroup.GetType().GetProperty("Key").GetValue(agegroup, null));
                
                foreach (Student s in agegroup.Students)
                {
                    Console.WriteLine(s.StudentName);
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            OrderByInLinQ orderByInLinQ = new OrderByInLinQ();
            GroupBy_ToLookup groupBy_ToLookup = new GroupBy_ToLookup();
            Join_JoinGroup join_JoinGroup = new Join_JoinGroup();
            Select_SelectMany select_SelectMany = new Select_SelectMany();
            SumOperation sumOperation = new SumOperation();
            // ForList(orderByInLinQ.ThenByStudent(studentList.ToList()));
            //Where_And_OfType where_And_OfType = new Where_And_OfType();
            //ForList(where_And_OfType.WhereInLinq(studentList));
            // ForList(orderByInLinQ.ReverseStudent(studentList));
            //DoubleForList(groupBy_ToLookup.ToLookUpStudent(studentList.ToList()));
            //  DoubleForList(join_JoinGroup.JoinDSStudent(studentList, standardList));
            //ForList(join_JoinGroup.InnerJoinStudent(studentList, standardList));
            //ForList(select_SelectMany.SelectStudentSub(studentList));
            // ForList(select_SelectMany.SelectMany(studentListSub));

            sumOperation.AggregateLinq(studentList);
            // Student collection

         

       



            Console.ReadKey();
        }
    }
}




