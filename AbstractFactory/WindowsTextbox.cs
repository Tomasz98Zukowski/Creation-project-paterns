﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    public class WindowsTextbox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle windows text input");
        }

        public void Render()
        {
            Console.WriteLine("Render windows textbox");
        }
    }
}
