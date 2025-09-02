using System.Text.RegularExpressions;

namespace Section03 {
    internal class Program {
        static void Main(string[] args) {

            var text = "d紀伊石飯尾青ゴイあぁ";

            Match match = Regex.Match(text, @"\p{IsHiragana}+");
            if (match.Success) {
                Console.WriteLine($"{match.Index},{match.Value}");

            }

            var matches = Regex.Matches(text, @"\p{IsKatakana}");
            foreach(Match m in matches) {
                Console.WriteLine($"Index={m.Index}, Length={m.Length}, Value={m.Value},");

            }


            var text2 = "private List<string> results = new list<string>();";

            var matto = Regex
                .Matches(text2, @"\b[a-z]+\b")
                .Cast<Match>()
                .OrderBy(x => x.Length);

            foreach(Match m in matto) {
                Console.WriteLine($"Index={m.Index}, Length={m.Length}, Value={m.Value}");

            }
        }
    }
}
