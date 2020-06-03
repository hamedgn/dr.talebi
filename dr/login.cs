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
            fildclear();
        }

        private void tests_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBC.id_test(choose_tests_combo.Text);
            DBC.test_name(Convert.ToInt32(DBC.message));
            int j = Convert.ToInt32(DBC.message);
            DBC.message = "";
            
                en_fild(DBC.no_f);
                //qus_textbox.Text = DBC.tests_qus;
                test1_lb.Text = DBC.f1;
                test2_lb.Text = DBC.f2;
                test3_lb.Text = DBC.f3;
                test4_lb.Text = DBC.f4;
                test5_lb.Text = DBC.f5;
                test6_lb.Text = DBC.f6;
                test7_lb.Text = DBC.f7;
                test8_lb.Text = DBC.f8;
                test9_lb.Text = DBC.f9;
                test10_lb.Text = DBC.f10;
                test11_lb.Text = DBC.f11;
                test12_lb.Text = DBC.f12;
                test13_lb.Text = DBC.f13;
                test14_lb.Text = DBC.f14;
                test15_lb.Text = DBC.f15;
                test16_lb.Text = DBC.f16;
                test17_lb.Text = DBC.f17;
                test18_lb.Text = DBC.f18;
                test19_lb.Text = DBC.f19;
                test20_lb.Text = DBC.f20;

                choose_tests_combo.Enabled = false;
            answ_textbox.Enabled = true;
            answ_textbox.Text = "";
                save_qus_btn.Enabled = true;
                change_machine_btn.Enabled = true;
                save_exit_btn.Enabled = true;
            
            
        }

        private void en_fild(int no_f)
        {
            int i = 0;
            if (no_f > i)
            {
                test1_lb.Visible = true;
                test1_lb.Enabled = true;
                test1_box.Visible = true;
                test1_box.Enabled = true;
                i++;
                if (no_f > i)
                {
                    test2_lb.Visible = true;
                    test2_lb.Enabled = true;
                    test2_box.Visible = true;
                    test2_box.Enabled = true;
                    i++;
                    if (no_f > i)
                    {
                        test3_lb.Visible = true;
                        test3_lb.Enabled = true;
                        test3_box.Visible = true;
                        test3_box.Enabled = true;
                        i++;
                        if (no_f > i)
                        {
                            test4_lb.Visible = true;
                            test4_lb.Enabled = true;
                            test4_box.Visible = true;
                            test4_box.Enabled = true;
                            i++;
                            if (no_f > i)
                            {
                                test5_lb.Visible = true;
                                test5_lb.Enabled = true;
                                test5_box.Visible = true;
                                test5_box.Enabled = true;
                                i++;
                                if (no_f > i)
                                {
                                    test6_lb.Visible = true;
                                    test6_lb.Enabled = true;
                                    test6_box.Visible = true;
                                    test6_box.Enabled = true;
                                    i++;
                                    if (no_f > i)
                                    {
                                        test7_lb.Visible = true;
                                        test7_lb.Enabled = true;
                                        test7_box.Visible = true;
                                        test7_box.Enabled = true;
                                        i++;
                                        if (no_f > i)
                                        {
                                            test8_lb.Visible = true;
                                            test8_lb.Enabled = true;
                                            test8_box.Visible = true;
                                            test8_box.Enabled = true;
                                            i++;
                                            if (no_f > i)
                                            {
                                                test9_lb.Visible = true;
                                                test9_lb.Enabled = true;
                                                test9_box.Visible = true;
                                                test9_box.Enabled = true;
                                                i++;
                                              
                                                    if (no_f > i)
                                                    {
                                                        test10_lb.Visible = true;
                                                        test10_lb.Enabled = true;
                                                        test10_box.Visible = true;
                                                        test10_box.Enabled = true;
                                                        i++;
                                                        if (no_f > i)
                                                        {
                                                            test11_lb.Visible = true;
                                                            test11_lb.Enabled = true;
                                                            test11_box.Visible = true;
                                                            test11_box.Enabled = true;
                                                            i++;
                                                            if (no_f > i)
                                                            {
                                                                test12_lb.Visible = true;
                                                                test12_lb.Enabled = true;
                                                                test12_box.Visible = true;
                                                                test12_box.Enabled = true;
                                                                i++;
                                                                if (no_f > i)
                                                                {
                                                                    test13_lb.Visible = true;
                                                                    test13_lb.Enabled = true;
                                                                    test13_box.Visible = true;
                                                                    test13_box.Enabled = true;
                                                                    i++;
                                                                    if (no_f > i)
                                                                    {
                                                                        test14_lb.Visible = true;
                                                                        test14_lb.Enabled = true;
                                                                        test14_box.Visible = true;
                                                                        test14_box.Enabled = true;
                                                                        i++;
                                                                        if (no_f > i)
                                                                        {
                                                                            test15_lb.Visible = true;
                                                                            test15_lb.Enabled = true;
                                                                            test15_box.Visible = true;
                                                                            test15_box.Enabled = true;
                                                                            i++;
                                                                            if (no_f > i)
                                                                            {
                                                                                test16_lb.Visible = true;
                                                                                test16_lb.Enabled = true;
                                                                                test16_box.Visible = true;
                                                                                test16_box.Enabled = true;
                                                                                i++;
                                                                                if (no_f > i)
                                                                                {
                                                                                    test17_lb.Visible = true;
                                                                                    test17_lb.Enabled = true;
                                                                                    test17_box.Visible = true;
                                                                                    test17_box.Enabled = true;
                                                                                    i++;
                                                                                    if (no_f > i)
                                                                                    {
                                                                                        test18_lb.Visible = true;
                                                                                        test18_lb.Enabled = true;
                                                                                        test18_box.Visible = true;
                                                                                        test18_box.Enabled = true;
                                                                                        i++;
                                                                                        if (no_f > i)
                                                                                        {
                                                                                            test19_lb.Visible = true;
                                                                                            test19_lb.Enabled = true;
                                                                                            test19_box.Visible = true;
                                                                                            test19_box.Enabled = true;
                                                                                            i++;
                                                                                            if (no_f > i)
                                                                                            {
                                                                                                test20_lb.Visible = true;
                                                                                                test20_lb.Enabled = true;
                                                                                                test20_box.Visible = true;
                                                                                                test20_box.Enabled = true;
                                                                                                i++;

                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void save_qus_btn_Click(object sender, EventArgs e)
        {

            DBC.id_test(choose_tests_combo.Text);
            
            DBC.insert_tests_users(Convert.ToInt32(DBC.message),Convert.ToInt32(pr_cod_box.Text),date_lb.Text+" "+time_lb.Text,answ_textbox.Text,test1_box.Text, test2_box.Text,
                test3_box.Text, test4_box.Text, test5_box.Text, test6_box.Text, test7_box.Text, test8_box.Text, test9_box.Text, test10_box.Text, test11_box.Text, test12_box.Text,
                test13_box.Text, test14_box.Text, test15_box.Text, test16_box.Text, test17_box.Text, test18_box.Text, test19_box.Text, test20_box.Text);
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
            fildclear();
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

        private void fildclear()
        {
            test1_lb.Text = ":TEST #1";
            test1_lb.Enabled = false;
            test1_box.Enabled = false;
            test1_box.Text = "";
            test2_lb.Text = "";
            test2_lb.Enabled = false;
            test2_lb.Visible = false;
            test2_box.Enabled = false;
            test2_box.Visible = false;
            test2_box.Text = "";
            test3_lb.Text = "";
            test3_lb.Enabled = false;
            test3_lb.Visible = false;
            test3_box.Enabled = false;
            test3_box.Visible = false;
            test3_box.Text = "";
            test4_lb.Text = "";
            test4_lb.Enabled = false;
            test4_lb.Visible = false;
            test4_box.Enabled = false;
            test4_box.Visible = false;
            test4_box.Text = "";
            test5_lb.Text = "";
            test5_lb.Enabled = false;
            test5_lb.Visible = false;
            test5_box.Enabled = false;
            test5_box.Visible = false;
            test5_box.Text = "";
            test6_lb.Text = "";
            test6_lb.Enabled = false;
            test6_lb.Visible = false;
            test6_box.Enabled = false;
            test6_box.Visible = false;
            test6_box.Text = "";
            test7_lb.Text = "";
            test7_lb.Enabled = false;
            test7_lb.Visible = false;
            test7_box.Enabled = false;
            test7_box.Visible = false;
            test7_box.Text = "";
            test8_lb.Text = "";
            test8_lb.Enabled = false;
            test8_lb.Visible = false;
            test8_box.Enabled = false;
            test8_box.Visible = false;
            test8_box.Text = "";
            test9_lb.Text = "";
            test9_lb.Enabled = false;
            test9_lb.Visible = false;
            test9_box.Enabled = false;
            test9_box.Visible = false;
            test9_box.Text = "";
            test10_lb.Text = "";
            test10_lb.Enabled = false;
            test10_lb.Visible = false;
            test10_box.Enabled = false;
            test10_box.Visible = false;
            test10_box.Text = "";
            test11_lb.Text = "";
            test11_lb.Enabled = false;
            test11_lb.Visible = false;
            test11_box.Enabled = false;
            test11_box.Visible = false;
            test11_box.Text = "";
            test12_lb.Text = "";
            test12_lb.Enabled = false;
            test12_lb.Visible = false;
            test12_box.Enabled = false;
            test12_box.Visible = false;
            test12_box.Text = "";
            test13_lb.Text = "";
            test13_lb.Enabled = false;
            test13_lb.Visible = false;
            test13_box.Enabled = false;
            test13_box.Visible = false;
            test13_box.Text = "";
            test14_lb.Text = "";
            test14_lb.Enabled = false;
            test14_lb.Visible = false;
            test14_box.Enabled = false;
            test14_box.Visible = false;
            test14_box.Text = "";
            test15_lb.Text = "";
            test15_lb.Enabled = false;
            test15_lb.Visible = false;
            test15_box.Enabled = false;
            test15_box.Visible = false;
            test15_box.Text = "";
            test16_lb.Text = "";
            test16_lb.Enabled = false;
            test16_lb.Visible = false;
            test16_box.Enabled = false;
            test16_box.Visible = false;
            test16_box.Text = "";
            test17_lb.Text = "";
            test17_lb.Enabled = false;
            test17_lb.Visible = false;
            test17_box.Enabled = false;
            test17_box.Visible = false;
            test17_box.Text = "";
            test18_lb.Text = "";
            test18_lb.Enabled = false;
            test18_lb.Visible = false;
            test18_box.Enabled = false;
            test18_box.Visible = false;
            test18_box.Text = "";
            test19_lb.Text = "";
            test19_lb.Enabled = false;
            test19_lb.Visible = false;
            test19_box.Enabled = false;
            test19_box.Visible = false;
            test19_box.Text = "";
            test20_lb.Text = "";
            test20_lb.Enabled = false;
            test20_lb.Visible = false;
            test20_box.Enabled = false;
            test20_box.Visible = false;
            test20_box.Text = "";
            
        }

        
        
        
       

        private void test1_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test1_box.Text, "[^0-9&.]"))
            {

                test1_box.Text = test1_box.Text.Remove(test1_box.Text.Length - 1);
            }
        }

        private void test2_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test2_box.Text, "[^0-9&.]"))
            {

                test2_box.Text = test2_box.Text.Remove(test2_box.Text.Length - 1);
            }
        }

        private void test3_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test3_box.Text, "[^0-9&.]"))
            {

                test3_box.Text = test3_box.Text.Remove(test3_box.Text.Length - 1);
            }
        }

        private void test4_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test4_box.Text, "[^0-9&.]"))
            {

                test4_box.Text = test4_box.Text.Remove(test4_box.Text.Length - 1);
            }
        }

        private void test5_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test5_box.Text, "[^0-9&.]"))
            {

                test5_box.Text = test5_box.Text.Remove(test5_box.Text.Length - 1);
            }
        }

        private void test6_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test6_box.Text, "[^0-9&.]"))
            {

                test6_box.Text = test6_box.Text.Remove(test6_box.Text.Length - 1);
            }
        }

        private void test7_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test7_box.Text, "[^0-9&.]"))
            {

                test7_box.Text = test7_box.Text.Remove(test7_box.Text.Length - 1);
            }
        }

        private void test8_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test8_box.Text, "[^0-9&.]"))
            {

                test8_box.Text = test8_box.Text.Remove(test8_box.Text.Length - 1);
            }
        }

        private void test9_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test9_box.Text, "[^0-9&.]"))
            {

                test9_box.Text = test9_box.Text.Remove(test9_box.Text.Length - 1);
            }
        }

        private void test10_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test10_box.Text, "[^0-9&.]"))
            {

                test10_box.Text = test10_box.Text.Remove(test10_box.Text.Length - 1);
            }
        }

        private void test11_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test11_box.Text, "[^0-9&.]"))
            {

                test11_box.Text = test11_box.Text.Remove(test11_box.Text.Length - 1);
            }
        }

        private void test12_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test12_box.Text, "[^0-9&.]"))
            {

                test12_box.Text = test12_box.Text.Remove(test12_box.Text.Length - 1);
            }
        }

        private void test13_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test13_box.Text, "[^0-9&.]"))
            {

                test13_box.Text = test13_box.Text.Remove(test13_box.Text.Length - 1);
            }
        }

        private void test14_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test14_box.Text, "[^0-9&.]"))
            {

                test14_box.Text = test14_box.Text.Remove(test14_box.Text.Length - 1);
            }
        }

        private void test15_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test15_box.Text, "[^0-9&.]"))
            {

                test15_box.Text = test15_box.Text.Remove(test15_box.Text.Length - 1);
            }
        }

        private void test16_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test16_box.Text, "[^0-9&.]"))
            {

                test16_box.Text = test16_box.Text.Remove(test16_box.Text.Length - 1);
            }
        }

        private void test17_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test17_box.Text, "[^0-9&.]"))
            {

                test17_box.Text = test17_box.Text.Remove(test17_box.Text.Length - 1);
            }
        }

        private void test18_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test18_box.Text, "[^0-9&.]"))
            {

                test18_box.Text = test18_box.Text.Remove(test18_box.Text.Length - 1);
            }
        }

        private void test19_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test19_box.Text, "[^0-9&.]"))
            {

                test19_box.Text = test19_box.Text.Remove(test19_box.Text.Length - 1);
            }
        }

        private void test20_box_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(test20_box.Text, "[^0-9&.]"))
            {

                test20_box.Text = test20_box.Text.Remove(test20_box.Text.Length - 1);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Initialize();
            if (File.Exists("temp"))
            {

            }
            else
            {
                File.Create("temp");
            }
            if (File.Exists("temp2"))
            {

            }
            else
            {
                File.Create("temp2");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
