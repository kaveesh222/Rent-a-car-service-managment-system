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
    public partial class Returnvehicle : Form
    {
        public Returnvehicle()
        {
            InitializeComponent();
        }
        string driver;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TDDKJH3;Initial Catalog=Ayubo_leasure;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //variable assignment
            int s_reading = int.Parse(txtstartreading.Text);
            int e_reading = int.Parse(txtendreading.Text);
            DateTime rented = dtprented.Value.Date;
            DateTime returned = dtpreturned.Value.Date;
            string v_type = cmbvtype.Text;
            string t_type = cmbtourtype.Text;
            //time difference
            TimeSpan time_d = returned - rented;
            int duration = time_d.Days;
            txtduration.Text = duration.ToString();
            //distence difference
            int destination = e_reading - s_reading;
            txtdistence.Text = destination.ToString();

            //calculate days, weeks and months
            int months = duration / 30;
            int weeks = (duration - duration % 30) / 7;
            int days = duration - (duration - duration % 30) % 7;

            //assigning chargers for days, weeks and months
            int per_day_charge = 500;
            int per_week_charge = 3000;
            int per_month_charge = 10000;
            int driver_charge = 1000;

            if (cbwith.Checked == true)
            {
                if (t_type == "Short")
                {
                    if (v_type == "Car")
                    {
                        int total_charge = destination * 50 + 500 + 500;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Van")
                    {
                        int total_charge = destination * 50 + 500 + 1000;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Jeep")
                    {
                        int total_charge = destination * 50 + 500 + 1500;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (t_type == "SUV")
                    {
                        int total_charge = destination * 50 + 500 + 1200;
                        txttotal.Text = total_charge.ToString();
                    }
                }
                else if (t_type == "Long")
                {
                    if (v_type == "Car")
                    {
                        int total_charge = 500 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge + duration * driver_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Van")
                    {
                        int total_charge = 1000 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge + duration * driver_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Jeep")
                    {
                        int total_charge = 1500 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge + duration * driver_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (t_type == "SUV")
                    {
                        int total_charge = 1200 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge + duration * driver_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                }
            }
            else if (cbwithout.Checked == true)
            {
                if (t_type == "Short")
                {
                    if (v_type == "Car")
                    {
                        int total_charge = destination * 50 + 500;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Van")
                    {
                        int total_charge = destination * 50 + 1000;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Jeep")
                    {
                        int total_charge = destination * 50 + 1500;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (t_type == "SUV")
                    {
                        int total_charge = destination * 50 + 1200;
                        txttotal.Text = total_charge.ToString();
                    }
                }
                else if (t_type == "Long")
                {
                    if (v_type == "Car")
                    {
                        int total_charge = 500 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Van")
                    {
                        int total_charge = 1000 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                    else if (v_type == "Jeep")
                    {
                        int total_charge = 1500 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge;
                    }
                    else if (t_type == "SUV")
                    {
                        int total_charge = 1200 + days * per_day_charge + weeks * per_week_charge + months * per_month_charge;
                        txttotal.Text = total_charge.ToString();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string t_type = cmbtourtype.Text;
                if(t_type == "Long")
                {
                    //code for search button
                    string search = txtsearch.Text; //search text field

                    //sql command for search button
                    string search_query = "SELECT * FROM L_Tour WHERE nic = '" + search + "'";
                    SqlCommand cmdSearch = new SqlCommand(search_query, con);

                    con.Open();     //open the sql connection
                    SqlDataReader r = cmdSearch.ExecuteReader();

                    while (r.Read())
                    {
                        //search text fields by index number
                        txtfulname.Text = r[0].ToString();
                        txtemail.Text = r[1].ToString();
                        txtnic.Text = r[2].ToString();
                        dtprented.Text = r[3].ToString();
                        cmbvbrand.Text = r[6].ToString();
                        cmbvtype.Text = r[7].ToString();
                        string driver = r[8].ToString();
                        if (driver == "with driver")
                        {
                            cbwith.Checked = true;
                        }
                        if (driver == "without driver")
                        {
                            cbwithout.Checked = true;
                        }
                        MessageBox.Show("Data showed successfully..!");
                    }
                }
                else if(t_type == "Short")
                {
                    //code for search button
                    string searchnic = txtsearch.Text; //search text field

                    // sql connection for search button
                    string search_query = "SELECT * FROM S_Tour WHERE nic = '" + searchnic + "'";
                    SqlCommand cmdSearch = new SqlCommand(search_query, con);

                    con.Open(); // open the sql connection
                    SqlDataReader r = cmdSearch.ExecuteReader();

                    while (r.Read())
                    {
                        //search all the text fields by index number
                        txtfulname.Text = r[0].ToString();
                        txtemail.Text = r[1].ToString();
                        dtprented.Text = r[2].ToString();
                        txtnic.Text = r[4].ToString();
                        cmbvbrand.Text = r[5].ToString();
                        cmbvtype.Text = r[6].ToString();
                        string driver = r[7].ToString();
                        if (driver == "with driver")
                        {
                            cbwith.Checked = true;
                        }
                        if (driver == "without driver")
                        {
                            cbwithout.Checked = true;
                        }
                        txtstartreading.Text = r[8].ToString();


                        MessageBox.Show("Data showed successfully..!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching " + ex);
            }
            finally
            {
                con.Close();    //close the sql connection
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = txtfulname.Text;
                string email = txtemail.Text;
                DateTime rent = dtprented.Value;
                DateTime returndate = dtpreturned.Value;
                int nic = int.Parse(txtnic.Text);
                int total = int.Parse(txttotal.Text);
                int srading = int.Parse(txtstartreading.Text);
                int erading = int.Parse(txtendreading.Text);
                int duration = int.Parse(txtduration.Text);
                string vtype = cmbvtype.Text;
                string vbrand = cmbvbrand.Text;

                if (cbwith.Checked == true)
                {
                    driver = "with driver";
                }
                if (cbwithout.Checked == true)
                {
                    driver = "without driver";
                }
                string tour_type = cmbtourtype.Text;
                int dis = int.Parse(txtdistence.Text);

                //sql command for insert button
                string insert_query = "INSERT INTO R_vehicle VALUES ('" + fullname + "', '" + email + "', '" + rent + "', '" + returndate + "', '" + nic + "', '" + total + "', '" + srading + "', '" + erading + "', '" + duration + "', '" + vbrand + "', '" + vtype + "', '" + driver + "', '" + tour_type + "', '" + dis + "')";
                SqlCommand cmdInsert = new SqlCommand(insert_query, con);

                con.Open(); //open the sql connection
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully..!");

                //clear all text fields
                txtfulname.Text = "";
                txtemail.Text = "";
                txtnic.Text = "";
                txttotal.Text = "";
                txtstartreading.Text = "";
                txtendreading.Text = "";
                txtduration.Text = "";
                cmbvbrand.Text = "";
                cmbvtype.Text = "";
                cbwith.Checked = false;
                cbwithout.Checked = false;
                cmbtourtype.Text = "";
                txtdistence.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not saved suceesfully..! Try again..." + ex);
            }
            finally
            {
                con.Close();    //close sql connection
                BindData();
            }
            void BindData()
            {
                // show insert, update & delete functions through datagridview
                SqlCommand command = new SqlCommand("SELECT * FROM R_vehicle", con);
                SqlDataAdapter Ayubo_Leisure = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                Ayubo_Leisure.Fill(dt);
                dgvreturn.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //code for delete button
                string searchnic = txtsearch.Text;   //search text field

                //sql connection for delete button
                string delete_query = "DELETE R_vehicle WHERE nic = '" + searchnic + "' ";
                SqlCommand cmdDelete = new SqlCommand(delete_query, con);

                con.Open(); //open sql connection
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfully..!");
                //clear the text field
                txtfulname.Text = "";
                txtemail.Text = "";
                txtnic.Text = "";
                txttotal.Text = "";
                txtstartreading.Text = "";
                txtendreading.Text = "";
                txtduration.Text = "";
                cmbvbrand.Text = "";
                cmbvtype.Text = "";
                cbwith.Checked = false;
                cbwithout.Checked = false;
                cmbtourtype.Text = "";
                txtdistence.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not deleted suceesfully..! Try again..." + ex);
            }
            finally
            {
                con.Close();    //close the sql connection
                BindData();
            }
            void BindData()
            {
                // show insert, update & delete functions through datagridview
                SqlCommand command = new SqlCommand("SELECT * FROM S_Tour", con);
                SqlDataAdapter Ayubo_Leisure = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                Ayubo_Leisure.Fill(dt);
                dgvreturn.DataSource = dt;
            }
        }
    }
}
