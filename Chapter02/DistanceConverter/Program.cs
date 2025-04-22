using System.Diagnostics.Metrics;
using System.Numerics;

namespace DistanceConverter {
    internal class Program {
        //コマンドライン引数で指定された範囲のフィートとメートルの対応表を出力する
        static void Main(string[] args) {

            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);

            if (args.Length > 0 && args[0] == "-tom") {

                //フィートからメートルへの対応表を出力
                PirntFeetToMeterList(start, end);


            } else {

                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(start, end);


            }
            Console.WriteLine("\b  ");
            Nakami(args);
            Console.WriteLine("\n");
        }

        private static void PrintMeterToFeetList(int start, int end) {
            for (int meter = start; meter <= end; meter++) {
                double m1 = FeetToMeter(meter);
                Console.WriteLine($"{meter}m = {m1:0.0000}ft");
            }
        }

        private static void PirntFeetToMeterList(int start, int end) {
            for (int meter = start; meter <= end; meter++) {
                double m1 = FeetToMeter(meter);
                Console.WriteLine($"{meter}ft = {m1:0.0000}m");

            }
        }

        private static void Nakami(string[] args) {
            for (int i = 0; i < args.Length; i++) {
                Console.Write($"{args[i]}   ");
            }       
        }


        static double FeetToMeter(int feet) {
            return feet * 0.3048; ;
        }

        static double MeterToFeet(int meter) {
            return meter / 0.3048;
        }


    }
}
