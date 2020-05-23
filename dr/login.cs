using System;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dr
{
    public partial class login : Form
    {
        
        private db DBC;
        public login()
        {
            InitializeComponent();
            DBC = new db();
            System.Net.WebClient wc1 = new System.Net.WebClient();
            string webData1 = wc1.DownloadString("http://" + DBC.server + "/t1.php");
            date_lb.Text = webData1;

            
           // date_lb.Text = persiandate(Convert.ToDateTime(date_lb.Text));
        }
        string persiandate(DateTime dateTime1)
        {
            PersianCalendar persianCalendar1 = new PersianCalendar();
            return string.Format(@"{0}-{1}-{2}",
                 persianCalendar1.GetYear(dateTime1),
                 persianCalendar1.GetMonth(dateTime1),
                 persianCalendar1.GetDayOfMonth(dateTime1));
        }
        private void pr_cod_lb_Click(object sender, EventArgs e)
        {

        }

        private void passcod_lb_Click(object sender, EventArgs e)
        {

        }

        private void choose_dp_DUD_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            DBC.check_user_pass(pr_cod_box.Text, passcod_box.Text);
            if (DBC.message== "successfuly")
            {
                DBC.check_user_permission(pr_cod_box.Text);
                DBC.lastlogin(Convert.ToInt32(pr_cod_box.Text), date_lb.Text + " " + time_lb.Text);
                
                MessageBox.Show("با موفقیت وارد شدید");
                if (DBC.permission == "0")
                {
                    MessageBox.Show("شماه هنوز تایید نشدید");
                }
                else if (DBC.permission == "-1")
                {
                    MessageBox.Show("wrong user pass");
                }
                else if (DBC.permission == "1")
                {
                    MessageBox.Show("سمت: پرسنل");
                    timer_dep_list.Enabled = true;
                    choose_machin_combo.Enabled = true;
                    enter_btn.Enabled = false;
                    pr_cod_box.Enabled = false;
                    passcod_box.Enabled = false;
                    login_to_test.Enabled = true;
                }
                else if (DBC.permission == "999")
                {
                    MessageBox.Show("admin");
                    admin NewForm = new admin();
                    NewForm.Show();
                    this.Dispose(false);
                }
                
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
            }
            
            
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Net.WebClient wc2 = new System.Net.WebClient();
            string webData2 = wc2.DownloadString("http://" + DBC.server + "/t2.php");
            time_lb.Text = webData2;
        }

        private void choose_dp_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = choose_machin_combo.Items.Count;
            for(int i= 0; i < j; i++)
            {
                choose_machin_combo.Items.RemoveAt(0);
            }
            
            timer_get_machine.Enabled = true;
        }
        private int count_departemant;
       

        private void timer_dep_list_Tick(object sender, EventArgs e)
        {
            timer_dep_list.Enabled = false;
            DBC.count_departman();
            count_departemant = Convert.ToInt32(DBC.message);
            for (int i = 0; i < count_departemant; i++)
            {
                DBC.name_departman(i);
                choose_dp_combo.Items.Add(DBC.message);
            }
            choose_dp_combo.Enabled = true;
        }

        private void timer_get_machine_Tick(object sender, EventArgs e)
        {
            timer_get_machine.Enabled = false;
            DBC.id_departman(choose_dp_combo.Text);
            DBC.sync_departman(Convert.ToInt32(DBC.message));
            DBC.sync_dep_mach_name();

         
            String[] machine_list = File.ReadAllText("temp").ToString().Split('%');
            for (int i = 0; i < Convert.ToInt32(machine_list.Length.ToString()) - 1; i++)
            {
                choose_machin_combo.Items.Add(machine_list[i]);
            }

            File.WriteAllText("temp","");
        }

        private void pr_cod_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pr_cod_box.Text, "[^0-9]"))
            {
                
                pr_cod_box.Text = pr_cod_box.Text.Remove(pr_cod_box.Text.Length - 1);
            }
        }

        private void passcod_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(passcod_box.Text, "[^0-9]"))
            {

                passcod_box.Text = passcod_box.Text.Remove(passcod_box.Text.Length - 1);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void login_to_test_Click(object sender, EventArgs e)
        {
            login_to_test.Enabled = false;
            choose_dp_combo.Enabled = false;
            choose_machin_combo.Enabled = false;
            choose_tests_combo.Enabled = true;
            int j = choose_tests_combo.Items.Count;
            for ( int i=0 ; i <j ; i++)
            {
                choose_tests_combo.Items.RemoveAt(0);
            }
            answ_textbox.Text = "";
            qus_textbox.Text = "";
            answ_textbox.Enabled = false;

            // timer_get_machine.Enabled = false;
            DBC.id_machin(choose_machin_combo.Text);
            DBC.test_id_to_list(Convert.ToInt32(DBC.message));
            DBC.tests_name_sync();
            

            String[] testlist = File.ReadAllText("temp").ToString().Split('%');
            for (int i = 0; i < Convert.ToInt32(testlist.Length.ToString()) - 1; i++)
            {
                choose_tests_combo.Items.Add(testlist[i]);
            }

            File.WriteAllText("temp", "");
            
        }

        private void tests_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBC.id_test(choose_tests_combo.Text);
            DBC.test_name(Convert.ToInt32(DBC.message));
            int j = Convert.ToInt32(DBC.message);
            DBC.message = "";
            DBC.search_test(j, Convert.ToInt32(pr_cod_box.Text));
            if(DBC.message == "")
            {
                qus_textbox.Text = DBC.tests_qus;
                choose_tests_combo.Enabled = false;
                answ_textbox.Enabled = true;
                answ_textbox.Text = "";
                save_qus_btn.Enabled = true;
                change_machine_btn.Enabled = true;
                save_exit_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("شما قبلا این تست را داده اید");
                change_machine_btn.Enabled = true;
                save_exit_btn.Enabled = true;
            }
            
        }

        private void save_qus_btn_Click(object sender, EventArgs e)
        {

            DBC.id_test(choose_tests_combo.Text);
            
            DBC.insert_tests_users(Convert.ToInt32(DBC.message),Convert.ToInt32(pr_cod_box.Text),date_lb.Text+" "+time_lb.Text,answ_textbox.Text);
            MessageBox.Show(DBC.message);
            login_to_test_Click(sender, e);
        }

        private void answ_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void change_machine_btn_Click(object sender, EventArgs e)
        {
            choose_machin_combo.Enabled = true;
            login_to_test.Enabled = true;
            choose_tests_combo.Enabled = false;
            int j = choose_tests_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                choose_tests_combo.Items.RemoveAt(0);
            }
            answ_textbox.Text = "";
            qus_textbox.Text = "";
            answ_textbox.Enabled = false;
            save_qus_btn.Enabled = false;
            save_exit_btn.Enabled = false;
        }

        private void save_exit_btn_Click(object sender, EventArgs e)
        {
            if (answ_textbox.Text !="")
            {
                save_qus_btn_Click(sender, e);
            }
            else
            {

            }
            login NewForm = new login();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
