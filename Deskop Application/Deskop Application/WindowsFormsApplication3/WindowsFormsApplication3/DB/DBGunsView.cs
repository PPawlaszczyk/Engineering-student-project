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
using System.Data.SQLite;

namespace ShootingRange
{
    public partial class DBGunsView : Form
    {
        List<Gun> lstGuns;
        Gun selectedItem = new Gun();

        public DBGunsView()
        {
            InitializeComponent();
            
            lstGuns = DBSelectGuns();     
            lbxModels.DataSource = new BindingList<string>(lstGuns.Select(x=> x.Model).ToList());
            lbxModels.DisplayMember = "Model";
        }
        private List<Gun> DBSelectGuns()
        {
            var lst = new List<Gun>();
            using (SQLiteConnection cn = new SQLiteConnection("Data source=database.sqliteASG"))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select * from ASGGUNS", cn))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            lst.Add(new Gun
                            {
                                ID = (long)rd["ID"],
                                Model = (string)rd["Model"],
                                Type = (string)rd["Type"],
                                FPS = (short)rd["FPS"],
                                Capacity = (short)rd["Capacity"],
                                PowerSource = (string)rd["PowerSource"]
                            });
                        }
                    }
                }
            }
            return lst;
        }
           
              
        
        private void modyfikuj_przycisk_Click(object sender, EventArgs e)
        {

            //if (model_broni_przenies.Text == "" || FPS_broni_przenies.Text == "" || Pojemnosc_broni_przenies.Text == "" || typ_broni_przenies.Text == "" || naped_broni_przenies.Text == "")
            //{
            //    MessageBox.Show("Wypełnij okienka");
            //}
            //else
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = @"server=G510-Komputer\dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = conn;
            //    command.CommandText = "delete from bronie_ASG where model_broni = '" + model_broni.Text + "'" + "Insert INTO Bronie_ASG VALUES('" + model_broni_przenies.Text + "','" + typ_broni_przenies.Text + "','" + FPS_broni_przenies.Text + "','" + Pojemnosc_broni_przenies.Text + "','" + naped_broni_przenies.Text + " ')";
            //    DataTable data = new DataTable();
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    adapter.Fill(data);
            //    MessageBox.Show("Zmodyfikowano!");
            //    DBGunsView open_modyf_bron = new DBGunsView();
            //    open_modyf_bron.Show();
            //    this.Close();
            //}
        }   
        private void lbxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = lstGuns.FirstOrDefault(x => x.Model == lbxModels.SelectedItem.ToString());         
            txbType.Text = selectedItem.Type;
            txbCapacity.Text = $"{selectedItem.Capacity}";
            txbFPS.Text = $"{selectedItem.FPS}";
            txbModel.Text = selectedItem.Model;
            txbPowerSource.Text = selectedItem.PowerSource;
        }
        private void txbModel_TextChanged(object sender, EventArgs e)
        {
            if (txbModel.Text != selectedItem.Model) txbModel.BackColor = Color.LightCoral;
            else txbModel.BackColor = Color.White;
        }
        private void txbPowerSource_TextChanged(object sender, EventArgs e)
        {
            if (txbPowerSource.Text != selectedItem.PowerSource)txbPowerSource.BackColor = Color.LightCoral;
            else txbPowerSource.BackColor = Color.White ;
        }
        private void txbFPS_TextChanged(object sender, EventArgs e)
        {
            if (txbFPS.Text != $"{selectedItem.FPS}") txbFPS.BackColor = Color.LightCoral;
            else txbFPS.BackColor = Color.White;
        }
        private void txbCapacity_TextChanged(object sender, EventArgs e)
        {
            if (txbCapacity.Text != $"{selectedItem.Capacity}") txbCapacity.BackColor = Color.LightCoral;
            else txbCapacity.BackColor = Color.White;
        }
        private void txbType_TextChanged(object sender, EventArgs e)
        {
            if (txbType.Text != selectedItem.Type) txbType.BackColor = Color.LightCoral;
            else txbType.BackColor = Color.White;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstGuns.Remove(selectedItem);
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ModesView open_menu = new ModesView();
            open_menu.Show();
            this.Close();
        }
    }
}
