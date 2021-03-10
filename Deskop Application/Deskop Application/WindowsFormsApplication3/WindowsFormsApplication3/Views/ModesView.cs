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
    public partial class ModesView : Form
    {
        public ModesView()
        {
            InitializeComponent();
        }

     

        private void tryb1_przycisk_Click(object sender, EventArgs e)
        {
            menu_wolnostrzelny open_wolonstrzelny = new menu_wolnostrzelny();
            open_wolonstrzelny.Show();
            this.Close();

        }

        private void tryb2_przycisk_Click(object sender, EventArgs e)
        {
            menu_szybkostrzelny open_szybkostrzelny = new menu_szybkostrzelny();
            open_szybkostrzelny.Show();
            this.Close();
        }

        private void tryb3_przycisk_Click(object sender, EventArgs e)
        {
            menu_kowbojski open_kowbojski = new menu_kowbojski();
            open_kowbojski.Show();
            this.Close();
        }
        private void refleks_button_Click(object sender, EventArgs e)
        {
            Menu_refleks open_refleks = new Menu_refleks();
            open_refleks.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            EditView open_login = new EditView();
            open_login.Show();
            this.Close();
        }
    }
}
