﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_OOP_Bagian4
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("\nCanon printer printing....");
        }
    }
}