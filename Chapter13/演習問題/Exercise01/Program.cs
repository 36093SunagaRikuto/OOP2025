
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books
                .MaxBy(x => x.Price);
            Console.WriteLine("(2)");
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var book = Library.Books
                .GroupBy(x => x.PublishedYear);

            Console.WriteLine("(3)");

            foreach (var count in book) {
                Console.WriteLine($"{count.Key} : {count.Count()}");
            }

        }

        private static void Exercise1_4() {
            var book = Library.Books
                .OrderByDescending(x => x.PublishedYear)
                .ThenByDescending(x => x.Price);

            Console.WriteLine("(4)");


            foreach (var sele in book) {
                Console.WriteLine($"{sele.PublishedYear}年 {sele.Price}円 {sele.Title}");
            }
        }

        private static void Exercise1_5() {


            var book = Library.Books
                .Join(Library.Categories
                , book => book.CategoryId
                , category => category.Id,
                (book, category) => new {
                    category.Name,
                    book.PublishedYear
                })
                .Where(book => book.PublishedYear == 2022)
                .Distinct();

            Console.WriteLine("(5)");
            book.ToList().ForEach(x => Console.WriteLine(x.Name));


        }

        private static void Exercise1_6() {
            var book = Library.Books
                .Join(Library.Categories
                , book => book.CategoryId
                , category => category.Id,
                (book, category) => new {
                    category.Name,
                    book.Title
                })
                .GroupBy(category => category.Name)
                .OrderBy(Category => Category.Key);

            Console.WriteLine("(6)");
            foreach (var usi in book) {
                Console.WriteLine($"#{usi.Key}");
                foreach (var item in usi) {
                    Console.WriteLine($"   {item.Title}");
                }

            }
        }

        private static void Exercise1_7() {
            var book = Library.Books
                .Join(Library.Categories
                , book => book.CategoryId
                , Category => Category.Id,
                (book, Category) => new {
                    Category.Name,
                    book.PublishedYear,
                    book.Title
                })
                .Where(Category => Category.Name == "Development")
                .GroupBy(book => book.PublishedYear);

            Console.WriteLine("(7)");
            foreach (var usi in book) {
                Console.WriteLine($"#{usi.Key}");
                foreach (var item in usi) {
                    Console.WriteLine($"   {item.Title}");
                }
            }

        }

        private static void Exercise1_8() {
            var SEIKINTV = Library.Categories
                .GroupJoin(Library.Books
                , b => b.Id
                , c => c.CategoryId,
                (b,c) => new {
                    Category = b.Name,
                    Count = b.Name.Count(),
                    
                })
                .Where(x => x.Count >= 4);

            Console.WriteLine("(8)");
            foreach (var NISEKIN in SEIKINTV) {
                Console.WriteLine($"{NISEKIN.Category} { NISEKIN.Count}");
            }
        }
    }
}
