namespace AbstractFactory
{
    public class WindowsTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine($"Handle Windows TextBox input");
        }

        public void Render()
        {
            Console.WriteLine($"Render Windows TextBox");
        }
    }
}