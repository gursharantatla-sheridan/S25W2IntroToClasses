using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S25W2IntroToClasses
{
    public class Product
    {
        // fields
        int id;
        private string _name;
        private double _price;

        //private int _quantity;

        //public int Quantity
        //{
        //    get { return _quantity; }
        //    set { _quantity = value; }
        //}

        // auto-implemented property
        public int Quantity { get; set; }

        // constructors
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }

        public Product(int id, string name, double price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }

        // properties
        public int Id
        {
            get { return id; }
            set 
            { 
                if (value >= 0)
                    id = value;
            }

            //get => id;
            //set => id = value;
        }
    }
}
