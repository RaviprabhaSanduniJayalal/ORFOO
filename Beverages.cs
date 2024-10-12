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
    public partial class Beverages : Form
    {
        public static Beverages instance;
        public Beverages()
        {
            InitializeComponent();
            instance = this;
        }

        private void Beverages_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Show();
        }
    }
}
