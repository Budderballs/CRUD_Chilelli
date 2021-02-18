using System;
using System.Windows.Forms;

namespace CRUD_Chilelli
{
    public partial class CRUD : Form
    {
        Product pf = new Product();
        Customer cf = new Customer();
        public CRUD()
        {
            InitializeComponent();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            pf.ShowDialog();
            this.Show();
        }
        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            cf.ShowDialog();
            this.Show();
        }
    }
}
