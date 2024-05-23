using System;
namespace Vector
{
    public class Vector
    {        
        public int _x, _y, _z;
        static public void GetVectorPoints(Vector vector,string inputs)
        {
            char[] delimiterChars = {' ', ',', '(', ')' };
            string[] Vriables = inputs.Split(delimiterChars);
            vector._x = int.Parse(Vriables[1]);
            vector._y = int.Parse(Vriables[2]);
            vector._z = int.Parse(Vriables[3]);       
        }
        static public void PrintVector(Vector vector)
        {
            Console.WriteLine($"({vector._x},{vector._y},{vector._z})");
        }
    }
}
