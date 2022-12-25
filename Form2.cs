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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int[,] arr2 = new int[2, 3];
        private void Sbtn_Click(object sender, EventArgs e)
        {
            arr2[0, 0] = Convert.ToInt32(f200.Text);
            arr2[0, 1] = Convert.ToInt32(f201.Text);
            arr2[1, 0] = Convert.ToInt32(f210.Text);
            arr2[1, 1] = Convert.ToInt32(f211.Text);
            Form3 form3 = new Form3();
                form3.Show();
            this.Hide();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
