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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Media;
namespace WindowsFormsApplication3
{
    public partial class Menu_refleks : Form
    {
        public Menu_refleks()
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeRows();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            port_com.Open();       
        }
        int czas_startu = 0; // dl odczekania ms do startu
        int czas_stopu = 0; //odczekanie ms do zakonczenia dzialania programu
        int time_sec, time_ms, Ms_value_all; // licznik czasu oraz ms_value aby umieścić w tablicy
        int counter_timer_lightON = 0;  //licznik dla zaswiecenia sie nastepnej diody
        bool isActive_timer, refleks_on;
        double wynik_ZI; //wynik roznicy z tablicy wynik biezacy i poprzedni
        int uaktywnienie_programu = 0; //odpowiada za skoki do poszczegolnych funkcji oraz aby sie uaktywnialy tylko raz w paru przypadkach
        int random_number_lightON = 100; // ustawiana na 100 aby nie wywolywala skokow do funkcji podczas dzialania programu

        string gunSelected; //wartosc modelu broni z tablicy do stringa
        string typ_picked; //wartosc typu broni z tablicy do stringa

        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-NF9GGJ7\SQLEXPRESS; Initial Catalog=ASG; Integrated Security=True;");

        List<double> reactionTimeTable = new List<double>();

        private void Menu_refleks_Load(object sender, EventArgs e)
        {
            time_ms = 0; //wartosc poczatkowa timera
            time_sec = 0; //wartosc poczatkowa timera
            isActive_timer = false; //flag for timer ms and s 
            refleks_on = false; // flag for  math
            timer1.Stop(); //wylaczenie timera odpowiadajacego za umiesczane wartosci w tabeli i obliczania
            Score_button.Enabled = false; //przycisk z wynikami wylaczony
            Stop_button.Enabled = false; //przycisk z stopem wylaczony

            SQL_combobox_fill(); // inicjalizacja sqla i stworzenie comboboxa
            fill_data_gridd_walhalla(); // sql pokazanie 10 wynikow najlepszych wypelniajac tabele
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            open_window(); // zamyka okno i wraca do glownego menu
        }
        private void start_button_Click(object sender, EventArgs e)
        {          
            timer1.Start();
            timer2.Start();
            refleks_on = true;
            czas_stopu = 0;
            start_button.Enabled = false;
            Score_button.Enabled = false;
            weapon_combobox.Enabled = false;
            ShooterName_textbox.Enabled = false;
            File.Delete("SHOOTER_wyniki.pdf");
            Stop_button.Enabled = true;
            tryb_picked();
            clearning_array();

            back_main_menu.Enabled = false;
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            start_button.Show();
            uaktywnienie_programu = 3;
            port_com.Write("C");
            Ms_value_all = 0;
            time_sec = 0; //wyzerowanie licznika sec
            time_ms = 0; //wyzerowanie licznika ms
            timer1.Stop();
            czas_startu = 0;
            isActive_timer = false;
            timer2.Stop();

            //przyciski i comboxoy wlaczeni
            start_button.Enabled = true;
            weapon_combobox.Enabled = true;
            ShooterName_textbox.Enabled = true;
            Stop_button.Enabled = false;
            back_main_menu.Enabled = true;
        }

        private void wyniki_Click(object sender, EventArgs e) //score_button
        {              
            if (start_button.Enabled == false) //aby wykonal tylko 1 dodanie do sqla
            {
                SQL_add_wallhala();
            }
            fill_data_gridd_walhalla();
            weapon_combobox.Enabled = true;
            ShooterName_textbox.Enabled = true;
            start_button.Enabled = true;
            GeneratePDF.CreatePDF(ShooterName_textbox.Text, Math.Round(reactionTimeTable.Average()/100, 2).ToString(), (reactionTimeTable.Max()/100).ToString(), (reactionTimeTable.Min()/100).ToString(), typ_picked, gunSelected);
   //         GeneratePDF.CreatePDF("stormtruoper", "23", "222", "12", "pistolet", "AKJ-47");
            System.Diagnostics.Process.Start("SHOOTER_wyniki.pdf");
            clearning_array();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
           try
            {
                wynik_ZI = Convert.ToDouble(port_com.ReadExisting()); // konwersja do porownania jaka to liczba dalem double bo nie chcialo mi sie zmieniac na int
            }
            catch (Exception)
            {
            }        
        }
        private void timer2_Tick(object sender, EventArgs e)
        {                
            if (refleks_on) // czas na przygotowanie sie strzelca
            {
                czas_startu++;
                if (czas_startu == 1000) //2000
                {
                    refleks_on = false;
                    port_com.Write("A");
                    isActive_timer = true;
                    czas_startu = 0;
                    uaktywnienie_programu = 1;
                }
                if (czas_startu == 500) //1500
                {
                    voice_sound();
                }
            }

            if (refleks_on == false) //dzialanie programu strzelca
            {               
                czas_stopu++;
                if (czas_stopu == 1100) // WYDANIE DZWIEKU PO ZAKONCZENIU PROGRAMU MUSI BYC TUTAJ INACZJE NIE DZIALA
                {
                    voice_sound();
                }

                if (czas_stopu == 1100 || uaktywnienie_programu == 3) //3 minuty 180000
                {                
                    start_button.Show();
                    uaktywnienie_programu = 3;
                    port_com.Write("C");
                    Ms_value_all = 0;
                    time_sec = 0;
                    time_ms = 0;
                    Stop_button.Enabled = false;                 

                    isActive_timer = false;
                   
                    timer1.Stop();
                    CalculateAVG();                 
                }

                if (( wynik_ZI >= 1) && uaktywnienie_programu == 1) //warunek zarejestrowania strzalu
                {
                    isActive_timer = false;
                    port_com.Write("C");
                    reactionTimeTable.Add(Convert.ToDouble(Ms_value_all));

                    Ms_value_all = 0; //wyzerowanie licznikow
                    time_sec = 0; //wyzerowanie licznikow
                    time_ms = 0; //wyzerowanie licznikow

                    Random random_func_light = new Random();
                    random_number_lightON = random_func_light.Next(50, 250);
                    uaktywnienie_programu = 2;
                }

                if (isActive_timer) //liczenie czasu po zaswieceniu sie diody 
                {
                    Ms_value_all++;
                    time_ms++;
                    if (time_ms >= 100)
                    {
                        time_sec++;
                        time_ms = 0;
                    }
                }
                wlaczponownie();//odpowiada za pomoca wylosowanej juz liczby uaktywnienie diody i programu po okreslonym czasie
            }
        }
        //___________________________________________________FUNKCJA3 clearning_array__________________________________________

