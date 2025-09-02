using System.Text.RegularExpressions;

namespace Section04 {
    internal class Program {
        static void Main(string[] args) {

            /*
            var text = "Word, Excel ,PowerPoint, Outlook,OneDrive";
            var pattern = @"\s*,\s+";
            var replace = Regex.Split(text, ",");
            Console.WriteLine(replace);
            */

            var text1 = "foo.htm var.html baz.htm";
            var pattern1 = @".(htm)\b";
            var replace1 = Regex.Replace(text1, pattern1, ".html");
            Console.WriteLine(replace1);
        }
    }
}
