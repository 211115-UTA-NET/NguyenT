using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public Square() : base(Height)
        {
            this.Name = "square";
            this.NumSides = 4;
            this.Height = 6;
            this.Area = Height * Height;
        }
    }
}
