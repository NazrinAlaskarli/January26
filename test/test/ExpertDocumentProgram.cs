﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class ExpertDocumentProgram:ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in pdf format");
        }
        
        
    }
}
