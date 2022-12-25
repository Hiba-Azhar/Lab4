using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixAdv
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int r1, r2, r3, r4;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            r1 = ((Form1.arr1[0, 0] * Form2.arr2[0, 0])+(Form1.arr1[0, 1] * Form2.arr2[1, 0]));
            r2 = ((Form1.arr1[0, 0] * Form2.arr2[0, 1]) + (Form1.arr1[0, 1] * Form2.arr2[1, 1]));
            r3 = ((Form1.arr1[1, 0] * Form2.arr2[0, 0]) + (Form1.arr1[1, 1] * Form2.arr2[1, 0]));
            r4 = ((Form1.arr1[1, 0] * Form2.arr2[0, 1]) + (Form1.arr1[1, 1] * Form2.arr2[1, 1]));
            label1.Text = Convert.ToString(r1);
            label2.Text = Convert.ToString(r2);
            label3.Text = Convert.ToString(r3);
            label4.Text = Convert.ToString(r4);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
