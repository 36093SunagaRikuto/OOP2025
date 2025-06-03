using System.Globalization;
using System.Runtime.InteropServices;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var str1 = "JSON";
            var str2 = "ＪＳＯＮ";

            var cultureinfo = new CultureInfo("ja-JP");
            if (String.Compare(str1, str2, cultureinfo, CompareOptions.IgnoreWidth) == 0)
                Console.WriteLine("一致しています");

        }
    }
}
