using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype
{
    public class Triangle : Shape
    {
        public override Shape Clone()
        {
            var temporaryJsonString = JsonSerializer.Serialize(this);
            Triangle? cloned = JsonSerializer.Deserialize<Triangle>(temporaryJsonString);

            return cloned;
        }

        public override void Render()
        {
            Console.WriteLine("Triangle Render()");
        }
    }
}
