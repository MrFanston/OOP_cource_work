using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_work
{
    public class Materials
    {
        // Родительский класс для всех материалов
        public abstract class Material
        {
            string name;
            float price;
            float value_max;
            float value_current;

            public Material(string name, float price, float value_max ,float value_current)
            {
                this.name = name;
                this.price = price;
                this.value_max = value_max;
                this.value_current = value_current;
            }

            public string get_name() 
            { 
                return name; 
            }

            public float get_price()
            {
                return price;
            }

            public float get_value_max()
            {
                return value_max;
            }

            public float get_value_current()
            {
                return value_current;
            }
        }

        // Класс необрабатываемых материалов
        public class Unprocessed: Material
        {

            public Unprocessed(string name, float price) : 
                base(name, price, 1, 1) 
            { }
        }

        // Класс материалов, обрабатываемых лазером
        public class Laser: Material
        {
            float thickness;

            public Laser(string name, float price, float thickness, float square_max, float square_current) : 
                base(name, price, square_max, square_current)
            {
                this.thickness = thickness;
            }

            public float get_thickness()
            {
                return thickness;
            }

        }

        public class PrinterFDM: Material
        {
            bool heat_resistant;

            public PrinterFDM(string name, float price, bool heat_resistant, float weight_max, float weight_current) :
                base(name, price, weight_max, weight_current)
            {
                this.heat_resistant = heat_resistant;
            }

            public bool get_heat_resistant()
            {
                return heat_resistant;
            }
        }

        // Класс материалов обрабатываемых FDM принтером
        public class PrinterSLA : Material
        {
            bool water_washer;

            public PrinterSLA(string name, float price, bool water_washer, float volume_max, float volume_current) :
                base(name, price, volume_max, volume_current)
            {
                this.water_washer = water_washer;
            }

            public bool get_water_washer()
            {
                return water_washer;
            }
        }
    }
}
