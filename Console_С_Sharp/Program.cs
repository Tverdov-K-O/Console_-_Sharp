using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_С_Sharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(new Point { x = 2, y = 3 }, new Point { x = 3, y = 8 });
            Vector v2 = new Vector(new Point { x = 1, y = 4 }, new Point { x = 6, y = 9 });
            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            //Vector v3 = v1 + v2;
            //Console.WriteLine(v3);
            //v1 += v2;
            //Console.WriteLine(v1);
            //v3 = v2 * 4;

            //Vector v3 = v1;

            //double d = v1;

            //Shop shop = new Shop(3);
            //shop[0] = new Product { name = "TV", Price = 5000 };
            //shop[1] = new Product { name = "Radio", Price = 500 };
            //shop[2] = new Product { name = "PlayStation", Price = 2000 };

            //try
            //{
            //    for (int i = 0; i < shop.Length; i++)
            //    {
            //        Console.WriteLine(shop[i]);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Matrix matrix = new Matrix(3, 4);
            //Random rnd = new Random();
            //for (int i = 0; i < matrix.Row; i++, Console.WriteLine())
            //{
            //    for (int j = 0; j < matrix.Col; j++)
            //    {
            //        matrix[i, j] = rnd.Next(10);
            //        Console.Write(matrix[i,j]+ " ");
            //    }
            //}

            Tank[] t1 = new Tank[]
            {
              new Tank("T -34"),
              new Tank("T -34"),
              new Tank("T -34"),
              new Tank("T -34"),
              new Tank("T -34")
            };
            Tank[] t2 = new Tank[]
            {
              new Tank("Panter"),
              new Tank("Panter"),
              new Tank("Panter"),
              new Tank("Panter"),
              new Tank("Panter")
            };
            for (int i = 0; i < 5; i++)
            {
                int c = t1[i] * t2[i];
                
                Console.WriteLine($"{t1[i]} * {t2[i]} = {c} ");
            }


            Console.Read();
        }
    }
}
