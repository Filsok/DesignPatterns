namespace AbstractFactory
{
    public interface IUIElementFactory
    {
        IButton CreateButton();

        ITextBox CreateTextBox();
    }
}