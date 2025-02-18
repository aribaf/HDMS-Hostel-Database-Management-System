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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmanageroom_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void btnnewstudent_Click(object sender, EventArgs e)
        {
            NewStudent ns= new NewStudent();
            ns.Show();

        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnStudentfees_Click(object sender, EventArgs e)
        {
            StudentFee sf = new StudentFee();
            sf.Show();
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeavedStudent_Click(object sender, EventArgs e)
        {
            LeavedStudent ls = new LeavedStudent();
            ls.Show();
            
            
        }

        private void btnStudentLiving_Click(object sender, EventArgs e)
        {
            LivingStudent vs = new LivingStudent();
            vs.Show();
        }

        private void btnleavedStudents_Click(object sender, EventArgs e)
        {
            LeavedStudent les = new LeavedStudent();
            les.Show();
        }
    }
}
