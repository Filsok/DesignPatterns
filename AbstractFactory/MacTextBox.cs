namespace AbstractFactory
{
    public class MacTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine($"Handle Mac TextBox input");
        }

        public void Render()
        {
            Console.WriteLine($"Render Mac TextBox");
        }
    }
}