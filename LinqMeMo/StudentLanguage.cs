using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeMo
{
    class StudentLanguage
    {
        private int _ID;
        private string _Name;
        private List<string> _Programming;

        public StudentLanguage()
        {

        }
        public StudentLanguage(int iD, string name, List<string> programming)
        {
            _ID = iD;
            _Name = name;
            _Programming = programming;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public List<string> Programming { get => _Programming; set => _Programming = value; }
    }
}
