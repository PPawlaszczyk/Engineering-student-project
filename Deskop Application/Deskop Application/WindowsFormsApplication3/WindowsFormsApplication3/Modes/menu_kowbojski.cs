using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication3
{
    public partial class menu_kowbojski : Form
    {
        public menu_kowbojski()
        {
            InitializeComponent();
        }
        int l = 0; // czas timera podczas dzialania programu
        int i = 5; // czas timera 1
        int j = 0; // do jednokrotnego zalaczenia dzwieku
        int k = 0; // do zmiany stanu zeby wlaczyl sie timer

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (i > 0 && k>=1) //warunek aby zadzialal timer
            {

                i--;

                timer.Text = "Czas do startu: " + i.ToString() + "s";
            }
            if (i == 0) //warunek dzwieku

            {
                j++;
                if (j == 1)
                {
                    var myplayer = new System.Media.SoundPlayer();
                    myplayer.SoundLocation = @"C:\Users\Dazzyl\Desktop\arudino fun\alarme.wav";
                    myplayer.Play();
                    timer.Visible = false;
                 
                }

            }
        }

        private void menu_kowbojski_Load(object sender, EventArgs e)
        {
           
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
            
                timer1.Start();
                k++;
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(j >=1)
            {
                
                czas_strzelania.Visible = true;
                l++;
                czas_strzelania.Text = "Czas Strzelania: " + l.ToString() + "s";
                
            }
           
            if (l == 3)
            {

                timer2.Stop();
                wyniki.Visible = true;
            }

        }
    }
}
