﻿using System;

namespace Enum2
{
    enum DialogResult {YES, NO, CANCEL, CONFIRM, OK}
    
    class MainApp
    {
        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
