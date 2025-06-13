
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();

            Exercise2(text);
 
        }

        private static void Exercise1(string text) {

            var ddd = new Dictionary<char, int>();
            foreach (var item in text.ToUpper()) {
                if ('A' <= item && item <= 'Z')
                    if (ddd.ContainsKey(item))

                        ddd[item]++;
                    else
                        ddd.Add(item, 1);

            
            }
            
            foreach(var dic in ddd.OrderBy(x => x.Key)) {
                Console.WriteLine($"{dic.Key}:{dic.Value}");
            }
            
            

        }

        private static void Exercise2(string text) {

            var sd = new SortedDictionary<char, int>();   
            foreach(var nal in text.ToUpper()) {
                if ('A' <= nal && nal <= 'Z')
                    if (sd.ContainsKey(nal))
                        sd[nal]++;
                    else
                        sd.Add(nal, 1);
            }
            foreach (var dic in sd) {
                Console.WriteLine($"{dic.Key}:{dic.Value}");
            }
        }
    }
}
