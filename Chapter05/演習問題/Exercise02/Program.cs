using Exercise01;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            // 5.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2025, 7),
                new YearMonth(2010, 9),
                new YearMonth(2024, 12),
            };

            Console.WriteLine("5.2.2");
            Exercise2(ymCollection);

            Console.WriteLine("5.2.4");
            Exercise4(ymCollection);


            Console.WriteLine("5.2.5");
            Exercise5(ymCollection);
        }

        private static void Exercise2(YearMonth[] ymCollection) {

            ymCollection.ToList().ForEach(x => Console.WriteLine(x));

        }

        private static void Exercise4(YearMonth[] ymCollection) {

            /*if(FirstFind21(ymCollection) is null) {
                Console.WriteLine("21世紀のデータはありません");
            } else {
                Console.WriteLine(FirstFind21(ymCollection));
            }*/

            Console.WriteLine(FirstFind21(ymCollection).ToString() ?? "21世紀のデータはありません");

        }

        private static void Exercise5(YearMonth[] ymCollection) {

            var next = ymCollection.Select(x => x.AddOneMonth()).OrderBy(n => n.Month).OrderBy(n => n.Year);
            //var sort = next.OrderBy(n =>n.Month).OrderBy(n => n.Year);

            ;
            foreach(var chi in next) {
                
                Console.WriteLine(chi);
            }
        }

        
        //5.2.3
        private static YearMonth? FirstFind21(YearMonth[] ymCollection) {
            foreach(var first in ymCollection) {
                if (first.Is21Century) {
                    return first;
                }   
            }
            return null;
        }
    }
}
