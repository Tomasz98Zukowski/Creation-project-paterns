using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    internal class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle mac button input");
        }

        public void Render()
        {
            Console.WriteLine("Render mac button");
        }
    }
}
