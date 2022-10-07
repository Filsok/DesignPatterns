using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
