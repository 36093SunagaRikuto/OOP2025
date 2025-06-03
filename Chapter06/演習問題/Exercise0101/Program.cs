using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var target = "C# Programming";
            
            var isExists = target.All(c => Char.IsLower(c));
            Console.WriteLine(isExists);
        }
    }
}
