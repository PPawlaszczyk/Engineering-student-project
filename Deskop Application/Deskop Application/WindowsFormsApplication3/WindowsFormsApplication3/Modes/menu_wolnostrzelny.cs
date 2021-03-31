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
    public partial class menu_wolnostrzelny : Form
    {
        public menu_wolnostrzelny()
        {
            InitializeComponent();
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            Workspace open_menu = new Workspace();
            open_menu.Show();
            this.Close();
        }
    }
}
