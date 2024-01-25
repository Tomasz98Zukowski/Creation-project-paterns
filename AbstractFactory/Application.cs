using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    public class Application
    {
        private UIElementFactory _elementFactory;
        public Application(UIElementFactory elementFactory)
        {
            _elementFactory = elementFactory;
        }

        public void RenderUI()
        {
            var createNewFileButton = _elementFactory.CreateButton();
            createNewFileButton.Render();

            var createNewFileTextbox = _elementFactory.CreateTextBox();
            createNewFileTextbox.Render();
        }
    }
}
