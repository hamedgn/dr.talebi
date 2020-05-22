using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dr
{
    public partial class admin : Form
    {

        private db DBC;
        public admin()
        {
            InitializeComponent();
            DBC = new db();
        }

        private void save_machine_btn_Click(object sender, EventArgs e)
        {
            DBC.insert_machine(machine_name_box.Text);
            MessageBox.Show(DBC.message);
            deisable_all();
        }

        private void create_user_Click(object sender, EventArgs e)
        {
            deisable_all();
            prs_cod_box.Enabled = true;
            password_box.Enabled = true;
            premission_level_combo.Enabled = true;
            save_user_create_btn.Enabled = true;
        }
        public void deisable_all()
        {
            prs_cod_box.Enabled = false;
            prs_cod_box.Text = "";
            password_box.Enabled = false;
            password_box.Text = "";
            premission_level_combo.Enabled = false;
            save_user_create_btn.Enabled = false;
            dep_id_box.Enabled = false;
            dep_id_box.Text = "";
            dep_name_box.Enabled = false;
            dep_name_box.Text = "";
            save_dep_btn.Enabled = false;
            machine_id_box.Enabled = false;
            machine_id_box.Text = "";
            machine_name_box.Enabled = false;
            machine_name_box.Text = "";
            save_machine_btn.Enabled = false;
            test_name_box.Enabled = false;
            test_name_box.Text = "";
            test_text_box.Enabled = false;
            test_text_box.Text = "";
            test_machine_combo.Enabled = false;
            int j = test_machine_combo.Items.Count;
            for(int i = 0; i < j; i++)
            {
                test_machine_combo.Items.RemoveAt(0);
            }
            save_test_btn.Enabled = false;
            dep_combo.Enabled = false;
            int b = dep_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                dep_combo.Items.RemoveAt(0);
            }
            machine_combo.Enabled = false;
            int c = machine_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                machine_combo.Items.RemoveAt(0);
            }
            save_sync_mach_dep_btn.Enabled = false;
        }

        private void save_user_create_btn_Click(object sender, EventArgs e)
        {
            int j = 0;
            if (premission_level_combo.SelectedItem.ToString()== "تایید نشده")
            {
                j = 0;
            }
            else if (premission_level_combo.SelectedItem.ToString() == "پرسنل")
            {
                j = 1;
            }
            else if (premission_level_combo.SelectedItem.ToString() == "ادمین")
            {
                j = 999;
            }
            DBC.insert_users(Convert.ToInt32(prs_cod_box.Text), Convert.ToInt32(password_box.Text), j);
            deisable_all();
            MessageBox.Show(DBC.message);
        }

        private void create_dep_Click(object sender, EventArgs e)
        {
            deisable_all();
            dep_id_box.Enabled = true;
            
            dep_name_box.Enabled = true;
            
            save_dep_btn.Enabled = true;
            DBC.count_departman();
            dep_id_box.Text = DBC.message;
        }

        private void dep_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void prs_cod_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(prs_cod_box.Text, "[^0-9]"))
            {

                prs_cod_box.Text = prs_cod_box.Text.Remove(prs_cod_box.Text.Length - 1);
            }
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(password_box.Text, "[^0-9]"))
            {

                password_box.Text = password_box.Text.Remove(password_box.Text.Length - 1);
            }
        }

        private void save_dep_btn_Click(object sender, EventArgs e)
        {
            DBC.insert_departman(dep_name_box.Text);
            MessageBox.Show(DBC.message);
            deisable_all();
        }

        private void create_machine_Click(object sender, EventArgs e)
        {
            deisable_all();
            machine_id_box.Enabled = true;
           
            machine_name_box.Enabled = true;
            
            save_machine_btn.Enabled = true;
            DBC.count_machine();
            machine_id_box.Text = DBC.message;
        }
        
        private void create_test_Click(object sender, EventArgs e)
        {
            deisable_all();
            test_name_box.Enabled = true;
            
            test_text_box.Enabled = true;
            
           // test_machine_combo.Enabled = true;
            
            save_test_btn.Enabled = true;

            DBC.count_machine();
            count_machine = Convert.ToInt32(DBC.message);
            for (int i = 0; i < count_machine; i++)
            {
                DBC.name_machine(i);
                test_machine_combo.Items.Add(DBC.message);
            }
            test_machine_combo.Enabled = true;
        }

        private void save_test_btn_Click(object sender, EventArgs e)
        {
            DBC.id_machin(test_machine_combo.SelectedItem.ToString());
            DBC.insert_test(test_name_box.Text,Convert.ToInt32(DBC.message),test_text_box.Text);
            MessageBox.Show(DBC.message);
            deisable_all();
        }
        private int count_departemant;
        private int count_machine;
        private void connect_mach_dep_Click(object sender, EventArgs e)
        {
            

            DBC.count_departman();
            count_departemant = Convert.ToInt32(DBC.message);
            for (int i = 0; i < count_departemant; i++)
            {
                DBC.name_departman(i);
                dep_combo.Items.Add(DBC.message);
            }

            DBC.count_machine();
            count_machine = Convert.ToInt32(DBC.message);
            for (int i = 0; i < count_machine; i++)
            {
                DBC.name_machine(i);
                machine_combo.Items.Add(DBC.message);
            }

            dep_combo.Enabled = true;

            machine_combo.Enabled = true;

            save_sync_mach_dep_btn.Enabled = true;
        }

        private void save_sync_mach_dep_btn_Click(object sender, EventArgs e)
        {
            DBC.id_departman(dep_combo.SelectedItem.ToString());
            int dep_id = Convert.ToInt32(DBC.message);
            DBC.id_machin(machine_combo.SelectedItem.ToString());
            int mach_id = Convert.ToInt32(DBC.message);
            DBC.message = "";
            DBC.check_sync(dep_id, mach_id);
            if (DBC.message == "")
            {
                DBC.insert_sync_dep_mach(dep_id, mach_id);
                MessageBox.Show(DBC.message);
                deisable_all();
            }
            else
            {
                MessageBox.Show("قبلا تعریف شده");
            }
            
        }
    }
}
