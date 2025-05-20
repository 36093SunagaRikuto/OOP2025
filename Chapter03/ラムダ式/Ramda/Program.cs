using System.Runtime.InteropServices;

namespace Ramda {
    internal class Program {
        static void Main(string[] args) {

            var numbers = new[] { 5, 3, 9, 8, 7, 5, 8, 1, 0, 5, 10, 4 };
            Predicate<int> judge =
                (int n) => {
                    if (n % 2 == 0)
                        return true;
                    else
                        return false;

                };

            var count = Count(numbers, judge);
            Console.WriteLine(count);
        }

        static int Count(int[] numbers, Predicate<int> judge) {
            var count = 0;
            foreach(var n in numbers) {
                if(judge(n) == true) {
                    count++;
                }
            }
            return count;
        }
    }
}
