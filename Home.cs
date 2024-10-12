using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orfoo

{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Appetizers form = new Appetizers();
            form.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Main_Course form = new Main_Course();
            form.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Beverages form = new Beverages();
            form.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Desserts form = new Desserts();
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Order form=new Order();
            form.Show();
        }
    }
}
