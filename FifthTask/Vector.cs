using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FifthTask
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Length { get; set; }

        public Vector() { }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double FindLength()
        {
            return Sqrt(Pow(this.X, 2) + Pow(this.Y, 2) + Pow(this.Z, 2));
        }

        public static Vector operator +(Vector first, Vector second)
        {
            Vector resultVector = new Vector();
            resultVector.X = first.X + second.X;
            resultVector.Y = first.Y + second.Y;
            resultVector.Z = first.Z + second.Z;
            return resultVector;
        }

        public static Vector operator -(Vector first, Vector second)
        {
            Vector resultVector = new Vector();
            resultVector.X = first.X - second.X;
            resultVector.Y = first.Y - second.Y;
            resultVector.Z = first.Z - second.Z;
            return resultVector;
        }

        public static Vector operator *(Vector vector, double number)
        {
            Vector resultVector = new Vector();
            resultVector.X = vector.X * number;
            resultVector.Y = vector.Y * number;
            resultVector.Z = vector.Z * number;
            return resultVector;
        }

        public static double operator *(Vector first, Vector second)
        {
            return  first.X * second.X + first.Y * second.Y + first.Z * second.Z;
        }

        public static bool operator ==(Vector first, Vector second)
        {
            if(first.X != 0 && first.Y!=0 && first.Z!=0 &&
                second.X != 0 && second.Y != 0 && second.Z != 0)
            {
                if(first.X/second.X == first.Y/second.Y && first.Y / second.Y == first.Z / second.Z)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Vector first, Vector second)
        {
            if (first.X == 0 || first.Y == 0 || first.Z == 0 ||
                second.X == 0 || second.Y == 0 || second.Z == 0)
            {

                return true;
            }
            return false;

        }

        public override string ToString()
        {
            return String.Format("Verctor x = {0}, y = {1}, z = {2}", X, Y, Z);
        }
    }
}
