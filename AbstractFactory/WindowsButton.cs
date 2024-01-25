﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle windows click event");
        }

        public void Render()
        {
            Console.WriteLine("Render windows");
        }
    }
}
