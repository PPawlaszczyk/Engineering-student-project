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
        int position = 0; //DO CZYSCZENIA TABLICY
       // int i;
        int czas_startu = 0; // dl odczekania ms do startu
        int czas_stopu = 0; //odczekanie ms do zakonczenia dzialania programu
        int time_sec, time_ms, Ms_value_all; // licznik czasu oraz ms_value aby umieścić w tablicy
        int counter_timer_lightON = 0;  //licznik dla zaswiecenia sie nastepnej diody
        int i_table_position = 0; // pozycja w tablicy dla czasu reakcji
        int i_position_min = 0; //pozycja w tablicy dla wartosci minimalnej 
        int i_position_avg = 0; // /pozycja w tablicy dla wartosci sredniej 
        bool isActive_timer, refleks_on;
    //    string[] XI_Tabela, YI_Tabela, ZI_Tabela; //tablica zbudowanie
        double[] reaction_time_table; // tablica z oddanych strzalow
        double wynik_ZI; //wynik roznicy z tablicy wynik biezacy i poprzedni
                         //dla testow  wylaczono     double wynik_XI; 
     //   double wynik_YI;
        int uaktywnienie_programu = 0; //odpowiada za skoki do poszczegolnych funkcji oraz aby sie uaktywnialy tylko raz w paru przypadkach
        int random_number_lightON = 100; // ustawiana na 100 aby nie wywolywala skokow do funkcji podczas dzialania programu
        double dzielnik = 0; //ile razy wykonano wpisywanie do dzielenia
        double AvgValue = 0; //finalna srednia w sekundach z wykonanymi juz  ponizej obliczeniami
        double min_final_value = 54742; //pierwsza liczba do sprawdzenia wartosci minimalnej
        double nr_first_Avg = 0; //suma wszystkich czasow w ms
        double maxValue; //maksymalna wartosc wszystkich czasow


        string read_value_PORTUSB; //odczytana wartosc z portu
        string weapon_pickd; //wartosc modelu broni z tablicy do stringa
        string typ_picked; //wartosc typu broni z tablicy do stringa
        string data_calendar; //wartosc kalendarza do stringa

        

        private void Menu_refleks_Load(object sender, EventArgs e)
        {
            //dla testow  wylaczono    XI_Tabela = new string[2500]; //wymiar tabeli
        //    YI_Tabela = new string[2500]; //wymiar tabeli
       //     ZI_Tabela = new string[2500]; //wymiar tabeli
            reaction_time_table = new double[300]; //wymiar tabeli
            time_ms = 0; //wartosc poczatkowa timera
            time_sec = 0; //wartosc poczatkowa timera
            //Ms_value_all = 0; 
            isActive_timer = false; //flag for timer ms and s 
            refleks_on = false; // flag for  math
            timer1.Stop(); //wylaczenie timera odpowiadajacego za umiesczane wartosci w tabeli i obliczania
            timer3.Start(); // timer odpowiadajacy za odczytanie wartosci z portu 
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
          //  i = -5;//reset do podstawowych wartosci pozycji tabeli
            i_position_avg = 0; //pozycja poczatkowa tablicy
            i_position_min = 0; //pozycja poczatkowa tablicy
            czas_stopu = 0;
            dzielnik = 0; //wratosc poczatkowa ile razy wykonano wpisywanie do dzielenia
            maxValue = 0;
            AvgValue = 0;
            nr_first_Avg = 0;
            min_final_value = 54742; //wartosc poczatkowa gotowa do porowynwania wartosci minimalnych
            start_button.Enabled = false;
            Score_button.Enabled = false;
            weapon_combobox.Enabled = false;
            ShooterName_textbox.Enabled = false;
            File.Delete("SHOOTER_wyniki.pdf");
            Stop_button.Enabled = true;
            tryb_picked();
            clearning_array();

            back_main_menu.Enabled = false;

            position = 0; //WARTOSC POCZATKOWA DO CZYSZCZENIA


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
            create_pdf();
            System.Diagnostics.Process.Start("SHOOTER_wyniki.pdf");
        }





        private void timer1_Tick(object sender, EventArgs e)
        {

            //  i++;
            
           
           try
            {
                string ZI_przerobiony = port_com.ReadExisting(); // oderbrane dane
                wynik_ZI = Convert.ToDouble(ZI_przerobiony); // konwersja do porownania jaka to liczba dalem double bo nie chcialo mi sie zmieniac na int
              //  label1.Text = ZI_przerobiony;
            }
            catch (Exception)
            {
                //timeout
            }
           
           // string ZI_przerobiony = port_com.ReadLine();
          //  label1.Text = ZI_przerobiony;
        //    wynik_ZI = Convert.ToDouble(ZI_przerobiony);


            //dla testow     string XI_przerobiony = read_value_PORTUSB; //odebrane dane
            /*     string YI_przerobiony = read_value_PORTUSB;
                 string ZI_przerobiony = read_value_PORTUSB;
                 int dlugosc_slowa = read_value_PORTUSB.Length; //dlugosc slowa odebranego

              //   int wynik_dla_X = dlugosc_slowa / 3; //obl dlugosci slowa aby  pokazywalo liczby tylko dla X
                 int wynik_dla_Y2 = (dlugosc_slowa / 2) - 3; //obl dlugosci slowa aby  pokazywalo liczby tylko dla Y
                 int wynik_dla_Y1 = (dlugosc_slowa / 2) - 5; //obl dlugosci slowa aby  pokazywalo liczby tylko dla Y
                 

            if (i >= 0) //warunek aby zadzialal timer
            {

                
                //..............................................................................................Pocz XI.


                /* if (XI_przerobiony.Length > 5) // zrobienie zeby wybralo tylko liczbe dla XI
                 {
                     XI_przerobiony = XI_przerobiony.Substring(1, wynik_dla_X); //wpisanie to do tego

                     XI_przerobiony = XI_przerobiony.Replace(" ", "");
                     XI_przerobiony = XI_przerobiony.Replace("Y", "");
                     XI_przerobiony = XI_przerobiony.Replace("I", "");
                     XI_przerobiony = XI_przerobiony.Replace("X", "");
                     XI_przerobiony = XI_przerobiony.Replace("=", "");


                     XI_przerobiony = XI_przerobiony.Replace(".", ",");


                 }
                 
                //dla testow  wylaczono        XI_Tabela[i] = XI_przerobiony; //sama liczba wpisana do tabeli






                //..................................................................................................koniec XI

                if (YI_przerobiony.Length > 3) // zrobienie zeby wybralo tylko liczbe dla YI
                {
                    YI_przerobiony = YI_przerobiony.Substring(wynik_dla_Y1, wynik_dla_Y2); //wpisanie to do tego


                }







                YI_przerobiony = YI_przerobiony.Replace("Y", "");
                YI_przerobiony = YI_przerobiony.Replace(" ", "");
                YI_przerobiony = YI_przerobiony.Replace("=", "");
                YI_przerobiony = YI_przerobiony.Replace("Z", "");
                YI_przerobiony = YI_przerobiony.Replace("ZI", "");
                YI_przerobiony = YI_przerobiony.Replace("I", "");

                YI_przerobiony = YI_przerobiony.Replace(".", ",");



                YI_Tabela[i] = YI_przerobiony;



                


                //......................................................... koniec YI


                if (ZI_przerobiony.Length > 12)// zrobienie zeby wybralo tylko liczbe dla ZI
                {
                    ZI_przerobiony = ZI_przerobiony.Substring(26); //wpisanie to do tego


                    ZI_przerobiony = ZI_przerobiony.Replace("Y", "");
                    ZI_przerobiony = ZI_przerobiony.Replace(" ", "");
                    ZI_przerobiony = ZI_przerobiony.Replace("=", "");
                    ZI_przerobiony = ZI_przerobiony.Replace("Z", "");
                    ZI_przerobiony = ZI_przerobiony.Replace("ZI", "");
                    ZI_przerobiony = ZI_przerobiony.Replace("I", "");
                    ZI_przerobiony = ZI_przerobiony.Replace("\n", "");



                    ZI_przerobiony = ZI_przerobiony.Replace(".", ",");
                    ZI_Tabela[i] = ZI_przerobiony;


                }




                //.............................................................................ZI koniec








                if (i >= 1)
                {
                   double DIFF_Z1 = Convert.ToDouble(ZI_Tabela[i]);
                   double DIFF_Z2 = Convert.ToDouble(ZI_Tabela[i - 1]);

                    wynik_ZI = DIFF_Z1 - DIFF_Z2;
                    wynik_ZI = Math.Abs(wynik_ZI);
                    // label2.Text = Convert.ToString(wynik_ZI);


                    //_____________________________________________YI_________________________________

                    double DIFF_Y1 = Convert.ToDouble(YI_Tabela[i]);
                    double DIFF_Y2 = Convert.ToDouble(YI_Tabela[i - 1]);
                    wynik_YI = DIFF_Y2 - DIFF_Y1;
                    wynik_YI = Math.Abs(wynik_YI);

                    //_______________________________________________XI_____________________________________

                    //dla testow  double DIFF_X1 = Convert.ToDouble(XI_Tabela[i]);
                    //dla testow = Convert.ToDouble(XI_Tabela[i - 1]);
                    //dla testow  wylaczono   wynik_XI = DIFF_X2 - DIFF_X1;
                    //dla testow  wylaczono     wynik_XI = Math.Abs(wynik_XI);


                

                }
                
            }*/

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
                    maxValue = reaction_time_table.Max();
                    maxValue = maxValue / 100;
                   
                    timer1.Stop();
                    min_value();
                    final_AVG();
                   








                }

                if ((/*dla testow  wylaczono wynik_XI >= 1 || wynik_YI >= 1 ||*/ wynik_ZI >= 1) && uaktywnienie_programu == 1) //warunek zarejestrowania strzalu
                {
                    isActive_timer = false;
                    port_com.Write("C");

                    reaction_time_table[i_table_position] = Convert.ToDouble(Ms_value_all);

                    i_table_position++;


                    Ms_value_all = 0; //wyzerowanie licznikow
                    time_sec = 0; //wyzerowanie licznikow
                    time_ms = 0; //wyzerowanie licznikow

                    Random random_func_light = new Random();
                    random_number_lightON = random_func_light.Next(1, 50);
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







        private void timer3_Tick(object sender, EventArgs e)
        {
           // read_value_PORTUSB = port_com.ReadLine(); // w innej klasie gdyz byly duze opoznienia

        }




























        //___________________________________________________FUNKCJA3 clearning_array__________________________________________



        private void clearning_array()
        {

         //   for (i_table_position = 0 ; i_table_position > 300; i_table_position++)
         while(position<300) // MUSI BYC PETLA WHILE INACZJE NIE CZYSCI
            {
                
                reaction_time_table[0 + position] = Convert.ToDouble(0);
                position++;
              

            }



        }




        //__________________________________________________________FUNKCJA3.1 wlaczponownie__________________________________________

        private void wlaczponownie()
        {
            if (uaktywnienie_programu == 2)
            {



                if (random_number_lightON <= 10)
                {
                    counter_timer_lightON++;
                    if (counter_timer_lightON == 250)
                    {
                        port_com.Write("A");
                        uaktywnienie_programu = 1;
                        isActive_timer = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;
                    }

                }
                if (random_number_lightON > 10 && random_number_lightON < 21)
                {
                    counter_timer_lightON++;
                    if (counter_timer_lightON == 300)
                    {
                        port_com.Write("A");
                        uaktywnienie_programu = 1;
                        isActive_timer = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }
                if (random_number_lightON >= 21 && random_number_lightON < 31)
                {

                    counter_timer_lightON++;
                    if (counter_timer_lightON == 350)
                    {
                        port_com.Write("A");
                        uaktywnienie_programu = 1;
                        isActive_timer = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }

                if (random_number_lightON >= 31 && random_number_lightON < 41)
                {
                    counter_timer_lightON++;
                    if (counter_timer_lightON == 400)
                    {
                        port_com.Write("A");
                        uaktywnienie_programu = 1;
                        isActive_timer = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }
                if (random_number_lightON >= 41 && random_number_lightON < 51)
                {

                    counter_timer_lightON++;
                    if (counter_timer_lightON == 450)
                    {
                        port_com.Write("A");
                        uaktywnienie_programu = 1;
                        isActive_timer = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }

            }
        }




        //_____________________________________________________________FUNKCJE voice_sound_______________________________________________________
        private void voice_sound()
        {


            var myplayer = new System.Media.SoundPlayer();
            myplayer.SoundLocation = @"C:\Users\G510\Desktop\prezentacja inzynierska_G510\15stycznia_proggram\WindowsFormsApplication3\WindowsFormsApplication3\alarme.wav";
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

            SqlConnection conn = new SqlConnection(@"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234");
            conn.Open();
            SqlCommand sc = new SqlCommand("select model_broni from bronie_ASG", conn);

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


        //________________________________________________________FUNKCJE min_value____________________________________________________________________
        private void min_value() //liczenie strzalu ktory najszybciej zestrzelil tarcze
        {

            if (i_position_min < 300)
            {
                double min_liczb = Convert.ToInt32(reaction_time_table[i_position_min]);
                i_position_min++;
                min_liczb = min_liczb / 100;

                if (min_liczb > 0)
                {


                    if (min_final_value > min_liczb)
                    {
                        min_final_value = min_liczb;

                      //  czas_stopu = 0; //nie wiem czemu bylo wpisane wiec wylaczylem moze cos spowodowac
                    }
                    else
                    {

                    }


                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }







        //_____________________________________________________FUNKCJA2 final_AVG__________________________________________
        private void final_AVG() //liczenie sredniej strzelca w domysle jako refleks wszystkich ;oczn z tabeli
        {
            if (i_position_avg < 300) //wartosc poczatkowa i_position_avg = 0 , petla odpowiada za przesuwanie miejsc w tabelii
            {
                double min_liczb_avg = Convert.ToInt32(reaction_time_table[i_position_avg]); 
                // powysza linijka odpowiada za przypisywanie do zmiennej min_liczba_avg wartosci czasu z tabeli reaction_time_table
                i_position_avg++; //inkremetacja pozycji w tabeli


                if (min_liczb_avg > 0) // wybieranie z tabeli wartosci czasow wiekszych od 0 
                {
                    dzielnik++; // liczba dokonanych pomiarow
                    nr_first_Avg = nr_first_Avg + min_liczb_avg; // tworzenie czasu ogolnego w mikrosekundach
                }
                if (i_position_avg == 300) // jesli pozycja w tabeli jest rowna 300 to wykonaj kod ponizej
                {
                    AvgValue = (nr_first_Avg / 100) / dzielnik; // tworzenie sredniej i zamiana mikrosekund na milisekundy
                    clearning_array();
                    back_main_menu.Enabled = true; //przyciski z poza funkcji, aby nie wyskakwil blad
                    Score_button.Enabled = true; //przyciski z poza funkcji, aby nie wyskakwil blad
                    AvgValue=Math.Round(AvgValue, 2);
                    
                    uaktywnienie_programu = 0;


                }
            }
        }

        //___________________________________________________________FUNKCJA2.1 create_pdf______________________________________________

        private void create_pdf()
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("SHOOTER_wyniki.pdf", FileMode.Create));
            doc.Open();


            string shooter = ShooterName_textbox.Text;
            if (ShooterName_textbox.Text == "")
            {
                shooter = "Stormtrooper";
            }

            Paragraph paragraph1 = new Paragraph(Convert.ToString("Nazwa strzelca: " + shooter));
            doc.Add(paragraph1);

             data_calendar = monthCalendar1.SelectionRange.Start.ToShortDateString();

            Paragraph paragraph2 = new Paragraph(Convert.ToString("Data: " + data_calendar));
            doc.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph(Convert.ToString("Bron: " + weapon_pickd));
            doc.Add(paragraph3);
            Paragraph paragraph4 = new Paragraph(Convert.ToString("Typ broni: " + typ_picked));
            doc.Add(paragraph4);

            Paragraph paragraph6 = new Paragraph(Convert.ToString("Wartosc maksymalna: " + maxValue));
            doc.Add(paragraph6);
            Paragraph paragraph7 = new Paragraph(Convert.ToString("Wartosc srednia: " + AvgValue));
            doc.Add(paragraph7);
            Paragraph paragraph8 = new Paragraph(Convert.ToString("Wartosc minimalna " + min_final_value));
            doc.Add(paragraph8);
            // for (int Enter = 1; Enter > 28; Enter++)
            //   {
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            //}

            Paragraph paragraph9 = new Paragraph(Convert.ToString("ShooterProRaportGenerator"));
            doc.Add(paragraph9);
            Paragraph paragraph10 = new Paragraph(Convert.ToString("Wszelkie uwagi - mail kontaktowy: Pawel.Pawlaszczyk@gmail.com"));
            doc.Add(paragraph10);
            doc.Close();

        }
        //__________________________________TRYBB PICKD_________________________________
        private void tryb_picked()
        {

            weapon_pickd = Convert.ToString(weapon_combobox.Text);

            SqlConnection conn = new SqlConnection(@"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234");
            SqlCommand command = new SqlCommand("select typ from bronie_ASG where model_broni='" + weapon_pickd + "'", conn);






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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
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

            if (dzielnik < 10)
            {
                MessageBox.Show("malo wynikow :(");
            }

            if (dzielnik >= 10)
            {
                string value_min_converted = Convert.ToString(min_final_value);
                value_min_converted = value_min_converted.Replace(",", "."); //nie przyjmuje przecinkow sql
                string value_AVG_converted = Convert.ToString(AvgValue);

                value_AVG_converted = value_AVG_converted.Replace(",", "."); //nie przyjmuje precinkow sql

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
                SqlCommand command = new SqlCommand();
                command.CommandText = "Insert INTO Walhalla VALUES('" + shooter + "','" + weapon_pickd + "','" + typ_picked + "','" + data_calendar + "','" + value_min_converted + "','" + value_AVG_converted + "')";

                command.Connection = conn;
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }



        }
    }



}


