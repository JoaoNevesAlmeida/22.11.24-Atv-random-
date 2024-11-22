using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11._24_Atv_random_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            int[] numeros = new int[10];
            for (int i = 0;i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0, 100);
            }
            Array.Sort(numeros);
            foreach (int numero in numeros)
            {
                listBox1.Items.Add(numero);
            }
        }
    }
}
