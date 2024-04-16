using SortingViz;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form1 : Form
    {
        Field field = new Field();
        List<int> data = new List<int>();
        List<DataBar> databars = new List<DataBar>();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Field field = new Field();
            Graphics g = e.Graphics;
            Brush myBlackBrush = new SolidBrush(color: Color.White);
            g.FillRectangle(brush: myBlackBrush, x: field.x, y: field.y, width: field.width, height: field.height);
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            int simulation_quantity = Convert.ToInt16(UpDown_Quantity.Value);

            Generator generator = new Generator();
            data.Clear();
            databars.Clear();

            data = generator.generateValues(range: simulation_quantity);
            databars = generator.generateBars(input: data);

            Graphics g = CreateGraphics();
            Brush myWhiteBrush = new SolidBrush(color: Color.Black);
            Brush myBlackBrush = new SolidBrush(color: Color.White);
            g.FillRectangle(brush: myBlackBrush, x: field.x, y: field.y, width: field.width, height: field.height);
            foreach (DataBar databar in databars)
            {               
                g.FillRectangle(brush: myWhiteBrush, x: databar.x, y: databar.y, width: databar.width - 1, height: databar.height);
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            String sorter = Box_Sorters.Text;
            Generator generator = new Generator();
            Graphics g = CreateGraphics();
            Brush myWhiteBrush = new SolidBrush(color: Color.Black);
            Brush myBlackBrush = new SolidBrush(color: Color.White);
            List<DataBar> originalDataBars = databars;

            if (data.Count == 0 || databars.Count == 0)
            {
                return;
            }

            switch (sorter)
            {
                case "Сортировка выборкой":
                    for (int i = 0; i < data.Count - 1; i++)
                    {
                        int temp;
                        int smallest = i;
                        for (int j = i + 1; j < data.Count; j++)
                        {
                            if (data[j] < data[smallest])
                            {
                                smallest = j;
                            }
                        }
                        temp = data[smallest];
                        data[smallest] = data[i];
                        data[i] = temp;
                        databars = generator.generateBars(input: data);
                        UpdateDrawing(newDataBars: databars, originalDataBars: originalDataBars);
                        originalDataBars = databars;
                        Task.Delay(millisecondsDelay: 100).Wait();
                    }
                    break;

                case "Сортировка вставкой":
                    for (int i = 1; i < data.Count; i++)
                    {
                        var key = data[i];
                        int j = i - 1;
                        while (j >= 0 && data[j] > key)
                        {
                            data[j + 1] = data[j];
                            j -= 1;
                            databars = generator.generateBars(input: data);
                            UpdateDrawing(newDataBars: databars, originalDataBars: originalDataBars);
                            originalDataBars = databars;
                            Task.Delay(millisecondsDelay: 1).Wait();
                        }
                        data[j + 1] = key;
                        databars = generator.generateBars(input: data);
                        UpdateDrawing(newDataBars: databars, originalDataBars: originalDataBars);
                        originalDataBars = databars;
                    }
                    break;

                default:
                    break;
            }
        }
  
        public void UpdateDrawing(List<DataBar> newDataBars, List<DataBar> originalDataBars)
        {
            Field field = new Field();
            Graphics g = CreateGraphics();
            Brush myWhiteBrush = new SolidBrush(color: Color.Black);
            Brush myBlackBrush = new SolidBrush(color: Color.White);
            for (int idx = 0; idx < databars.Count(); idx++)
            {
                if (newDataBars[idx].height != originalDataBars[idx].height)
                {
                    g.FillRectangle(brush: myBlackBrush, x: newDataBars[idx].x, y: field.y, width: newDataBars[idx].width, height: field.height);
                    g.FillRectangle(brush: myWhiteBrush, x: newDataBars[idx].x, y: newDataBars[idx].y, width: newDataBars[idx].width - 1, height: newDataBars[idx].height);
                }
            }
        }
    }
}
