using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P8_CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");

            #region without ICloneable Interface


            //// Two references to same object!
            //Point p1 = new Point(50, 50);

            //Point p2 = p1;
            //p2.X = 0;

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            #endregion


            #region Using ICloneable Interface


            //// Notice Clone() returns a plain object type.
            //// You must perform an explicit cast to obtain the derived type.
            //Point p3 = new Point(100, 100);
            //Point p4 = (Point)p3.Clone();

            //// Change p4.X (which will not change p3.X).
            //p4.X = 0;

            //// Print each object.
            //Console.WriteLine(p3);
            //Console.WriteLine(p4);
            #endregion


            #region Object.MemberwiseClone() method

            //Point p1 = new Point(2, 2);

            //Point p2 = (Point)p1.Clone();

            //Console.WriteLine(" before change ");
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //Console.WriteLine(" after change ");
            //p1.X = 1;
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);



            #endregion

            Guid guid = Guid.NewGuid();

            Console.WriteLine(guid);
            Console.WriteLine(guid.ToByteArray().ToString());

            Console.ReadLine();
        }
    }
}
