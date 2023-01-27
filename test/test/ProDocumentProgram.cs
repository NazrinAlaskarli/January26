using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class ProDocumentProgram:DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in doc format,for pdf format buy Expert packed");
        }
            
        
    }
}
