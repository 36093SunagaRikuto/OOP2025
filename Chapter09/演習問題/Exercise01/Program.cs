using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var datetime = DateTime.Now;
            DisplayDatePattern1(datetime);
            DisplayDatePattern2(datetime);
            DisplayDatePattern3(datetime);
        }

        private static void DisplayDatePattern1(DateTime datetime) {

            // 2024/03/09 19:03
            //string.Formatを使用

            
            Console.WriteLine(string.Format(datetime.ToString()));
        }

        private static void DisplayDatePattern2(DateTime datetime) {

            // 2024年03月09日 19時03分09秒
            //DateTime.ToStringを使用

            
            Console.WriteLine(datetime.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime datetime) {

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var cal = datetime.ToString("gg y年 M月 d日(dddd)", culture);
            Console.WriteLine(cal);
        }
    }
}
