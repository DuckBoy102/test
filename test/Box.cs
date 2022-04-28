using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Box
    {
        public string name;
        public int fat;
        public int cal;
        public bool IsHelthy()
        {
            return this.cal < 130 && this.fat < 5;
        }
        public int GetCal()
        {
            return this.cal;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
