
using System.Text.RegularExpressions;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            string filePath = "sample.txt";
            Picup3DigitNumber(filePath);
        }

        private static void Picup3DigitNumber(string filePath) {
            
            foreach(var line in File.ReadLines(filePath)) {
                //var matches = Regex.Matches(line,@"\b(\d{3,}\b)");
                var matches = Regex.Matches(line,@"\b([a-zA-Z]{3,}\b)");
                foreach(Match m in matches) {
                    Console.WriteLine(m.Value);
                    //Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaa");
                }
            }
        }
    }
}
