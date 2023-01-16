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

namespace Ayubo
{
    public partial class Addvehicle : Form
    {
        public Addvehicle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TDDKJH3;Initial Catalog=Ayubo_leasure;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //assign variables
                string register_no = txtregisternumber.Text;
                int reading = int.Parse(txtreading.Text);
                DateTime date = dtpdate.Value;
                string lowner = txtowner.Text;
                string v_type = cmbvtype.Text;
                int mfyear = int.Parse(cmbmfy.Text);
                string v_brand = cmbvbrand.Text;
                string wheelcount = cmbwheels.Text;
                string search = txtsearch.Text;

                //Sql query
                string insert_query = "INSERT INTO A_vehicle VALUES ('" + register_no + "', '" + reading + "', '" + date + "', '" + lowner + "', '" + wheelcount + "', '" + mfyear + "', '" + v_brand + "','" + v_type + "')";
                SqlCommand cmdInsert = new SqlCommand(insert_query, con);

                con.Open();
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully..!");

                //clear all textboxes
                txtreading.Text = "";
                txtregisternumber.Text = "";
                txtowner.Text = "";
                cmbvbrand.Text = "";
                cmbmfy.Text = "";
                cmbvbrand.Text = "";
                cmbwheels.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not saved suceesfully..! Try again..." + ex);
            }
            finally
            {
                con.Close();
                BindData();
            }

            void BindData()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM A_vehicle", con);
                SqlDataAdapter Ayubo_Leisure = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                Ayubo_Leisure.Fill(dt);
                dgvvehicle.DataSource = dt;
            }
        }
        

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string searchregno = txtsearch.Text;

                string delete_query = "DELETE A_vehicle WHERE reg_no = '" + searchregno + "' ";
                SqlCommand cmdDelete = new SqlCommand(delete_query, con);

                con.Open();
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfully..!");

                txtsearch.Text = "";
                txtowner.Text = "";
                txtreading.Text = "";
                txtregisternumber.Text = "";
                cmbmfy.Text = "";
                cmbvbrand.Text = "";
                cmbvtype.Text = "";
                cmbwheels.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not deleted suceesfully..! Try again..." + ex);
            }
            finally
            {
                con.Close();
                BindData();
            }
            void BindData()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM A_vehicle", con);
                SqlDataAdapter Ayubo_Leisure = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                Ayubo_Leisure.Fill(dt);
                dgvvehicle.DataSource = dt;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchregno = txtsearch.Text;

                string search_query = "SELECT * FROM A_vehicle WHERE reg_no = '" + searchregno + "'";
                SqlCommand cmdSearch = new SqlCommand(search_query, con);

                con.Open();
                SqlDataReader r = cmdSearch.ExecuteReader();

                while (r.Read())
                {
                    txtregisternumber.Text = r[0].ToString();
                    txtreading.Text = r[1].ToString();
                    dtpdate.Text = r[2].ToString();
                    txtowner.Text = r[3].ToString();
                    cmbwheels.Text = r[4].ToString();
                    cmbmfy.Text = r[5].ToString();
                    cmbvbrand.Text = r[6].ToString();
                    cmbvtype.Text = r[7].ToString();

                    MessageBox.Show("Data showed successfully..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleno = int.Parse(txtregisternumber.Text);
                DateTime addeddate = dtpdate.Value.Date;
                int mfy = int.Parse(cmbmfy.Text);
                string vtype = cmbvtype.Text;
                string wheels = cmbwheels.Text;
                string brand = cmbvbrand.Text;
                int meterrading = int.Parse(txtreading.Text);
                string owner = txtowner.Text;


                string update_query = "UPDATE A_vehicle SET adddate = '" + addeddate + "', m_year = '" + mfy + "', v_type = '" + vtype + "', wheels = '" + wheels + "', v_brand = '" + brand + "', m_reding = '" + meterrading + "', lastowner = '" + owner + "' WHERE reg_no = '" + vehicleno + "' ";
                SqlCommand cmdUpdate = new SqlCommand(update_query, con);

                con.Open();
                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully..!");

                txtsearch.Text = "";
                txtowner.Text = "";
                txtreading.Text = "";
                txtregisternumber.Text = "";
                cmbmfy.Text = "";
                cmbvbrand.Text = "";
                cmbvtype.Text = "";
                cmbwheels.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not updated suceesfully..! Try again..." + ex);
            }
            finally
            {
                con.Close();
                BindData();
            }
            void BindData()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM A_vehicle", con);
                SqlDataAdapter Ayubo_Leisure = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                Ayubo_Leisure.Fill(dt);
                dgvvehicle.DataSource = dt;
            }
        }
    }
}
