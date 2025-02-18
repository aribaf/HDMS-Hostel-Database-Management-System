using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class NewStudent : Form
    {
        functiom fn = new functiom();
        String query;
        public NewStudent()
        {
           

            InitializeComponent();
        }


        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(150, 100);
            query = "select roomNo from rooms where roomStatus = 'Yes' and Booked= 'No'";
            DataSet ds =fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++ ) 
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboroomno.Items.Add(room);
            }

        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        public void clearALL()
        {
            txtmobile.Clear();
            txtname.Clear();
            txtfather.Clear();
            txtmother.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtcollege.Clear();
            txtID.Clear();
            comboroomno.SelectedIndex = -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtmobile.Text!="" && txtaddress.Text != "" && txtcollege.Text != "" && txtemail.Text != "" && txtfather.Text != "" && txtID.Text != "" && txtmother.Text != "" && txtname.Text != "")
            {
                Int64 mobile = Int64.Parse(txtmobile.Text);
                String name = txtname.Text;
                String fatherName = txtfather.Text;
                String motherName = txtmother.Text;
                String email = txtemail.Text;
                String paddress = txtaddress.Text;
                String college = txtcollege.Text;
                String idproof = txtID.Text;
                Int64 roomNo = Int64.Parse(comboroomno.Text);

                query = "insert into newStudent (mobile,name,fathername,mothername,email,paddress,college,idproof,roomNo) " +
                    "values ('" + mobile + "','" + name + "','" + fatherName + "','" + motherName + "','"+ email +"','" + paddress + "','" + college + "','" + idproof + "','" + roomNo + "') update rooms set Booked='Yes' where roomNo= " + roomNo + "";
                fn.setData(query, "Student Registeration Successful.");

            }
            else
            {
                MessageBox.Show("Please fill all boxes.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboroomno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
