using TextFileProcessor;

namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("探索ファイルをください");
            Console.ReadLine();

            Console.WriteLine("検索したい単語を入力してください");

            string path = @"C:\Users\infosys\source\repos\OOP2025\Chapter05\Section01\Program.cs";
            

            TextProcessor.Run<LineCounterProcessor>(path);

            
        }
    }
}
