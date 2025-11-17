using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public static class ConverterFactory {
        //あらかじめインスタンスを生成し、配列に入れておく
        private readonly static ConverterBase[] _converters = {
            new MeterConverter(),
            new FeetConveter(),
            new InchiConverter(),
            new YardConverter(),
            new MileConverter(),
            new KmConverter()
        };

        public static ConverterBase? GetInstance(string name) =>
            _converters.FirstOrDefault(x => x.IsMyUnit(name));

        
    }
}
