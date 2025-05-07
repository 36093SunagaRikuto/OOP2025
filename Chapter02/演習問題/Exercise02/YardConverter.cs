using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class YardConverter {
         private const double ratio = 1.09361;
         public static double YtoM(double yard) {
            return yard / ratio;
        }

         public static double MtoY(double meter) {
            return meter * ratio;
        }
    }
}
