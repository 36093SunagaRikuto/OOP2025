namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();

            //①本の平均金額を表示
            Console.WriteLine((int)books.Average(n => n.Price));

            //②本のページ合計を表示
            Console.WriteLine(books.Sum(n => n.Pages));

            //③金額の安い書籍と金額を表示

            var select = books.Where(x => x.Price == books.Min(b => b.Price)).First();
            Console.WriteLine($"{select.Title}: {select.Price}円");



            //④ページが多い書籍名とページ数を表示
            //var many = 
            books.Where(y => y.Pages == books.Max(z => z.Pages)).ToList().ForEach(n => Console.WriteLine($"{n.Title} : {n.Price}円"));
            //Console.WriteLine($"{many.Title} : {many.Pages}円");


            //⑤タイトルに「物語」が含まれている書籍名をすべて表示
            //var select = books.Where(n => n.Title.Contains("物語"));
            foreach(var choice in books)
                if(choice.Title.Contains("物語"))
                    Console.WriteLine(choice.Title);


        }
    }
}
