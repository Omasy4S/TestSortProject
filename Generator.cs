using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingViz
{

    class Generator
    {
        Field field = new Field();

        public List<int> generateValues(int range)
        {
            List<int> output = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                output.Add(i);
            }
            output = shuffleValues(input: output);
            return output;
        }

        private static List<int> shuffleValues(List<int> input)
        {
            Random rng = new Random();
            List<int> output = new List<int>();
            int itterations = input.Count();
            for (int i = 0; i < itterations; i++)
            {
                int idx = rng.Next(minValue: 0, maxValue: input.Count());
                output.Add(input[idx]);
                input.RemoveAt(index: idx);
            }
            return output;
        }

        public List<DataBar> generateBars(List<int> input)
        {
            float amount = (float) input.Count();
            float bar_width = field.width / amount;
            float starting_y = field.y;
            List<DataBar> output = new List<DataBar>();
            for (int i = 0; i < amount; i++)
            {
                DataBar new_bar = new DataBar();
                new_bar.x = (field.x + field.width) - bar_width * (i + 1);
                new_bar.y = starting_y;
                new_bar.height = (input[i] / amount) * field.height;
                new_bar.width = bar_width;
                output.Add(new_bar);
            }
            return output;
        }
    }
}
