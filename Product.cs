﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_work
{
    public class Product
    {
        string name;
        string description;
        float price;
        List<Material> components = new List<Material>();

        public Product(string name, string description, List<Material> materials) 
        {
            this.name = name;
            this.description = description;
            this.components = materials;
            this.price = price_generator(this.components);
        }

        // Генератор себестоимости товара по материалам
        private float price_generator(List<Material> components)
        {
            foreach (Material component in components)
            {
                this.price += component.get_value_current() / component.get_value_max() * component.get_price();
            }
            return this.price;
        }

        public string get_name()
        {
            return name;
        }

        public string get_description()
        {
            return description;
        }

        public float get_price()
        {
            return price;
        }

        public List<Material> get_components()
        {
            return components;
        }
    }
}
