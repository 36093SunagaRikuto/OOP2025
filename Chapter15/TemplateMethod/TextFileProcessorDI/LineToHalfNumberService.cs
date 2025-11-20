using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    public class LineToHalfNumberService : ITextFileService {
        private static Dictionary<char, char> _dictionary =
            new Dictionary<char, char>() {
                {'０', '0'},{'１', '1'},{'２', '2'},{'３', '3'},{'４', '4'},
                {'５', '5'},{'６', '6'},{'７', '7'},{'８', '8'},{'９', '9'},
            };

        public void Initialize(string fname) {

        }

        public void Execute(string line) {
            string hankaku = Strings.StrConv(line, VbStrConv.Narrow, 0);
            Console.WriteLine(hankaku);

            var s = Regex.Replace(line, "[０-９]", m => _dictionary[m.Value[0]].ToString());
        }

        public void Terminate() {
            Console.WriteLine("終了した。");
        }
    }
}
