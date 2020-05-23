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
using System.Globalization;
using System.IO;

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
            edit_qus_user_tab.Enabled = false;

            int y = pr_cod_user_combo.Items.Count;
            for (int i = 0; i < y; i++)
            {
                pr_cod_user_combo.Items.RemoveAt(0);
            }
            pr_cod_user_combo.Enabled = false;

            int x = test_num_user_combo.Items.Count;
            for (int i = 0; i < x; i++)
            {
                test_num_user_combo.Items.RemoveAt(0);
            }
            test_num_user_combo.Enabled = false;

            test_time_user_datepicker.Text="";
            test_time_user_datepicker.Enabled = false;
            user_answ_user_box.Text = "";
            user_answ_user_box.Enabled = false;
            save_edit_user_btn.Enabled = false;

            int q = pr_cod_test_combo.Items.Count;
            for (int i = 0; i < q; i++)
            {
                pr_cod_test_combo.Items.RemoveAt(0);
            }
            pr_cod_test_combo.Enabled = false;

            int e = test_num_test_combo.Items.Count;
            for (int i = 0; i < e; i++)
            {
                test_num_test_combo.Items.RemoveAt(0);
            }
            test_num_test_combo.Enabled = false;

            test_time_test_datepicker.Value.ToLocalTime();
            test_time_test_datepicker.Enabled = false;
            user_answ_test_box.Text = "";
            user_answ_test_box.Enabled = false;
            save_edit_test_btn.Enabled = false;
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
            deisable_all();

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

        private void edit_user_test_btn_Click(object sender, EventArgs e)
        {
            deisable_all();
            edit_qus_user_tab.Enabled = true;

        }
        private int count_test;
        private int count_user;
        private void uesr_tab_Click(object sender, EventArgs e)
        {
            int j = pr_cod_user_combo.Items.Count;
            for(int i = 0; i < j; i++)
            {
                pr_cod_user_combo.Items.RemoveAt(0);
            }
            pr_cod_user_combo.Enabled = true;

            int x = test_num_user_combo.Items.Count;
            for (int i = 0; i < x; i++)
            {
                test_num_user_combo.Items.RemoveAt(0);
            }
            test_num_user_combo.Enabled = false;
            test_time_user_datepicker.Text="";
            test_time_user_datepicker.Enabled = false;
            user_answ_user_box.Text = "";
            user_answ_user_box.Enabled = false;
            save_edit_user_btn.Enabled = false;



            DBC.count_user();
            count_user = Convert.ToInt32(DBC.message);
            for (int i = 0; i < count_user; i++)
            {
                DBC.name_user(i);
                pr_cod_user_combo.Items.Add(DBC.message);
            }
            pr_cod_user_combo.Enabled = true;
        }

        private void qus_tab_Click(object sender, EventArgs e)
        {
            int j = pr_cod_test_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                pr_cod_test_combo.Items.RemoveAt(0);
            }
            pr_cod_test_combo.Enabled = false;

            int x = test_num_test_combo.Items.Count;
            for (int i = 0; i < x; i++)
            {
                test_num_test_combo.Items.RemoveAt(0);
            }
            test_num_test_combo.Enabled = true;

            test_time_test_datepicker.Value.ToLocalTime();
            test_time_test_datepicker.Enabled = false;
            user_answ_test_box.Text = "";
            user_answ_test_box.Enabled = false;
            save_edit_test_btn.Enabled = false;

            DBC.count_test_all();
            count_test = Convert.ToInt32(DBC.message);
            for (int i = 0; i < count_test; i++)
            {
                DBC.test_name(i);
                test_num_test_combo.Items.Add(DBC.tests_name);
            }
            test_num_test_combo.Enabled = true;
        }

        private void pr_cod_user_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = test_num_user_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                test_num_user_combo.Items.RemoveAt(0);
            }

            timer_get_test_user.Enabled = true;
        }

        private void timer_get_test_user_Tick(object sender, EventArgs e)
        {
            timer_get_test_user.Enabled = false;
            //DBC.id_user(pr_cod_user_combo.Text);
            DBC.sync_test_user(Convert.ToInt32(pr_cod_user_combo.SelectedItem.ToString()));
            DBC.sync_test_user_name();


            String[] test_list = File.ReadAllText("temp").ToString().Split('%');
            for (int i = 0; i < Convert.ToInt32(test_list.Length.ToString()) - 1; i++)
            {
                test_num_user_combo.Items.Add(test_list[i]);
            }

            File.WriteAllText("temp", "");
            test_num_user_combo.Enabled = true;
        }

        private void test_num_user_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBC.id_test(test_num_user_combo.SelectedItem.ToString());
            DBC.test_user_answr(Convert.ToInt32(DBC.message), Convert.ToInt32(pr_cod_user_combo.SelectedItem.ToString()));
            test_time_user_datepicker.Text = DBC.date_answer.ToString();
            user_answ_user_box.Text = DBC.answer;
            test_num_user_combo.Enabled = false;
            pr_cod_user_combo.Enabled = false;
            test_time_user_datepicker.Enabled = true;
            user_answ_user_box.Enabled = true;
            save_edit_user_btn.Enabled = true;
            
        }

        private void save_edit_user_btn_Click(object sender, EventArgs e)
        {
            DBC.id_test(test_num_user_combo.SelectedItem.ToString());
            DBC.edit_tests_users(Convert.ToInt32(DBC.message), Convert.ToInt32(pr_cod_user_combo.SelectedItem.ToString()), test_time_user_datepicker.Text, user_answ_user_box.Text);
            MessageBox.Show(DBC.message);
            deisable_all();
        }

        private void test_num_test_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = pr_cod_test_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                pr_cod_test_combo.Items.RemoveAt(0);
            }

            timer_get_user_test.Enabled = true;
        }

        private void timer_get_user_test_Tick(object sender, EventArgs e)
        {
            timer_get_user_test.Enabled = false;
            DBC.id_test(test_num_test_combo.Text);
            DBC.sync_user_test(Convert.ToInt32(DBC.message));
            DBC.sync_user_test_name();


            String[] user_list = File.ReadAllText("temp").ToString().Split('%');
            for (int i = 0; i < Convert.ToInt32(user_list.Length.ToString()) - 1; i++)
            {
                pr_cod_test_combo.Items.Add(user_list[i]);
            }

            File.WriteAllText("temp", "");
            pr_cod_test_combo.Enabled = true;
        }

        private void pr_cod_test_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBC.id_test(test_num_test_combo.SelectedItem.ToString());
            DBC.test_user_answr(Convert.ToInt32(DBC.message), Convert.ToInt32(pr_cod_test_combo.SelectedItem.ToString()));
            test_time_test_datepicker.Text = DBC.date_answer.ToString();
            user_answ_test_box.Text = DBC.answer;
            test_num_test_combo.Enabled = false;
            pr_cod_test_combo.Enabled = false;
            test_time_test_datepicker.Enabled = true;
            user_answ_test_box.Enabled = true;
            save_edit_test_btn.Enabled = true;
        }

        private void save_edit_test_btn_Click(object sender, EventArgs e)
        {
            DBC.id_test(test_num_test_combo.SelectedItem.ToString());
            DBC.edit_tests_users(Convert.ToInt32(DBC.message), Convert.ToInt32(pr_cod_test_combo.SelectedItem.ToString()), test_time_test_datepicker.Text, user_answ_test_box.Text);
            MessageBox.Show(DBC.message);
            deisable_all();
        }
    }
}
