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
    public partial class AddNewRoom : Form
    {
        functiom fn = new functiom();
        String query;

        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 100);
            labelroom.Visible = false;
            labelroomexist.Visible = false;

            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            String status;
            if(checkbox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";

            }
            query = "update rooms set roomStatus='" + status + "'where roomNo ="+txtroomno2.Text+"";
            fn.setData(query, "Details Updated.");
            AddNewRoom_Load(this, null);
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            query="select * from rooms where roomNo= "+txtroomno1.Text+"";
            DataSet ds = fn.getData(query);


            if (ds.Tables[0].Rows.Count == 0)
            {
                String status;
                if (checkbox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }

                labelroomexist.Visible = false;
                query = "insert into rooms(roomNo, roomStatus) values(" + txtroomno1.Text + ",'" + status + "')";
                fn.setData(query, "Room added successfully.");
                AddNewRoom_Load(this, null);
                
           }
            else
            {
                labelroomexist.Text = "Room Already Exists.";
                labelroomexist.Visible = true;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtroomno2.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                labelroom.Text = "No Room Exists.";
                labelroom.Visible = true;
                checkbox2.Checked= false;

            }
            else 
            {
                labelroom.Text = "Room Found.";
                labelroom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkbox2.Checked = true;
                }
                else
                {
                    checkbox2.Checked = false;
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(labelroom.Text=="Room Found.")
            {
                query = "delete from rooms where roomNo=" + txtroomno2.Text + "";
                fn.setData(query, "Room Details Deleted.");
                AddNewRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to Delete value that doesnt Exist.","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
