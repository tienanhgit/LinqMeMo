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
        public static void ForList(dynamic p)
        {
            for(int i=0;i<p.Count;i++)
            {
                Console.WriteLine(p[i]);

            }

        }


        static void Main(string[] args)
        {
            Where_And_OfType list = new Where_And_OfType();
            // ForList(list.WhereInLinq());
            ForList(list.OfTypeInLinq());
            Console.ReadKey();

        }
    }
}



