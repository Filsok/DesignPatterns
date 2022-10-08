namespace AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine($"Handle Windows click event");
        }

        public void Render()
        {
            Console.WriteLine($"Render Windows button");
        }
    }
}