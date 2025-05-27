using System;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1();
            Console.WriteLine("---");
            Exercise2();
            Console.WriteLine("---");
            Exercise3();

        }

        private static void Exercise1() {
            //int num = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)) {
                if (num < 0)
                    Console.WriteLine(num);

                else if (num < 100)
                    Console.WriteLine(num * 2);
                else if (num < 500)
                    Console.WriteLine(num * 3);
                else
                    Console.WriteLine(num);
            } else {
                Console.WriteLine("入力に誤りがあります。");
            }
        }

        private static void Exercise2() {
            var num = Console.ReadLine();
            if (int.TryParse(num, out var line)) {
                int nums = int.Parse(num);
                switch (nums) {
                    case < 0:
                        Console.WriteLine(nums);
                        break;
                    case < 100:
                        Console.WriteLine(nums * 2);
                        break;
                    case < 500:
                        Console.WriteLine(nums * 3);
                        break;
                    case >= 500:
                        Console.WriteLine(num);
                        break;
                    default:
                        Console.WriteLine("入力に誤りがあります。");
                        break;

                }
            } else {
                Console.WriteLine("入力に誤りがあります");
            }
        }

        private static void Exercise3() {
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)) {
                var text = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                    _ => num
                };
                Console.WriteLine(text);
            } else {
                Console.WriteLine("入力に誤りがあります");
            }
        }
    }
}
