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

namespace ShootingRange
{
    
    public partial class menu : Form
        
    {
        Database databaseObject = new Database();
        // public static SqlCommand selcommand = null;
        //  public static SqlCommand inscommand = null;
        //  public static SqlConnection conn = null;
        //   SqlDataReader reader;

        public menu()
        {
            InitializeComponent();
        }

        //private void edytuj_Click(object sender, EventArgs e)
        //{
        //    LoginView open_login = new LoginView();
        //    open_login.Show();
        //    this.Hide();
        //}

        //private void start_Click(object sender, EventArgs e)
        //{
         //   pol_bazadanych(); //połaczenie z baza danych
         //   start open_start = new start();
        //    open_start.Show();
        //    this.Hide();

        //}

        private void loguj_Click(object sender, EventArgs e)
        {
            //if (textBox_login.Text == Properties.Settings.Default.Username && textBox_haslo.Text == Properties.Settings.Default.Password)
            //{
            ModesView open_edycja = new ModesView();
            open_edycja.Show();
            //this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Error: Wrong Login or Password");
            //}
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = "admin"; //ustanowienie dostepu i przypisanie mu nowej wartosci uzytkownika

            Properties.Settings.Default.Password = "admin1"; // ustanowienie dostepu i przypisanie mu nowej wartosci hasla
            Properties.Settings.Default.Save(); // utrwalenie zmian miedzy formularzami aplikacji metoda Save
            MessageBox.Show("Haslo zresetowane do ustawien domyslnych"); //komunikat o zresetowaniu ustawien
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }



    }
}
