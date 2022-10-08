using System.Text.Json;

namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            //var cloneBase = (Circle)this.MemberwiseClone();          //Shallow clone
            //cloneBase.Border = new Border
            //{
            //    Size = Border.Size,
            //    Color = Border.Color
            //};                                                      //Deep copy
            var temporaryJsonString = JsonSerializer.Serialize(this);
            Circle? cloned = JsonSerializer.Deserialize<Circle>(temporaryJsonString);

            return cloned;
        }

        public override void Render()
        {
            Console.WriteLine("Circle Render()");
        }
    }
}