using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Inheritance1.Entities
{
    class Product
    {
        public string Name {  get; protected set; }
        public double Price {  get; protected set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture); 
        }

    }
}
