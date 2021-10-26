using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SIGMA_7_1
{
    class FileWorker
    {
        public string Text { get; set; }

        public FileWorker(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            Text = reader.ReadToEnd();
        }

        public List<Product> GetProducts()
        {
            string[] products = Text.Replace("\r\n", "\n").Split('\n');

            List<Product> list = new List<Product>();

            for (int i = 0; i < products.Length; i++)
            {
                Product product = new Product();

                try
                {
                    product.Parse(products[i]);
                }
                catch (ArgumentException)
                {
                    throw;
                }

                list.Add(product);
            }

            return list;
        }
    }
}
