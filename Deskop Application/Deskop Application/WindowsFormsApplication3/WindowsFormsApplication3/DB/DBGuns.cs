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
using System.Data.SQLite;

namespace WindowsFormsApplication3
{
    public partial class DBGuns : Form
    {
        public SQLiteConnection conn;

        public DBGuns()
        {
            conn = new SQLiteConnection("Data source=database.sqliteASG");

            InitializeComponent();
        }

        string weapon_pickd;
        
        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }
        private void menu_modyf_bron_Load(object sender, EventArgs e)
        {
                SqlConnection conn = new SqlConnection(@"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234");

                 conn.Open(); // otwarcie polaczenia z baza danych dla okreslonego wyzej adresu conn
                SqlCommand sc = new SqlCommand("select * from bronie_ASG", conn); // tworzenie nowego zapytania i wysylanego do bazy danych ASG

                SqlDataReader reader = sc.ExecuteReader();//odczytanie wszystkich elementow z bazy danych dotyczacych zapytania do programu
              
                DataTable dt = new DataTable();
                dt.Columns.Add("model_broni", typeof(string));

                dt.Load(reader);
                comboBox_wybierzbron.ValueMember = "model_broni";
                comboBox_wybierzbron.DisplayMember = "model_broni";
                comboBox_wybierzbron.DataSource = dt;
                conn.Close(); // zakonczenie polaczenia z baza danych
        }
        private void comboBox_wybierzbron_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon_pickd = Convert.ToString(comboBox_wybierzbron.Text);

            SqlConnection conn = new SqlConnection(@"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234");
            SqlCommand command = new SqlCommand("select model_broni, typ, FPS, Pojemność_magazynka, Napęd from bronie_ASG where model_broni='" + weapon_pickd + "'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                  string  typ_picked = (reader["typ"].ToString());
                  string FPS_picked  = (reader["FPS"].ToString());
                    string poj_picked = (reader["Pojemność_magazynka"].ToString());
                    string naped_picked = (reader["Napęd"].ToString());
                    string model_picked= (reader["model_broni"].ToString());
                    typ_broni.Text = typ_picked;
                    FPS_broni.Text = FPS_picked;
                    Pojemnosc_broni.Text = poj_picked;
                    naped_broni.Text = naped_picked;
                    model_broni.Text = model_picked;

                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void przenies1_Click(object sender, EventArgs e)
        {
             model_broni_przenies.Text= model_broni.Text;

        }

        private void przenies2_Click(object sender, EventArgs e)
        {
              typ_broni_przenies.Text= typ_broni.Text;
        }

        private void przenies3_Click(object sender, EventArgs e)
        {
            naped_broni_przenies.Text = naped_broni.Text;
        }

        private void przenies4_Click(object sender, EventArgs e)
        {
             Pojemnosc_broni_przenies.Text= Pojemnosc_broni.Text;
        }

        private void przenies5_Click(object sender, EventArgs e)
        {
              FPS_broni_przenies.Text= FPS_broni.Text;
        }

        private void modyfikuj_przycisk_Click(object sender, EventArgs e)
        {

            if (model_broni_przenies.Text == "" || FPS_broni_przenies.Text == "" || Pojemnosc_broni_przenies.Text == "" || typ_broni_przenies.Text == "" || naped_broni_przenies.Text == "")
            {
                MessageBox.Show("Wypełnij okienka");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "delete from bronie_ASG where model_broni = '" + model_broni.Text + "'" + "Insert INTO Bronie_ASG VALUES('" + model_broni_przenies.Text + "','" + typ_broni_przenies.Text + "','" + FPS_broni_przenies.Text + "','" + Pojemnosc_broni_przenies.Text + "','" + naped_broni_przenies.Text + " ')";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                MessageBox.Show("Zmodyfikowano!");
                DBGuns open_modyf_bron = new DBGuns();
                open_modyf_bron.Show();
                this.Close();
            }
        }

     

        private void model_broni_przenies_TextChanged(object sender, EventArgs e)
        {
            if (model_broni_przenies.Text == "")
            {
                model_broni_przenies.BackColor = Color.OrangeRed;
               

            }
            else
            {
                model_broni_przenies.BackColor = Color.LightGreen;

            }
        }

        private void typ_broni_przenies_TextChanged(object sender, EventArgs e)
        {
            //typ_broni_przenies.Text = string.Concat(typ_broni_przenies.Text.Where(char.IsLetter));
            if (typ_broni_przenies.Text == "")
            {
                typ_broni_przenies.BackColor = Color.OrangeRed;

            }
            else
            {
                typ_broni_przenies.BackColor = Color.LightGreen;

            }
        }

        private void naped_broni_przenies_TextChanged(object sender, EventArgs e)
        {
            naped_broni_przenies.Text = string.Concat(naped_broni_przenies.Text.Where(char.IsLetter));
            if (naped_broni_przenies.Text == "")
            {
                naped_broni_przenies.BackColor = Color.OrangeRed;

            }
            else
            {
                naped_broni_przenies.BackColor = Color.LightGreen;

            }
        }

        private void Pojemnosc_broni_przenies_TextChanged(object sender, EventArgs e)
        {
            Pojemnosc_broni_przenies.Text = string.Concat(Pojemnosc_broni_przenies.Text.Where(char.IsDigit));

            if (Pojemnosc_broni_przenies.Text == "")
            {
                Pojemnosc_broni_przenies.BackColor = Color.OrangeRed;

            }
            else
            {
                Pojemnosc_broni_przenies.BackColor = Color.LightGreen;

            }
        }

        private void FPS_broni_przenies_TextChanged(object sender, EventArgs e)
        {
            FPS_broni_przenies.Text = string.Concat(FPS_broni_przenies.Text.Where(char.IsDigit));

            if (FPS_broni_przenies.Text == "")
            {
                FPS_broni_przenies.BackColor = Color.OrangeRed;
               

            }
            else
            {
                FPS_broni_przenies.BackColor = Color.LightGreen;

                
            }
        }

        private void Usun_bron_Click(object sender, EventArgs e)
        {
           
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "delete from bronie_ASG where model_broni='" + weapon_pickd + "'";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                this.Close();
            
        }
    }
}
