using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    internal class LIneOutputService : ITextFileService {
        private int _count;

        public void Initialize(string fname) {
            _count = 0;
        }

        public void Execute(string line) {
            if (_count < 20)
                Console.WriteLine(line);
            else if (_count == 20)
                Console.WriteLine($"{_count}行");
            _count++;

        }

        public void Terminate() {
            Console.WriteLine("終了した。");
        }
    }
}
