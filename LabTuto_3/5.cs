using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    internal class _5
    {
        class Product
        {
            int pcode;
            String pname, mname;
            public Product(int pcd, String pnm, String mnm)
            {
                pcode = pcd;
                pname = pnm;
                mname = mnm;
            }
            public void Display()
            {
                Console.WriteLine("Product Code:= " + pcode);
                Console.WriteLine("Product Name:= " + pname);
                Console.WriteLine("Manufacturer Name:= " + mname);
            }
        }
        public class TestProduct
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("VIRAJ - 21SOECE11011");
                int n = args.Length;
                if (n < 3)
                {
                    Console.WriteLine("Product Code:= P001\n");
                    Console.WriteLine("Product Name:= Mouse\n");
                    Console.WriteLine("Manufacturer Name:= Logitech \n");
                    Console.ReadLine();
                }
                else
                {
                    int pcd = Convert.ToInt32(args[0]);
                    String pnm = args[1];
                    String mnm = args[2];
                    Product p = new Product(pcd, pnm, mnm);
                    p.Display();
                    Console.ReadLine();
                }
            }
        }
    }
}
