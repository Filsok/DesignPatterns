namespace AbstractFactory
{
    public class WindowsFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine($"CreateButton Windows");
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            Console.WriteLine($"CreateTextBox Windows");
            return new WindowsTextBox();
        }
    }
}