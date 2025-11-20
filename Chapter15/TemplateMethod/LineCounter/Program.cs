using TextFileProcessor;
using static System.Collections.Specialized.BitVector32;

namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("探索ファイルをください");
            string path = Console.ReadLine();

            Console.WriteLine("検索したい単語を入力してください");

            if (path.Contains('\\')) {
                var path1 = path.Trim('\\');
                if (path1.Contains('"')) {

                    path = path1.Trim('"');
                }
            }
        
            

            TextProcessor.Run<LineCounterProcessor>(path);

        
        }
    }
}
