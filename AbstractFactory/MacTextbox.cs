﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    internal class MacTextbox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle mac text input");
        }

        public void Render()
        {
            Console.WriteLine("Render mac textbox");
        }
    }
}
