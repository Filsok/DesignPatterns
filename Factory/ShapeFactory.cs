namespace Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();

                case ShapeType.Rectangle:
                    return new Rectangle();

                case ShapeType.Triangle:
                    return new Triangle();

                default:
                    throw new Exception($"ShapeType {type} is not handled.");
            }
        }
    }
}