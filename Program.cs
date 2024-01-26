using Creation_project_paterns.AbstractFactory;
using Creation_project_paterns.Builder;
using Creation_project_paterns.Factory;
using Creation_project_paterns.Prototype;

namespace Creation_project_paterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var builder = new InvoiceBuilder();

            //var invoice = builder.SetDate(new DateTime(2020, 1, 1))
            //    .SetInvoiceNumber("A1")
            //    .SetVendor("Google")
            //    .SetVendee("Vendee")
            //    .SetLineItems(new List<string> { "Item 1", "Item 2" })
            //    .Build();

            //FACTORY

            //var shapeFactory = new ShapeFactory();

            //var circle1 = shapeFactory.CreateShape(ShapeType.Circle);
            //circle1.Render();

            // Abstract factory

            //var uiApplication = new Application(new WindowsFactory());

            //uiApplication.RenderUI();

            //PROTOTYPE

            Circle c1 = new Circle()
            {
                Radius = 12,
                X = 10,
                Y = 15,
                Border = new Border()
                {
                    Color = "Red",
                    Size = "2px"
                }
            };
            Circle c2 = (Circle)c1.Clone();

        }
    }
}
