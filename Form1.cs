namespace MatrixAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[,] arr1 = new int[2, 2];
        private void Sbtn_Click(object sender, EventArgs e)
        {
            arr1[0, 0] = Convert.ToInt32(f100.Text);
            arr1[0, 1] = Convert.ToInt32(f101.Text);
            arr1[1, 0] = Convert.ToInt32(f110.Text);
            arr1[1, 1] = Convert.ToInt32(f111.Text);
            
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();


        }
    }
}