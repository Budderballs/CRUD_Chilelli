using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Chilelli
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            getTheCustomerStuff();
        }
        private void getTheCustomerStuff()
        {
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("CustomerSummary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                CustomerGridView.DataSource = dt;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (IDText.Text == null || IDText.Text == "")
            {
                IDText.Text = "Invalid";
                return;
            }
            else
            {
                int ID = Convert.ToInt32(IDText.Text);
                using (SqlConnection conn = new SqlConnection(db.getConnString()))
                {
                    SqlCommand cmd = new SqlCommand("DeleteCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                getTheCustomerStuff();
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDText.Text);
            int addressID = Convert.ToInt32(IDText.Text);
            string t, fN, mN, lN, s, cN, sP, eA, p, aT, aL1, aL2, c, stateP, cR, pC;
            t = titleText.Text;
            fN = firstNameText.Text;
            mN = middleNameText.Text;
            lN = lastNameText.Text;
            s = suffixText.Text;
            cN = companyNameText.Text;
            sP = salesPersonText.Text;
            eA = emailAdressText.Text;
            p = phoneText.Text;
            aT = addressTypeText.Text;
            aL1 = adressLine1Text.Text;
            aL2 = adressLine2Text.Text;
            c = cityText.Text;
            stateP = stateProvinceText.Text;
            cR = countryRegionText.Text;
            pC = postalCodeText.Text;

            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@title", t);
                cmd.Parameters.AddWithValue("@firstname", fN);
                cmd.Parameters.AddWithValue("@middlename", mN);
                cmd.Parameters.AddWithValue("@lastname", lN);
                cmd.Parameters.AddWithValue("@suffix", s);
                cmd.Parameters.AddWithValue("@companyname", cN);
                cmd.Parameters.AddWithValue("@salesperson", sP);
                cmd.Parameters.AddWithValue("@emailaddress", eA);
                cmd.Parameters.AddWithValue("@phone", p);
                cmd.Parameters.AddWithValue("@addresstype", aT);
                cmd.Parameters.AddWithValue("@addressline1", aL1);
                cmd.Parameters.AddWithValue("@addressline2", aL2);
                cmd.Parameters.AddWithValue("@city", c);
                cmd.Parameters.AddWithValue("@stateprovince", stateP);
                cmd.Parameters.AddWithValue("@countryregion", cR);
                cmd.Parameters.AddWithValue("@postalcode", pC);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            getTheCustomerStuff();
        }
        private void grabInfo_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDText.Text);
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("populateTextBoxes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                conn.Open();
                SqlDataReader dR = cmd.ExecuteReader();
                dR.Read();
                titleText.Text = dR.GetValue(1).ToString();
                firstNameText.Text = dR.GetValue(2).ToString();
                middleNameText.Text = dR.GetValue(3).ToString();
                lastNameText.Text = dR.GetValue(4).ToString();
                suffixText.Text = dR.GetValue(5).ToString();
                companyNameText.Text = dR.GetValue(6).ToString();
                salesPersonText.Text = dR.GetValue(7).ToString();
                emailAdressText.Text = dR.GetValue(8).ToString();
                phoneText.Text = dR.GetValue(9).ToString();
                addressTypeText.Text = dR.GetValue(10).ToString();
                adressLine1Text.Text = dR.GetValue(11).ToString();
                adressLine2Text.Text = dR.GetValue(12).ToString();
                cityText.Text = dR.GetValue(13).ToString();
                stateProvinceText.Text = dR.GetValue(14).ToString();
                countryRegionText.Text = dR.GetValue(15).ToString();
                postalCodeText.Text = dR.GetValue(16).ToString();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type Customer ID into the first box \nPress the blue button \nPress the red button to delete \n" +
                "Make changes and press the green button to update or add");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string t, fN, mN, lN, s, cN, sP, eA, p, aT, aL1, aL2, c, stateP, cR, pC;
            t = titleText.Text;
            fN = firstNameText.Text;
            mN = middleNameText.Text;
            lN = lastNameText.Text;
            s = suffixText.Text;
            cN = companyNameText.Text;
            sP = salesPersonText.Text;
            eA = emailAdressText.Text;
            p = phoneText.Text;
            aT = addressTypeText.Text;
            aL1 = adressLine1Text.Text;
            aL2 = adressLine2Text.Text;
            c = cityText.Text;
            stateP = stateProvinceText.Text;
            cR = countryRegionText.Text;
            pC = postalCodeText.Text;

            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("addNewCustomerCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", t);
                cmd.Parameters.AddWithValue("@firstname", fN);
                cmd.Parameters.AddWithValue("@middlename", mN);
                cmd.Parameters.AddWithValue("@lastname", lN);
                cmd.Parameters.AddWithValue("@suffix", s);
                cmd.Parameters.AddWithValue("@companyname", cN);
                cmd.Parameters.AddWithValue("@salesperson", sP);
                cmd.Parameters.AddWithValue("@emailaddress", eA);
                cmd.Parameters.AddWithValue("@phone", p);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("addNewCustomerAddressAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addressline1", aL1);
                cmd.Parameters.AddWithValue("@addressline2", aL2);
                cmd.Parameters.AddWithValue("@city", c);
                cmd.Parameters.AddWithValue("@stateprovince", stateP);
                cmd.Parameters.AddWithValue("@countryregion", cR);
                cmd.Parameters.AddWithValue("@postalcode", pC);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("addNewCustomerAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addresstype", aT);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            getTheCustomerStuff();
        }

        private void IDText_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(IDText.Text))
            {
                IDText.Text = "Enter Customer ID";
            }
        }

        private void IDText_MouseClick(object sender, MouseEventArgs e)
        {
            if (IDText.Text == "Enter Customer ID")
            {
                IDText.Clear();
            }
        }
    }
}