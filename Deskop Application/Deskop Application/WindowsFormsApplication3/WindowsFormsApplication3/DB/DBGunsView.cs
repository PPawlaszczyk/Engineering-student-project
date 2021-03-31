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
            BindList(lstGuns);

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
            foreach(var item in lstGuns)
            {
                if(lstGuns.Select(x => x.Model == selectedItem.Model)!=null)
                {
                    item.Model = txbModel.Text;
                    item.Capacity = int.Parse(txbCapacity.Text);
                    item.FPS = int.Parse(txbFPS.Text);
                    item.PowerSource = txbPowerSource.Text;
                    item.Type = txbType.Text;
                    BindList(lstGuns);
                    break;
                }
            }
        }   
        private void lbxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxModels.SelectedItem != null)
            {
                Gun tmprGun = (Gun)lbxModels.SelectedItem;
                selectedItem = lstGuns.FirstOrDefault(x => x.ID == tmprGun.ID);
                txbType.Text = selectedItem.Type;
                txbCapacity.Text = $"{selectedItem.Capacity}";
                txbFPS.Text = $"{selectedItem.FPS}";
                txbModel.Text = selectedItem.Model;
                txbPowerSource.Text = selectedItem.PowerSource;
            }
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
            if (lstGuns.Count() > 0) lstGuns.Remove(selectedItem);
            if(lstGuns.Count() ==0) ClearTextboxes();
            
            if (lbxModels.SelectedIndex>0) lbxModels.SelectedIndex = lbxModels.SelectedIndex - 1;
            BindList(lstGuns);
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            var tmplist = new List<Gun>();
            if (lbxModels.Items.Count > 0) lbxModels.SelectedItems.Clear();
            foreach (var item in lstGuns)
            {
                if (item.Model.ToLower().Contains(txbSearch.Text)) tmplist.Add(item);
            }
            BindList(tmplist);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ModesView open_menu = new ModesView();
            open_menu.Show();
            this.Close();
        }

        void ClearTextboxes()
        {
            selectedItem.PowerSource = "";
            selectedItem.Type = "";
            selectedItem.FPS = null;
            selectedItem.Model = "";
            selectedItem.Capacity = null;
            txbModel.Clear();
            txbCapacity.Clear();
            txbFPS.Clear();
            txbModel.Clear();
            txbPowerSource.Clear();
            txbType.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstGuns.Add(new Gun { Model = "--Dodaj--" });
            BindList(lstGuns);
        }

        private void BindList(List<Gun> lstInput)
        {
            lbxModels.DataSource = new BindingList<Gun>(lstInput);
            lbxModels.DisplayMember = "Model";
            lbxModels.ValueMember = "ID";
            lbxModels.ValueMember = "Type";
            lbxModels.ValueMember = "Model";
            lbxModels.ValueMember = "FPS";
            lbxModels.ValueMember = "Capacity";
            lbxModels.ValueMember = "PowerSource";
        }
    }
}
