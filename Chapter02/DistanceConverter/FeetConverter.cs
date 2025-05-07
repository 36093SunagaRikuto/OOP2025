using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public static class FeetConverter {
        //定数
        private const double ratio = 0.3048;

        //メートルからヤードを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //ヤードからメートルを求める
        public static double ToMeter(double yard) {
            return yard * ratio;
        }


    }
}
