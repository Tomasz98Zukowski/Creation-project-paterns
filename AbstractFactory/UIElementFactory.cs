﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.AbstractFactory
{
    public interface UIElementFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
