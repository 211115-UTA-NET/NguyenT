using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        public static void Main()
        {
            Shape shapeObject;

            shapeObject = new Rectangle();
            shapeObject.getArea();

            shapeObject = new Square();
            shapeObject.getArea();

            shapeObject = new Triangle();
            shapeObject.getArea();
        }
    }
}
