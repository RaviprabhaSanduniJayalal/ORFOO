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
    public partial class Appetizers : Form
    {
        public static Appetizers instance;
        public Appetizers()
        {
            InitializeComponent();
            instance = this;
        }

        private void Appetizers_Load(object sender, EventArgs e)
        {

        }

        private void panelAp1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Order form =new Order();
            form.Show();
        }
    }
}
