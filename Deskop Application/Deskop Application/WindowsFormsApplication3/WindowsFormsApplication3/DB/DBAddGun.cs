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
    public partial class menu_dod_bron : Form
        
    {
        
        public menu_dod_bron()
        {
            InitializeComponent();
        }

      
   

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }

     

    

        private void dodaj_Click(object sender, EventArgs e)
        {

            if (Model_bron.Text == "" || FPS.Text == "" || Poj_magazynka.Text == "" || TYP.Text == "" || Naped.Text == "")
            {
                MessageBox.Show("Wypełnij okienka");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Insert INTO Bronie_ASG VALUES('" + Model_bron.Text + "','" + TYP.Text + "','" + FPS.Text + "','" + Poj_magazynka.Text + "','" + Naped.Text + "')";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                MessageBox.Show("Dodano broń");
                menu_dod_bron open_dodaj_bron = new menu_dod_bron();
                open_dodaj_bron.Show();
                this.Close();

            }

        }

        private void Model_bron_TextChanged(object sender, EventArgs e)
        {
            if (Model_bron.Text == "")
            {
                Model_bron.BackColor = Color.OrangeRed;
                checkBox1.Checked = false;

            }
            else
            {
                Model_bron.BackColor = Color.LightGreen;

                checkBox1.Checked = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (model_broni.Text == "")

                checkBox1.ForeColor = Color.Red;


            else

                checkBox1.ForeColor = Color.Green;
            
        }

        private void Naped_TextChanged(object sender, EventArgs e)
        {
            Naped.Text = string.Concat(Naped.Text.Where(char.IsLetter));
            if (Naped.Text == "")
            {
                Naped.BackColor = Color.OrangeRed;
                checkBox3.Checked = false;

            }
            else
            {
                Naped.BackColor = Color.LightGreen;

                checkBox3.Checked = true;
            }


        }

        private void TYP_TextChanged(object sender, EventArgs e)
        {
            //TYP.Text = string.Concat(TYP.Text.Where(char.IsLetter));
            if (TYP.Text == "" )
            {
                TYP.BackColor = Color.OrangeRed;
                checkBox2.Checked = false;

            }
            else
            {
                TYP.BackColor = Color.LightGreen;

                checkBox2.Checked= true;
            }

        }

        private void FPS_TextChanged(object sender, EventArgs e)
        {
            FPS.Text = string.Concat(FPS.Text.Where(char.IsDigit));

            if (FPS.Text == "")
            {
                FPS.BackColor = Color.OrangeRed;
                checkBox4.Checked = false;

            }
            else
            {
                FPS.BackColor = Color.LightGreen;

                checkBox4.Checked = true;
            }


        }

        private void Poj_magazynka_TextChanged(object sender, EventArgs e)
        {
            Poj_magazynka.Text = string.Concat(Poj_magazynka.Text.Where(char.IsDigit));
              
            if (Poj_magazynka.Text == "")
            {
                Poj_magazynka.BackColor = Color.OrangeRed;
                checkBox5.Checked = false;

            }
            else
            {
                Poj_magazynka.BackColor = Color.LightGreen;

                checkBox5.Checked = true;
            }
        }

        private void menu_dod_bron_Load(object sender, EventArgs e)
        {

        }
    }
    
}
