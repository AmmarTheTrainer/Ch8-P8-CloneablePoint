using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P8_CloneablePoint
{
    // A class named Point.
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }
     
        // Override Object.ToString().
        public override string ToString() => $"[ X = {X} , Y = {Y} ]";

        public object Clone() => this.MemberwiseClone();

        //public object Clone()
        //{
        //    return new Point(this.X, this.Y);
        //}
    }
}
