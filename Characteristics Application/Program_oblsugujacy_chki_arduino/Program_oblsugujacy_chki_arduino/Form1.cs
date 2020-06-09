using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
namespace Program_oblsugujacy_chki_arduino
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            port_com.Open();

        }
        int i;
        int czas_startu = 0; //odczekanie sekund do startu
        int czas_stopu = 0; //odczekanie sekund do zakonczenia
        int time_sec, time_ms, Ms_value_all;
        int counter_timer_lightON = 0;
        int i_table_position = 0;
        int i_position_min = 0;
        int i_position_avg = 0;
        bool isActive, refleks_on; 
        int x = 10; //dla resetu po 20 wartosciach
        int y = 10; //dla resetu po 20 wartosciach
        int z = 10; //dla resetu po 20 wartosciach
        string[] XI_Tabela, YI_Tabela, ZI_Tabela; //tabela zbudowanie
        double[] reaction_time_table; // tabela z oddanych strzalow
        double wynik_ZI;
      //  double wynik_XI;
        double wynik_YI;
        double maxValue;
        int licznik_trafien = 0;
        int uakywnienie_programu = 0; 
        int random_number_lightON = 100;
        double dzielnik = 0; //ile razy wykonano wpisywanie do dzielenia
        double AvgValue = 0; //finalna srednia
        double test = 54742; //pierwsza liczba do sprawdzenia wartosci minimalnej
        double nr_first_Avg = 0; //suma wszystkich czasow
        double DIFF_Z1 = 0;
        double DIFF_Z2 = 0;
        string odczytana_wart;





        private void Form1_Load(object sender, EventArgs e)
        {
        //    XI_Tabela = new string[2500]; //wymiar tabeli
            YI_Tabela = new string[2500]; //wymiar tabeli
            ZI_Tabela = new string[2500]; //wymiar tabeli
            reaction_time_table = new double[300]; //wymiar tabeli
            time_ms = 0;
            time_sec = 0;
            Ms_value_all = 0; 
            isActive = false; //flag for timer
            refleks_on = false; // flag for  math
            timer1.Stop();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
                i++;

            

          //  string  XI_przerobiony = odczytana_wart; //odebrane dane
            string YI_przerobiony = odczytana_wart;
            string ZI_przerobiony = odczytana_wart;
              int   dlugosc_slowa = odczytana_wart.Length; //dlugosc slowa odebranego
            textBox1.Text = odczytana_wart;

               int wynik_dla_X = dlugosc_slowa / 3; //obl dlugosci slowa aby  pokazywalo liczby tylko dla X
            int wynik_dla_Y2 = (dlugosc_slowa / 2) - 3; //obl dlugosci slowa aby  pokazywalo liczby tylko dla Y
            int wynik_dla_Y1 = (dlugosc_slowa / 2) - 5; //obl dlugosci slowa aby  pokazywalo liczby tylko dla Y
               
            
            if (i >= 0) //warunek aby zadzialal timer
            {


                //..............................................................................................Pocz XI.


             /*   if (XI_przerobiony.Length > 5) // zrobienie zeby wybralo tylko liczbe dla XI
                {
                    XI_przerobiony = XI_przerobiony.Substring(1, wynik_dla_X); //wpisanie to do tego

                    XI_przerobiony = XI_przerobiony.Replace(" ", "");
                    XI_przerobiony = XI_przerobiony.Replace("Y", "");
                    XI_przerobiony = XI_przerobiony.Replace("I", "");
                    XI_przerobiony = XI_przerobiony.Replace("X", "");
                    XI_przerobiony = XI_przerobiony.Replace("=", "");

                    this.chart_x.Series["Czas"].Points.AddXY(i, XI_przerobiony);
                    XI_przerobiony = XI_przerobiony.Replace(".", ",");


                }

                XI_Tabela[i] = XI_przerobiony; //sama liczba wpisana do tabeli


            


                if (i == x)
                {
                    chart_x.Series["Czas"].Points.Clear();
                    x = x + 10;
                }
                */
                //..................................................................................................koniec XI

                if (YI_przerobiony.Length > 3) // zrobienie zeby wybralo tylko liczbe dla XI
                {
                    YI_przerobiony = YI_przerobiony.Substring(wynik_dla_Y1, wynik_dla_Y2); //wpisanie to do tego


                }



            



                YI_przerobiony = YI_przerobiony.Replace("Y", "");
                YI_przerobiony = YI_przerobiony.Replace(" ", "");
                YI_przerobiony = YI_przerobiony.Replace("=", "");
                YI_przerobiony = YI_przerobiony.Replace("Z", "");
                YI_przerobiony = YI_przerobiony.Replace("ZI", "");
                YI_przerobiony = YI_przerobiony.Replace("I", "");
                this.chart_y.Series["czas_y"].Points.AddXY(i, YI_przerobiony);

                YI_przerobiony = YI_przerobiony.Replace(".", ",");



                YI_Tabela[i] = YI_przerobiony;





                if (i == y)
                {
                    chart_y.Series["czas_y"].Points.Clear();
                    y = y + 10000;
                }
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


                    this.chart_z.Series["czas_z"].Points.AddXY(i, ZI_przerobiony);

                    ZI_przerobiony = ZI_przerobiony.Replace(".", ",");
                    ZI_Tabela[i] = ZI_przerobiony;


                }



                if (i == z)
                {
                    chart_z.Series["czas_z"].Points.Clear();
                    z = z + 10000;
                }

        }
                //.............................................................................ZI koniec





           


            if (i >= 1)
            {
                 DIFF_Z1 = Convert.ToDouble(ZI_Tabela[i]);
                 DIFF_Z2 = Convert.ToDouble(ZI_Tabela[i - 1]);

                wynik_ZI = DIFF_Z1 - DIFF_Z2;
                wynik_ZI = Math.Abs(wynik_ZI);
            
               
                //_____________________________________________YI_________________________________

                double DIFF_Y1 = Convert.ToDouble(YI_Tabela[i]);
                double DIFF_Y2 = Convert.ToDouble(YI_Tabela[i - 1]);
                wynik_YI = DIFF_Y2 - DIFF_Y1;
                wynik_YI = Math.Abs(wynik_YI);

                //_______________________________________________XI_____________________________________

                //double DIFF_X1 = Convert.ToDouble(XI_Tabela[i]);
               // double DIFF_X2 = Convert.ToDouble(XI_Tabela[i - 1]);
               // wynik_XI = DIFF_X2 - DIFF_X1;
               // wynik_XI = Math.Abs(wynik_XI);


                textBox8.Text = Convert.ToString(wynik_ZI);


            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            odczytana_wart = port_com.ReadExisting(); // w innej klasie gdyz byly duze opoznienia

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            refleks_on = true;
           //File.Delete("Pierwszyklient.pdf");
            i = -5;//reset do podstawowych wartosci pozycji tabeli
            i_position_avg = 0; 
            i_position_min = 0;
            czas_stopu = 0;
            z = 10; //reset do podstawowych wartosci czyszczenia wykresu
            y = 10;//reset do podstawowych wartosci czyszczenia wykresu
            x = 10;//reset do podstawowych wartosci czyszczenia wykresu
         dzielnik = 0; //ile razy wykonano wpisywanie do dzielenia
            maxValue = 0;
            AvgValue = 0;
            test = 54742;
            button1.Hide();

                
            


        }

        //__________________________________________________________TIMER2_______________________________________
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (refleks_on) // czas na przygotowanie sie strzelca
            {
                      

                czas_startu++;
                if (czas_startu == 1000) //2000
                {
                    refleks_on = false;
                    port_com.Write("A");
                    isActive = true;
                    czas_startu = 0;
                    uakywnienie_programu = 1;

                }
                if (czas_startu == 500) //1500
                {
                    port_com.Write("B");


                }
            }


            if (refleks_on == false) //dzialanie programu strzelca
            {
                czas_stopu++;
                textBox3.Text = Convert.ToString(czas_stopu);

                if (czas_stopu == 3000 || uakywnienie_programu == 3) //3 minuty 180000
                {
                    button1.Show();
                    uakywnienie_programu = 3;
                    port_com.Write("C");
                    Ms_value_all = 0;
                    time_sec = 0;
                    time_ms = 0;

                    isActive = false;
                    maxValue = reaction_time_table.Max();
                    maxValue = maxValue / 100;
                    
                    timer1.Stop();
                 





                }

                if ((/*wynik_XI*>= 1 ||*/ wynik_YI >= 1 || wynik_ZI >= 1) && uakywnienie_programu == 1) //warunek zarejestrowania strzalu
                {
                    isActive = false;
                    licznik_trafien++;
                    port_com.Write("C");

                    reaction_time_table[i_table_position] = Convert.ToDouble(Ms_value_all);

                    i_table_position++;


                    Ms_value_all = 0;
                    time_sec = 0;
                    time_ms = 0;

                    Random random_func_light = new Random();
                    random_number_lightON = random_func_light.Next(1, 50);
                    uakywnienie_programu = 2;
                    textBox9.Text = Convert.ToString(random_number_lightON);

                }

                if (isActive) //liczenie czasu po zaswieceniu sie diody 
                {


                    Ms_value_all++;
                    time_ms++;
                    if (time_ms >= 100)
                    {
                        time_sec++;
                        time_ms = 0;


                    }
                    label1.Text = Convert.ToString(time_sec);
                    label2.Text = Convert.ToString(time_ms);

                }
                wlaczponownie();


            }
        }














        




        //___________________________________________________________________________FUNKCJA3.1__________________________________________

        private void wlaczponownie()
        {
            if ( uakywnienie_programu == 2)
            {
                
               

                if (random_number_lightON <= 10)
                {
                    counter_timer_lightON++;
                    if ( counter_timer_lightON == 100)
                    {
                        port_com.Write("A");
                        uakywnienie_programu = 1;
                        isActive = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;
                    }

                }
                if (random_number_lightON > 10 && random_number_lightON < 21)
                {
                    counter_timer_lightON++;
                    if (counter_timer_lightON == 200)
                    {
                        port_com.Write("A");
                        uakywnienie_programu = 1;
                        isActive = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }
                if (random_number_lightON >=21 && random_number_lightON < 31)
                {

                    counter_timer_lightON++;
                    if (counter_timer_lightON == 300)
                    {
                        port_com.Write("A");
                        uakywnienie_programu = 1;
                        isActive = true;
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
                        uakywnienie_programu = 1;
                        isActive = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }
                if (random_number_lightON >= 41 && random_number_lightON < 51)
                {

                    counter_timer_lightON++;
                    if (counter_timer_lightON == 500)
                    {
                        port_com.Write("A");
                        uakywnienie_programu = 1;
                        isActive = true;
                        counter_timer_lightON = 0;
                        random_number_lightON = 100;

                    }
                }

            }
        }
    }
}