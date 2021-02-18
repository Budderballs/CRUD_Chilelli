using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Chilelli
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            getTheProductStuff();
        }
        private void getTheProductStuff()
        {
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("ProductSummary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                ProductGridView.DataSource = dt;
            }
        }
    }
}