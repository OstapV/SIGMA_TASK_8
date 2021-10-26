using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGMA_7_1
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int ExpirationDate { get; set; }

        public Product() { }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Product product = (Product)obj;

            return (this.Name == product.Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}\nExpiration date: {ExpirationDate}";
        }

        virtual public void Parse(string info)
        {
            string[] parts = info.Split(' ');

            Name = parts[0];

            double price;

            if (!double.TryParse(parts[1], out price))
            {
                throw new ArgumentException("Wrong name");
            }
            Price = price; 
            

            double weight;

            if (!double.TryParse(parts[2], out weight))
            {
                throw new ArgumentException("Wrong input(weight)");
            }
            Weight = weight; 

            int expirationDate;

            if (!int.TryParse(parts[3], out expirationDate))
            {
                throw new ArgumentException("Wrong input(expiration date)");
            }
            ExpirationDate = expirationDate;

        }
    }
}
