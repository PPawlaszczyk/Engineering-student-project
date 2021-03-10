using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingRange
{
    public partial class EditView : Form
    {
        public EditView()
        {
            InitializeComponent();
        }
        private void modyfikuj_bron_Click(object sender, EventArgs e)
        {
            DBGunsView formview = new DBGunsView();
            formview.Show();
            this.Close();
        }

        private void zmien_haslo_Click(object sender, EventArgs e)
        {
            DBLogin open_login_haslo= new DBLogin();
            open_login_haslo.Show();
            this.Close();
        }

        private void edytuj_Load(object sender, EventArgs e)
        {
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            ModesView open_menu = new ModesView();
            open_menu.Show();
            this.Close();
        }
    }
}
