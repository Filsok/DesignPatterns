using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine($"CreateButton Mac");
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            Console.WriteLine($"CreateTextBox Mac");
            return new MacTextBox();
        }
    }
}
