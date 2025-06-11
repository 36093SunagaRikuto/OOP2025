
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
            ddd.OrderBy(x => x.Key);
            foreach(var dic in ddd) {
                Console.WriteLine($"{ddd.Keys}: {ddd.Values}");
            }
            
            

        }

        private static void Exercise2(string text) {
            
        }
    }
}
