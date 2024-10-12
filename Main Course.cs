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
    public partial class Main_Course : Form
    {
        public static Main_Course instance;
        public Main_Course()
        {
            InitializeComponent();
            instance = this;
        }

        private void Main_Course_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Show();
        }
    }
}
