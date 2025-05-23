
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
    "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
    "JavaScript", "Swift", "Go", "script"
];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);




        }

        private static void Exercise1(List<string> langs) {
            //foreach文

            //var num = langs.Where(n => (n.Contains('S')) || (n.Contains('s')));

            /*foreach(var lang in langs) {
                if (lang.Contains('S') || lang.Contains('s')) {
                    Console.WriteLine(lang);
                }  
            }

            //for文
            for(int i = 0;i < langs.Count; i++) {
                if (langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
            }*/

            //while文
            int count = 0;
            while(count < langs.Count) {
                if (langs[count].Contains('S')) {
                    Console.WriteLine(langs[count]);
                }
                count++;
            }

        }

        private static void Exercise2(List<string> langs) {
            var select = langs.Where(n => n.Contains('S')).ToList();
            select.ForEach(n => Console.WriteLine(n));
        }

        private static void Exercise3(List<string> langs) {
            var lang = langs.Find(n => n.Length >= 10) ?? "unknown";
            Console.WriteLine(lang);

        }
    }
}
