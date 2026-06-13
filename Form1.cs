using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BFMS;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'bFMSDataSet.signup' table. You can move, or remove it, as needed.
            this.signupTableAdapter.Fill(this.bFMSDataSet.signup);

        }
        private void load_data()
        {
            cmd = new SqlCommand("SELECT * FROM signup",con);
            sda = new SqlDataAdapter(); 
            sda.SelectCommand = cmd;
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
