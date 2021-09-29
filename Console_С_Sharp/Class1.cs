using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//enum powerFire
//{
//    low, medium , strong
//}
namespace Console_С_Sharp
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public static Point operator++ (Point p)
        {
            p.x++;
            p.y++;
            return p;
        }
        public static Point operator-- (Point p)
        {
            p.x--;
            p.y--;
            return p;
        }
        public static Point operator- (Point p)
        {
            return new Point { x = -p.x, y = -p.y };
        }

        public override string ToString()
        {
            return $"X = {x}, Y = {y}";
        }
    }

     class Vector
    {
        public  int x { get; set; }
        public  int y { get; set; }

        public Vector() { }
        public Vector(Point p1, Point p2)
        {
            x = p2.x - p1.x;
            y = p2.y - p1.y;
        }
        public Vector(params int[]a)
        {
            x = a[3] - a[1];
            y = a[2] - a[0];
        }

        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector { x = v1.x + v2.x, y = v1.y + v2.y };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { x = v1.x - v2.x, y = v1.y - v2.y };
        }
        public static Vector operator *(Vector v1, int n)
        {
            return new Vector { x = v1.x * n, y = v1.y * n};
        }
        public static Vector operator *( int n, Vector v1)
        {
            return new Vector { x = v1.x * n, y = v1.y * n };
        }
        public static bool operator==(Vector v1, Vector v2)
        {
            return v1.x == v2.x && v1.y == v2.y;
        }
        public static bool operator true(Vector v1)
        {
            return v1.x != 0 || v1.y != 0;
        }
        public static bool operator false(Vector v1)
        {
            return v1.x == 0 && v1.y == 0;
        }
        public static bool operator !(Vector v1)
        {
            return v1 ? false : true;
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return v1.x != v2.x || v1.y != v2.y;
        }

        public static implicit operator double (Vector v)
        {
            return Math.Sqrt(v.x * v.x + v.y * v.y);
        }




        public override string ToString()
        {
            return $"Vector: x = {x}, y = {y}";
        }


        
    }
}
