using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace assignment2
{
    public partial class student : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=studentinformation;Integrated Security=True;Pooling=False";
        public student()
        {
            InitializeComponent();
        }

    /*   private void student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentinformationDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.studentinformationDataSet.Table);

        } */

        private void btnadd_Click(object sender, EventArgs e)
        {
            //value for rollno
            int rollno = Convert.ToInt32(txtrollno.Text);
            string name = txtnane.Text;
            DateTime dob = dtpdate.Value;
            string gender = "";
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            string department = cbdepartment.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            string saddress = txtaddress.Text;
            int phonenumber= Convert.ToInt32(txtphone.Text);
            MessageBox.Show(rollno + "\n" + name + "\n" + dob + "\n" + gender + "\n" + department + "\n" + course +"\n" +semester +"\n" +saddress +"\n" +phonenumber);

            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into studentinformation values(@rol,@nam,@do,@gen,@dep,@co,@sem,@add,@pun)"; //parameters to sql query
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rol", rollno);
                cmd.Parameters.AddWithValue("@nam", name);
                cmd.Parameters.AddWithValue("@do", dob);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dep", department);
                cmd.Parameters.AddWithValue("@co", course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@add", saddress);
                cmd.Parameters.AddWithValue("@pun", phonenumber);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data inserted" + res);
              //  this.registerShippingTableAdapter.Fill(this.trainingDBDataSet.RegisterShipping);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            } 


        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from studentinformation";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);
                        lbselect.Items.Add("*****");
                    }
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = (int)cbroll.SelectedValue;
                MessageBox.Show("rollno is:" + rollno);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from studentinformation where rollno=@rol";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rol", rollno);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("dta deleted:" + res);
                //update the dataset and remoce the deleted user from 
              //  this.studentinformationTableAdapter.Fill(this.studentinformationDataSet10.studentinformation);



            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void student_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentinformationDataSet10.studentinformation' table. You can move, or remove it, as needed.
            this.studentinformationTableAdapter.Fill(this.studentinformationDataSet10.studentinformation);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            string saddress = txtaddress.Text;
            int phonenumber = Convert.ToInt32(txtphone.Text);
            string department = cbdepartment.Text;
            string course = cbcourse.Text;
            string semester = cbsemester.Text;

            try
            {
                string rollno = txtrollno.Text;
                MessageBox.Show("roll no is :" + rollno);
              
                string query = "update studentinformation set department=@dep,course=@co,semester=@sem,saddress=@add,phonenumber=@pun where rollno=@rol ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dep", department);
                cmd.Parameters.AddWithValue("@co", course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@add", saddress);
                cmd.Parameters.AddWithValue("@pun", phonenumber);
                cmd.Parameters.AddWithValue("@rol", rollno);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("updated row" + res);


            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
