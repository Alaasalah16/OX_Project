using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OXproject
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=oxgame;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetGame();
        }
        public void GetGame()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "SELECT[Game_Id] ,[PlayerOneName],[PlayerTwoName],[OWin],[XWin] FROM [oxgame]";
            sqlCommand.Connection = con;

            // open connection
            con.Open();
            // execute command
            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // close connection
            con.Close();

            // display data in UI

            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into oxgame values (@PlayerOneName ,@PlayerTwoName,@Xwin,@OWin)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@PlayerOneName", textBox1.Text);
            cmd.Parameters.AddWithValue("@PlayerTwoName", textBox2.Text);
            cmd.Parameters.AddWithValue("@XWin", int.Parse(Xwin.Text));
            cmd.Parameters.AddWithValue("@OWin", int.Parse(Owin.Text));
            con.Close();
            MessageBox.Show("Data was added");
        }
    }
}
