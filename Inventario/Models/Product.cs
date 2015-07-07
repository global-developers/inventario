using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class Product
    {
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int id;
        private string name;
        private string description;
        private double price;
        private string barcode;
        private string color;
        private int count;
    }
}
