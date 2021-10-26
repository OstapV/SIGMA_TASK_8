using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGMA_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker file = new FileWorker("C:\\Users\\lenovo\\source\\repos\\SIGMA_7_1\\SIGMA_7_1\\data.txt");

            List<Product> products = file.GetProducts();

            Product[] products1 = products.ToArray();

            Bubble.Sort(products1, Compare.CompareName);


            Console.WriteLine("\nSort by name:\n");
 
            for (int i = 0; i < products1.Length; i++)
            {
                Console.WriteLine(products1[i]);
            }

            Bubble.Sort(products1, Compare.ComparePrice);

            Console.WriteLine("\nSort by price:\n");

            for (int i = 0; i < products1.Length; i++)
            {
                Console.WriteLine(products1[i]);
            }

            Console.ReadLine();

        }
    }
}
