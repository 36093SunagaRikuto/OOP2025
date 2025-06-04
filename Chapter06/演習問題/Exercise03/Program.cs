
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);

        }

        private static void Exercise1(string text) {
            //Console.WriteLine(text.Count(char.IsWhiteSpace));
            Console.WriteLine(text.Count(x => x == ' '));
            
        }

        private static void Exercise2(string text) {
            Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3(string text) {

            StringBuilder sb = new StringBuilder();
            string[] unko = text.Split();
            foreach(var toto in unko) {
                sb.Append(toto + " ");
                

            }
           
            Console.WriteLine(sb + ";");

                  

        }

        private static void Exercise4(string text) {
            Console.WriteLine((text.Split()).Count());
        }

        private static void Exercise5(string text) {
            var select = text.Split();
            foreach(var unko in  select.Where(c => c.Length <= 4)) {
                Console.WriteLine(unko);
            }
        }

        private static void Exercise6(string text) {
            /*char tan = 'a';
            var te = text.ToLower().Split().ToList();
            for (int i = 0; i < 26; i++) {
                int count = 0;
                foreach (var cos in text) {
                    
                    if (cos.Equals(tan)) {
                        count++;
                    }
                    
                }
                Console.WriteLine($"{tan}:{count}");
                tan++;
           
                
            }*/

            var str = text.ToLower().Replace(" ","");

            var AlphDicCount = Enumerable.Range('a', 26).ToDictionary(num => ((char)num).ToString(), num => 0);
            
            foreach(var alph in str) {
                AlphDicCount[alph.ToString()]++;
            }
            foreach(var item in AlphDicCount) {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }

        
    }
}
