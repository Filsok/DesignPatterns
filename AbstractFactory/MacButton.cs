namespace AbstractFactory
{
    public class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine($"Handle Mac click event");
        }

        public void Render()
        {
            Console.WriteLine($"Render Mac button");
        }
    }
}