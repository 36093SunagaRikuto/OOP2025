using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("***変換アプリ***");
            Console.WriteLine("1:ヤードからメートル");
            Console.WriteLine("2:メートルからヤード");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine($">>>{choice}");
                   
            if (choice == 1) {

                        
                double yard = double.Parse(Console.ReadLine());
                double meter = YardConverter.MtoY(yard);
                        //ヤードからメートル
                       
                   
                Console.WriteLine($"変更前(ヤード):{yard}");
                Console.WriteLine($"変換後(メートル):{meter}");

                  
            } else {

                        
                double meter = double.Parse(Console.ReadLine());
                       
                double yard = YardConverter.MtoY(meter);
                       
                //メートルからヤード
                        
                Console.WriteLine($"変更前(メートル):{meter}");                      
                Console.WriteLine($"変換後(ヤード):{yard}");    
            }   
        
        }

        /*private static void YardToMeter(int start, int end) {
            for (int i = start; i <= end; i++) {
                double meter = i / 1.09361;
                Console.WriteLine($"{i}yard = {meter:0.00000}m");
            }
        }

        private static void MeterToYard(int start, int end) {
            for (int meter = start; meter <= end; meter++) {
                double i = meter * 1.09361;
                Console.WriteLine($"{meter}m = {i:0.00000}yard");
            }
        }*/

       
    }
}
