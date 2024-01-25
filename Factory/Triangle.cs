using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.Factory
{
    internal class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}
