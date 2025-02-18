using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LivingStudent : Form
    {
        public LivingStudent()
        {
            InitializeComponent();
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void LivingStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
