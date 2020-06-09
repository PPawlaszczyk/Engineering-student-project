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

namespace WindowsFormsApplication3
{
    public partial class menu_usun_bron : Form
    {
        public menu_usun_bron()
        {

            InitializeComponent();
          
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }

        private void menu_usun_bron_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234");
            conn.Open();
            SqlCommand sc = new SqlCommand("select model_broni from bronie_ASG", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("model_broni", typeof(string));
           
            dt.Load(reader);

            combobox.ValueMember = "model_broni";
            combobox.DisplayMember = "model_broni";
            combobox.DataSource = dt;
            
            conn.Close();

      
           

        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ID = combobox.SelectedValue.ToString();
          
            bron_usuniecia.Text = combobox.Text;

        }

        private void Usun_bron_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "delete from bronie_ASG where model_broni='" + bron_usuniecia.Text +"'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            menu_usun_bron open_usun1 = new menu_usun_bron();
            open_usun1.Show();
            this.Close();
        }

        
    }
}
