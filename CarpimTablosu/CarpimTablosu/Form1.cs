using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[,] carpim = new int[11, 11];

            for (int i = 1; i <= 10; i++)

                for (int j = 1; j <= 10; j++)
                {
                    carpim[i, j] = i * j;
                }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 1)
                    {
                        listBox1.Items.Add("----------------");
                    }
                    listBox1.Text += carpim[i, j];
                    if (carpim[i, j] < 10)
                    {
                        listBox1.Items.Add(i + "X" + j + "=" + carpim[i, j]);
                    }
                    else
                        listBox1.Items.Add(i + "X" + j + "=" + carpim[i, j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
