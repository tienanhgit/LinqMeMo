using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo
{
    class Standard
    {
        private int _StandardID;
        private string _StandardName;

        public Standard(int standardID, string standardName)
        {
            StandardID = standardID;
            StandardName = standardName;
        }

        public Standard() { }

        public int StandardID { get => _StandardID; set => _StandardID = value; }
        public string StandardName { get => _StandardName; set => _StandardName = value; }
    }
}
