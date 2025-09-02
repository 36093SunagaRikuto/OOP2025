using System.Text.RegularExpressions;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {

            var lines = File.ReadAllLines("sample.txt");

            //string a = Regex.Split(lines," ");
            var newlines = lines.Select(s => Regex.Replace(s, @"\s[Vv]ersion=""(v4.0)""\s",@"version=""v5.0"""));

            File.WriteAllLines("sampleChange.txt", newlines);

            //これ以降は確認用
            var text = File.ReadAllText("sampleChange.txt");
            Console.WriteLine(text);
        }
    }
}
