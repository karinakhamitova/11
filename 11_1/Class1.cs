using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    struct Linear
    {
        double k;
        double b;
        public Linear (double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (b == 0)
            {
                return "Х равен 0";
            }
            double r = -b/ k;
            return $"X равен {r:.000}";
        }
    }
   
}
