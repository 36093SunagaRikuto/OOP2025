
namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {

            var wiki = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var line = wiki.Split(";");
            
            for(int i = 0;i < line.Length; i++) {
                var word = line[i].Split("=");
                var jp = ToJapanese(word[0]);
                Console.WriteLine($"{jp} : {word[1]}");
            }
            
          
        }

        private static object ToJapanese(string wiki) {
            return wiki switch {
                "Novelist" => "作家",
                "BestWork" => "代表作",
                "Born" => "誕生年",
                _=> "引数wikiは正しい値ではありません"
            };

            
        }
    }
}
