namespace Mediator
{
    public class Button : Component
    {
        public void Render()
        {
            Console.WriteLine("Render button");
        }

        public void Click()
        {
            Console.WriteLine("Button clicked");

            this._mediator.Notify(this, "click");
        }
    }
}