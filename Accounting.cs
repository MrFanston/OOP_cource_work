﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_work
{
    public class Accounting
    {
        List<Operation> operations;
        List<float> y_values = new List<float>();

        public Accounting(List<Operation> operations)
        {
            this.operations = operations;
        }

        public List<float> get_y()
        {
            if (operations.Count > 0)
            {
                float start = 0;
                y_values.Add(start);

                int i = 0;
                foreach (Operation operation in operations)
                {
                    y_values.Add(y_values[i++] + operation.get_value());
                }
            }

            return y_values;
        }

        public float extrapolation()
        {
            List<float> increments = new List<float>();
            foreach (Operation value in operations)
            {
                increments.Add(value.get_value());
            }
            float mean = 0;

            if (increments.Count > 5)
            {
                // Убираем выбросы в виде максимального и минимального приращений
                increments.RemoveAt(increments.IndexOf(increments.Max()));
                increments.RemoveAt(increments.IndexOf(increments.Min()));
            }

            foreach (float value in increments)
            {
                mean += value;
            }

            return mean / (increments.Count + 2);
        }
    }
}