        private void clearning_array()
        {
            reactionTimeTable.Clear();
        }
        //__________________________________________________________FUNKCJA3.1 wlaczponownie__________________________________________
        private void wlaczponownie()
        {
            if (uaktywnienie_programu == 2)
            {
                counter_timer_lightON++;
                if (counter_timer_lightON == (300 + random_number_lightON))
                {
                    port_com.Write("A");
                    uaktywnienie_programu = 1;
                    isActive_timer = true;
                    counter_timer_lightON = 0;
                    random_number_lightON = 100;
                }
            }
        }
        //_____________________________________________________________FUNKCJE voice_sound_______________________________________________________
        private void voice_sound()
        {
            var myplayer = new SoundPlayer();
            myplayer.SoundLocation = @"C:\Users\Dazzyl\Desktop\arudino fun\alarme.wav";
            myplayer.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShooterName_textbox.Text = string.Concat(ShooterName_textbox.Text.Where(char.IsLetter));
        }
        //________________________________________________________FUNKCJA open_window_____________________________________________
        private void open_window() //powrot do menu glownego
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }
        //_________________________________________________________FUNKCJA SQL_initialize__________________________________________
        private void SQL_combobox_fill() //wypelnienie comboboxa wartosciami z sql
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("select model_broni from Bronie_ASG", conn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("model_broni", typeof(string));

            dt.Load(reader);

            weapon_combobox.ValueMember = "model_broni";
            weapon_combobox.DisplayMember = "model_broni";
            weapon_combobox.DataSource = dt;

            conn.Close();
        }
        //_____________________________________________________FUNKCJA2 final_AVG__________________________________________
        private void CalculateAVG() //liczenie sredniej strzelca w domysle jako refleks wszystkich ;oczn z tabeli
        {
            back_main_menu.Enabled = true; //przyciski z poza funkcji, aby nie wyskakwil blad
            Score_button.Enabled = true; //przyciski z poza funkcji, aby nie wyskakwil blad
            uaktywnienie_programu = 0;
        }       
        //__________________________________TRYBB PICKD_________________________________
        private void tryb_picked()
        {
            gunSelected = Convert.ToString(weapon_combobox.Text);

            SqlCommand command = new SqlCommand("select typ from Bronie_ASG where model_broni='" + gunSelected + "'", conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    typ_picked = (reader["typ"].ToString());
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
        //_______________________________________________________Funkcja odswiez tabele______________________________________
        private void fill_data_gridd_walhalla()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select Nazwa_Strzelca, model_broni, Typ, minmalny_czas, sredni_czas,Data_utworzenia from Walhalla order by sredni_czas";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
       //______________________________________________________________________FUNKCJA DODAJ DO WALLHALI"______________________________________________
        private void SQL_add_wallhala() //dodanie wyniku do sqla
        {
            string shooter = ShooterName_textbox.Text;
            if (ShooterName_textbox.Text == "")
            {
                shooter = "Stormtrooper";
            }

            if (reactionTimeTable.Count < 10)
            {
                MessageBox.Show("malo wynikow :(");
            }

            if (reactionTimeTable.Count >= 10)
            {
                string value_min_converted = (reactionTimeTable.Min()/100).ToString().Replace(",", "."); //nie przyjmuje przecinkow sql
                string value_AVG_converted = (reactionTimeTable.Average()/100).ToString().Replace(",", "."); //nie przyjmuje precinkow sql

                SqlCommand command = new SqlCommand(); // na dole moze byc błąd
                command.CommandText = "Insert INTO Walhalla VALUES('" + shooter + "','" + gunSelected + "','" + typ_picked + "','" + DateTime.Now + "','" + value_min_converted + "','" + value_AVG_converted + "')";

                command.Connection = conn;
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
        }
    }
}