using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class menu_login : Form
    {
        public menu_login()
        {
            InitializeComponent();
        }

        private void loguj_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == Properties.Settings.Default.Username && textBox_haslo.Text == Properties.Settings.Default.Password)
            {
                edytuj open_edycja = new edytuj();
                open_edycja.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Wrong Login or Password");
            }
        }

        private void reset_Click(object sender, EventArgs e)
           {
            Properties.Settings.Default.Username = "admin"; //ustanowienie dostepu i przypisanie mu nowej wartosci uzytkownika

            Properties.Settings.Default.Password = "admin1"; // ustanowienie dostepu i przypisanie mu nowej wartosci hasla
            Properties.Settings.Default.Save(); // utrwalenie zmian miedzy formularzami aplikacji metoda Save
            MessageBox.Show("Haslo zresetowane do ustawien domyslnych"); //komunikat o zresetowaniu ustawien
           }
    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_haslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }

        private void menu_login_Load(object sender, EventArgs e)
        {

        }
    }
}