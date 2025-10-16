using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter
{
    internal class MetricUnit : DistanceUnit
    {
        private static List<MetricUnit> units = new List<MetricUnit>() {
            new MetricUnit{Name = "mm",Coefficient = 1, },
            new MetricUnit{Name = "cm",Coefficient = 10,},
            new MetricUnit{Name = "m",Coefficient = 10 * 100,},
            new MetricUnit{Name = "km",Coefficient = 10 * 100 * 1000},

        };

        public static ICollection<MetricUnit> Units { get => units; }

        /// <summary>
        /// <メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit"></param>変換元の単位
        /// <param name="value"></param>変換する値
        /// <returns></returns>変換した値

        public double FromImperialUnit(ImperialUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / Coefficient;
        }
    }
}
