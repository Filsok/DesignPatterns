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