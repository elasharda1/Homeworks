﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Disperser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("Proba", "Test", "678");
            foreach (var symbol in stringDisperser)
            {
                Console.Write(symbol+" ");
            }
        }
    }
}
