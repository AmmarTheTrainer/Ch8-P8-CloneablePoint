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
        public PointDescription pointdesc = new PointDescription();

        #region Constructors


        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            pointdesc.PetName = petName;
        }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        #endregion


        //// Override Object.ToString().
        //public override string ToString() => $"[ X = {X} , Y = {Y} ]";

        // Override Object.ToString().
        public override string ToString() => $"[ X = {X} ,  Y = {Y} ]  Name = {pointdesc.PetName};\nID = {pointdesc.PointID}\n";

        //public object Clone() => this.MemberwiseClone();

        public object Clone()
        {
            // First get a shallow copy.
            Point newPoint = (Point)this.MemberwiseClone();
            // Then fill in the gaps.
            PointDescription currentDesc = new PointDescription();

            currentDesc.PetName = this.pointdesc.PetName; // this is referecne type
            newPoint.pointdesc = currentDesc;
            return newPoint;
        }
    }
}
