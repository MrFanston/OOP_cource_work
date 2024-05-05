using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_work
{
    public class Accounting
    {
        public class Operation
        {
            DateTime data;
            float value;

            public Operation(DateTime data, float value)
            {
                this.data = data;
                this.value = value;
            }

            public DateTime get_data()
            {
                return data;
            }

            public float get_value()
            {
                return value;
            }
        }        
    }
}
