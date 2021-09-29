using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_С_Sharp
{
    class Product
    {
        public string name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Product: {name}, Price - {Price} ";
        }
    }

    class Shop
    {
        Product[] products;

        public  Shop(int n)
        {
            products = new Product[n];
        }
        public int Length
        {
            get { return products.Length; }
        }
        public  Product this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < products.Length)
                    return products[ind];
                throw new IndexOutOfRangeException();
            }
            set
            {
                products[ind] = value;
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].name == name)
                        return products[i].Price;
                }
                return 0;
            }
            set
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].name == name)
                        products[i].Price = value;
                }
            }
        }
    }

    class Matrix
    {
        int[,] arr;
        public int Row { get; private set; }
        public int Col { get; private set; }
        public  Matrix(int row, int col)
        {
            Row = row;
            Col = col;
            arr = new int[row, col];
        }

        public int this[int r, int c]
        {
            get { return arr[r, c]; }
            set { arr[r, c] = value; }
        }
    }


}

