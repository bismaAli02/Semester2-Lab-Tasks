using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class Subject
    {
        // Constructor
        public Subject()
        {

        }
        public Subject(string code, int CH, string type)
        {
            this.code = code;
            this.CH = CH;
            this.type = type;
        }
        public string code;
        public int CH;
        public string type;
    }
}
