using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Square Class here.
        double Width;
        double Height;

        public Rectangle()
        {
            this.Name = "rectangele";
            this.NumSides = 4;
            this.Width = 6;
            this.Height = 5;
            this.Area = Width * Height;
        }

        public override void SetArea()
        {
            
        }
    }
}
