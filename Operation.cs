using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_work
{
    public class Operation
    {
        DateTime data;
        float value;
        string description;

        public Operation(DateTime data, float value, string description)
        {
            this.data = data;
            this.value = value;
            this.description = description;
        }

        public DateTime get_data()
        {
            return data;
        }

        public float get_value()
        {
            return value;
        }

        public string get_description()
        {
            return description;
        }
    }
}
