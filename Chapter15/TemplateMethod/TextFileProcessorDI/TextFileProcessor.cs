using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    public class TextFileProcessor{
        private ITextFileService _service;

        //コンストラクタ
        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }


        public void Run(string fileName) {
            _service.Initialize(fileName);

            var lines = File.ReadLines(fileName);
            foreach(var line in lines) {
                var usi = Strings.StrConv(line, VbStrConv.Wide, 0);
                _service.Execute(usi);
                
            }

            _service.Terminate();
        }
    }
}
