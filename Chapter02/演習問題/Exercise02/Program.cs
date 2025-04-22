using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            //回数制限
            int count = 0;
            int nokori  = 3;

            Console.WriteLine("***変換アプリ***");
            Console.WriteLine("1:インチからメートル");
            Console.WriteLine("2:メートルからインチ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine($">>>{choice}");

            //範囲
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            while (count < 3) {
                if (start < end) {
                    Console.WriteLine($"始め{start} 終わり{end}");
                    if (choice == 1) {
                        //インチからメートルへ
                        InToMeter(start, end);

                    } else {

                        //メートルからインチへ
                        MeterToIn(start, end);
                    }

                    count = 3;
                } else {
                    Console.WriteLine("エラーが出ました。");
                    count = count + 1;
                    Console.WriteLine($"残り{nokori}回");
                    nokori -= 1;

                    int s = int.Parse(Console.ReadLine());
                    int e = int.Parse(Console.ReadLine());
                    start = s; end = e;
                    

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
