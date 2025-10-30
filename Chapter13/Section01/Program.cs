namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            //var price = Library.Books
            //    .Where(b => b.CategoryId == 1)
            //    .Max(b => b.Price);
            //Console.WriteLine(price);

            //Console.WriteLine();

            //var book = Library.Books
            //    .Where(b => b.PublishedYear >= 2021)
            //    .MinBy(b => b.Price);
            //Console.WriteLine(book);

            //Console.WriteLine();

            //var average = Library.Books.Average(x => x.Price);

            //var selected = Library.Books
            //    .GroupBy(b => b.PublishedYear)
            //    .Select(group => group.MaxBy(b => b.Price))
            //    .OrderBy(b => b.PublishedYear);

            //selected.ToList().ForEach(b => Console.WriteLine(b));

            //var book = Library.Books
            //    .Join(Library.Categories
            //        , book => book.CategoryId
            //        , Category => Category.Id,
            //        (book, category) => new {
            //            book.Title,
            //            Category = category.Name,
            //            book.PublishedYear
            //        })
            //    .OrderBy(b => b.PublishedYear)
            //    .ThenBy(b => b.Category);


            //book.ToList().ForEach(x => Console.WriteLine(x));

            var groups = Library.Categories
                .GroupJoin(Library.Books
                , c => c.Id
                , b => b.CategoryId,
                (c, books) => new {
                    CategoryName = c.Name,
                    Books = books
                });

            foreach(var group in groups) {
                Console.WriteLine(group.CategoryName);
                foreach(var book in group.Books) {
                    Console.WriteLine(book);
                }
            }
        }
    
    }
}
