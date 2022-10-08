using System.Text.Json;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            var temporaryJsonString = JsonSerializer.Serialize(this);
            Rectangle? cloned = JsonSerializer.Deserialize<Rectangle>(temporaryJsonString);

            return cloned;
        }

        public override void Render()
        {
            Console.WriteLine("Rectangle Render()");
        }
    }
}