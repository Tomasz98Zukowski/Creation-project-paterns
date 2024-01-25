using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    internal class WindowsFactory : UIElementFactory
    {
        public IButton CreateButton()
        {
            var button = new WindowsButton();
            return button;
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextbox();
        }
    }
}
