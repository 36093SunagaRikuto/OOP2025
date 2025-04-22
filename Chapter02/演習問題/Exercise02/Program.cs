using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            //回数制限
            int count = 0;

            //範囲
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            while (count < 3) {
                if (start < end) {
                    Console.WriteLine($"始め{start} 終わり{end}");

                    //インチからメートルへ
                    InToMeter(start, end);

                    Console.WriteLine("\n");

                    //メートルからインチへ
                    MeterToIn(start, end);

                    count = 3;
                } else {
                    Console.WriteLine("エラーが出ました。");
                    count = count + 1;

                    int s = int.Parse(Console.ReadLine());
                    int e = int.Parse(Console.ReadLine());
                    start = s; end = e;
                    int a = 3;
                    Console.WriteLine($"残り{a}回");
                    a = a - 1;

                }
            }
        }

        private static void InToMeter(int start, int end) {
            for (int i = start; i <= end; i++) {
                double meter = i * 0.0254;
                Console.WriteLine($"{i}inch = {meter:0.0000}m");
            }
        }

        private static void MeterToIn(int start, int end) {
            for (int meter = start; meter <= end; meter++) {
                double i = meter / 0.0254;
                Console.WriteLine($"{meter}m = {i:0.0000}inch");
            }
        }
    }
}
