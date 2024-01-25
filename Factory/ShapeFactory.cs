using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Circle();
                case ShapeType.Triangle:
                    return new Circle();
                default:
                    throw new Exception($"Shape {type} type doesn't exist.");

            }

        }
    }
}
