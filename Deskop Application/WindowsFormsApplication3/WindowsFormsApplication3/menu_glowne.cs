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
    
    public partial class menu : Form
        
    {

       // public static SqlCommand selcommand = null;
      //  public static SqlCommand inscommand = null;
      //  public static SqlConnection conn = null;
     //   SqlDataReader reader;

        public menu()
        {
            InitializeComponent();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
          //  pol_bazadanych();//połaczenie z baza danych
            menu_login open_login = new menu_login();
            open_login.Show();
            this.Hide();

        }

        private void start_Click(object sender, EventArgs e)
        {
           // pol_bazadanych(); //połaczenie z baza danych
            start open_start = new start();
            open_start.Show();
            this.Hide();

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
