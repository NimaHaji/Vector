using System;
namespace Vector
{
    public static class VectorOperation
    {
        static public Vector MinusVectors(Vector vector1, Vector vector2)
        {
            Vector vectorminus = new Vector();
            vectorminus._x = vector1._x - vector2._x;
            vectorminus._y = vector1._y - vector2._y;
            vectorminus._z = vector1._z - vector2._z;
            return vectorminus;
        }
        static public Vector AddVectors(Vector vector1, Vector vector2)
        {
            Vector AddVectors = new Vector();
            AddVectors._x = vector1._x + vector2._x;
            AddVectors._y = vector1._y + vector2._y;
            AddVectors._z = vector1._z + vector2._z;
            return AddVectors;
        }
        static public double InternalMultiplicationVectors(Vector vector1, Vector vector2,double _angle)
        {
            double angle;
            Console.Write("pleaase enter the angle : ");
            angle = (_angle * (Math.PI)) / 180;
            double vectorMultipilication = VectorSize(vector1) * VectorSize(vector2) * Math.Cos(angle);
            return vectorMultipilication;
        }
        static public Vector OuternalMultiplicationVectors(Vector vector1, Vector vector2)
        {
            Vector outmultplyvector = new Vector();
            outmultplyvector._x = (vector1._y * vector2._x) - (vector1._x * vector2._y);
            outmultplyvector._y = -((vector1._z * vector2._x) - (vector1._x * vector2._z));
            outmultplyvector._z = (vector1._z * vector2._y) - (vector1._y * vector2._z);
            return outmultplyvector;
        }
        static public double VectorSize(Vector vector1)
        {
            double vectorSize;
            vectorSize = Math.Sqrt(Math.Pow(vector1._x, 2) + Math.Pow(vector1._y, 2) + Math.Pow(vector1._z, 2));
            return vectorSize;
        }
    }
}
