﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Shop
{
    class Product
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must be not empty.");
                }
                name = value;
            }
        }

        // Баркод
        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Barcode must not be empty.");
                }
                barcode = value;
            }
        }

        // Цена
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be positive.");
                }
                price = value;
            }
        }

        // Конструктор
        public Product(string name, string barcode, double price)
        {
            this.Name = name;
            this.Barcode = barcode;
            this.Price = price;
        }
    }
}
