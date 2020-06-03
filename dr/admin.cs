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
            DBC.message = "";
            DBC.id_machin(machine_name_box.Text);
            if (DBC.message == "")
            {
                DBC.insert_machine(machine_name_box.Text);
                MessageBox.Show(DBC.message);
                deisable_all();
            }
            else
            {
                MessageBox.Show("این دستگاه وجود دارد");
            }


            
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
            for (int i = 0; i < b; i++)
            {
                dep_combo.Items.RemoveAt(0);
            }
            machine_combo.Enabled = false;
            int c = machine_combo.Items.Count;
            for (int i = 0; i < c; i++)
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
            numericUpDown1.Value = 1;
            test1_box.Text = "";
            test1_box.Enabled = false;
            test1_lb.Enabled = false;
            f2_btn.Enabled = false;
            f2_btn.Visible = true;
            test2_box.Text = "";
            test2_box.Enabled = false;
            test2_box.Visible = false;
            test2_lb.Visible = false;
            test2_lb.Enabled = false;
            f3_btn.Enabled = false;
            f3_btn.Visible = false;
            test3_box.Text = "";
            test3_box.Enabled = false;
            test3_box.Visible = false;
            test3_lb.Visible = false;
            test3_lb.Enabled = false;
            f4_btn.Enabled = false;
            f4_btn.Visible = false;
            test4_box.Text = "";
            test4_box.Enabled = false;
            test4_box.Visible = false;
            test4_lb.Visible = false;
            test4_lb.Enabled = false;
            f5_btn.Enabled = false;
            f5_btn.Visible = false;
            test5_box.Text = "";
            test5_box.Enabled = false;
            test5_box.Visible = false;
            test5_lb.Visible = false;
            test5_lb.Enabled = false;
            f6_btn.Enabled = false;
            f6_btn.Visible = false;
            test6_box.Text = "";
            test6_box.Enabled = false;
            test6_box.Visible = false;
            test6_lb.Visible = false;
            test6_lb.Enabled = false;
            f7_btn.Enabled = false;
            f7_btn.Visible = false;
            test7_box.Text = "";
            test7_box.Enabled = false;
            test7_box.Visible = false;
            test7_lb.Visible = false;
            test7_lb.Enabled = false;
            f8_btn.Enabled = false;
            f8_btn.Visible = false;
            test8_box.Text = "";
            test8_box.Enabled = false;
            test8_box.Visible = false;
            test8_lb.Visible = false;
            test8_lb.Enabled = false;
            f9_btn.Enabled = false;
            f9_btn.Visible = false;
            test9_box.Text = "";
            test9_box.Enabled = false;
            test9_box.Visible = false;
            test9_lb.Visible = false;
            test9_lb.Enabled = false;
            f10_btn.Enabled = false;
            f10_btn.Visible = false;
            test10_box.Text = "";
            test10_box.Enabled = false;
            test10_box.Visible = false;
            test10_lb.Visible = false;
            test10_lb.Enabled = false;
            f11_btn.Enabled = false;
            f11_btn.Visible = false;
            test11_box.Text = "";
            test11_box.Enabled = false;
            test11_box.Visible = false;
            test11_lb.Visible = false;
            test11_lb.Enabled = false;
            f12_btn.Enabled = false;
            f12_btn.Visible = false;
            test12_box.Text = "";
            test12_box.Enabled = false;
            test12_box.Visible = false;
            test12_lb.Visible = false;
            test12_lb.Enabled = false;
            f13_btn.Enabled = false;
            f13_btn.Visible = false;
            test13_box.Text = "";
            test13_box.Enabled = false;
            test13_box.Visible = false;
            test13_lb.Visible = false;
            test13_lb.Enabled = false;
            f14_btn.Enabled = false;
            f14_btn.Visible = false;
            test14_box.Text = "";
            test14_box.Enabled = false;
            test14_box.Visible = false;
            test14_lb.Visible = false;
            test14_lb.Enabled = false;
            f15_btn.Enabled = false;
            f15_btn.Visible = false;
            test15_box.Text = "";
            test15_box.Enabled = false;
            test15_box.Visible = false;
            test15_lb.Visible = false;
            test15_lb.Enabled = false;
            f16_btn.Enabled = false;
            f16_btn.Visible = false;
            test16_box.Text = "";
            test16_box.Enabled = false;
            test16_box.Visible = false;
            test16_lb.Visible = false;
            test16_lb.Enabled = false;
            f17_btn.Enabled = false;
            f17_btn.Visible = false;
            test17_box.Text = "";
            test17_box.Enabled = false;
            test17_box.Visible = false;
            test17_lb.Visible = false;
            test17_lb.Enabled = false;
            f18_btn.Enabled = false;
            f18_btn.Visible = false;
            test18_box.Text = "";
            test18_box.Enabled = false;
            test18_box.Visible = false;
            test18_lb.Visible = false;
            test18_lb.Enabled = false;
            f19_btn.Enabled = false;
            f19_btn.Visible = false;
            test19_box.Text = "";
            test19_box.Enabled = false;
            test19_box.Visible = false;
            test19_lb.Visible = false;
            test19_lb.Enabled = false;
            f20_btn.Enabled = false;
            f20_btn.Visible = false;
            test20_box.Text = "";
            test20_box.Enabled = false;
            test20_box.Visible = false;
            test20_lb.Visible = false;
            test20_lb.Enabled = false;
            test_num_22_user_combo.Enabled = false;
            test_num_22_test_combo.Enabled = false;
            user_answ_box1.Text = "";
            user_answ_box1.Enabled = false;
            user_answ_lb1.Enabled = false;
            user_answ_lb1.Text = "";
            user_answ_box2.Text = "";
            user_answ_box2.Enabled = false;
            user_answ_lb2.Enabled = false;
            user_answ_lb2.Text = "";
            user_answ_box3.Text = "";
            user_answ_box3.Enabled = false;
            user_answ_lb3.Enabled = false;
            user_answ_lb3.Text = "";
            user_answ_box4.Text = "";
            user_answ_box4.Enabled = false;
            user_answ_lb4.Enabled = false;
            user_answ_lb4.Text = "";
            user_answ_box5.Text = "";
            user_answ_box5.Enabled = false;
            user_answ_lb5.Enabled = false;
            user_answ_lb5.Text = "";
            user_answ_box6.Text = "";
            user_answ_box6.Enabled = false;
            user_answ_lb6.Enabled = false;
            user_answ_lb6.Text = "";
            user_answ_box7.Text = "";
            user_answ_box7.Enabled = false;
            user_answ_lb7.Enabled = false;
            user_answ_lb7.Text = "";
            user_answ_box8.Text = "";
            user_answ_box8.Enabled = false;
            user_answ_lb8.Enabled = false;
            user_answ_lb8.Text = "";
            user_answ_box9.Text = "";
            user_answ_box9.Enabled = false;
            user_answ_lb9.Enabled = false;
            user_answ_lb9.Text = "";
            user_answ_box10.Text = "";
            user_answ_box10.Enabled = false;
            user_answ_lb10.Enabled = false;
            user_answ_lb10.Text = "";
            user_answ_box11.Text = "";
            user_answ_box11.Enabled = false;
            user_answ_lb11.Enabled = false;
            user_answ_lb11.Text = "";
            user_answ_box12.Text = "";
            user_answ_box12.Enabled = false;
            user_answ_lb12.Enabled = false;
            user_answ_lb12.Text = "";
            user_answ_box13.Text = "";
            user_answ_box13.Enabled = false;
            user_answ_lb13.Enabled = false;
            user_answ_lb13.Text = "";
            user_answ_box14.Text = "";
            user_answ_box14.Enabled = false;
            user_answ_lb14.Enabled = false;
            user_answ_lb14.Text = "";
            user_answ_box15.Text = "";
            user_answ_box15.Enabled = false;
            user_answ_lb15.Enabled = false;
            user_answ_lb15.Text = "";
            user_answ_box16.Text = "";
            user_answ_box16.Enabled = false;
            user_answ_lb16.Enabled = false;
            user_answ_lb16.Text = "";
            user_answ_box17.Text = "";
            user_answ_box17.Enabled = false;
            user_answ_lb17.Enabled = false;
            user_answ_lb17.Text = "";
            user_answ_box18.Text = "";
            user_answ_box18.Enabled = false;
            user_answ_lb18.Enabled = false;
            user_answ_lb18.Text = "";
            user_answ_box19.Text = "";
            user_answ_box19.Enabled = false;
            user_answ_lb19.Enabled = false;
            user_answ_lb19.Text = "";
            user_answ_box20.Text = "";
            user_answ_box20.Enabled = false;
            user_answ_lb20.Enabled = false;
            user_answ_lb20.Text = "";

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
            DBC.message = "";
            DBC.id_user(prs_cod_box.Text);
            if (DBC.message == "")
            {
                DBC.insert_users(Convert.ToInt32(prs_cod_box.Text), Convert.ToInt32(password_box.Text), j);
                deisable_all();
                MessageBox.Show(DBC.message);
            }
            else
            {
                MessageBox.Show("این کد پرسنلی وجود دارد");
            }
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
            DBC.message = "";
            DBC.id_departman(dep_name_box.Text);
            if (DBC.message == "")
            {
                DBC.insert_departman(dep_name_box.Text);
                MessageBox.Show(DBC.message);
                deisable_all();
            }
            else
            {
                MessageBox.Show("این بخش وجود دارد");
            }

            
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
            test1_lb.Enabled = true;
            test1_box.Enabled = true;
            f2_btn.Enabled = true;
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
            DBC.message = "";
            DBC.id_test(test_name_box.Text);
            if (DBC.message == "")
            {
                DBC.id_machin(test_machine_combo.SelectedItem.ToString());
                DBC.insert_test(test_name_box.Text, Convert.ToInt32(DBC.message), test_text_box.Text,Convert.ToInt32( numericUpDown1.Value), test1_box.Text, test2_box.Text,
                    test3_box.Text, test4_box.Text, test5_box.Text, test6_box.Text, test7_box.Text, test8_box.Text, test9_box.Text, test10_box.Text, test11_box.Text, test12_box.Text,
                    test13_box.Text, test14_box.Text, test15_box.Text, test16_box.Text, test17_box.Text, test18_box.Text, test19_box.Text, test20_box.Text);
                MessageBox.Show(DBC.message);
                deisable_all();
            }
            else
            {
                MessageBox.Show("تست با این نام وجود دارد");
            }
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


        //TODO: here copy from another tab


        private void qus_tab_Click(object sender, EventArgs e)
        {
            /*
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
            */
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
            
            int z = 0;
            
            
            for (int i = 0; i < Convert.ToInt32(test_list.Length.ToString()) - 1; i++)
            {
                for (int v = i ; v > 0  ; v--)
                {
                    if (test_list[i] == test_list[v-1])
                    {
                        z = 1;
                       
                    }
                    else
                    {
                        z = 0;
                    }
                }
                if (z == 0)
                {
                    test_num_user_combo.Items.Add(test_list[i]);
                }
                
            }
            
            File.WriteAllText("temp", "");
            test_num_user_combo.Enabled = true;
        }

        private void test_num_user_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DBC.id_test(test_num_user_combo.SelectedItem.ToString());
           // DBC.test_user_answr(Convert.ToInt32(DBC.message), Convert.ToInt32(pr_cod_user_combo.SelectedItem.ToString()));
            //test_time_user_datepicker.Text = DBC.date_answer.ToString();
           // user_answ_user_box.Text = DBC.answer;
            test_num_user_combo.Enabled = false;
            pr_cod_user_combo.Enabled = false;
            test_num_22_user_combo.Enabled = true;

            int j = test_num_22_user_combo.Items.Count;
            for (int i = 0; i < j; i++)
            {
                test_num_22_user_combo.Items.RemoveAt(0);
            }

            timer1.Enabled = true;

        }

        private void save_edit_user_btn_Click(object sender, EventArgs e)
        {
            //DBC.id_test(test_num_user_combo.SelectedItem.ToString());
            DBC.edit_tests_users(Convert.ToInt32(test_num_22_user_combo.SelectedItem.ToString()), test_time_user_datepicker.Text, user_answ_user_box.Text,user_answ_box1.Text,user_answ_box2.Text,user_answ_box3.Text,
                user_answ_box4.Text,user_answ_box5.Text,user_answ_box6.Text,user_answ_box7.Text,user_answ_box8.Text,user_answ_box9.Text,user_answ_box10.Text,user_answ_box11.Text,user_answ_box12.Text, user_answ_box13.Text
                , user_answ_box14.Text, user_answ_box15.Text, user_answ_box16.Text, user_answ_box17.Text, user_answ_box18.Text, user_answ_box19.Text, user_answ_box20.Text);
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
            DBC.edit_tests_users(Convert.ToInt32(test_num_22_test_combo.SelectedItem.ToString()), test_time_test_datepicker.Text, user_answ_test_box.Text, test_answ_box1.Text, test_answ_box2.Text, test_answ_box3.Text,
                test_answ_box4.Text, test_answ_box5.Text, test_answ_box6.Text, test_answ_box7.Text, test_answ_box8.Text, test_answ_box9.Text, test_answ_box10.Text, test_answ_box11.Text, test_answ_box12.Text, test_answ_box13.Text
                , test_answ_box14.Text, test_answ_box15.Text, test_answ_box16.Text, test_answ_box17.Text, test_answ_box18.Text, test_answ_box19.Text, test_answ_box20.Text);
            MessageBox.Show(DBC.message);
            deisable_all();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f2_btn_Click(object sender, EventArgs e)
        {
            f2_btn.Enabled = false;
            f2_btn.Visible = false;
            test2_lb.Visible = true;
            test2_lb.Enabled = true;
            test2_box.Visible = true;
            test2_box.Enabled = true;
            f3_btn.Visible = true;
            f3_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f3_btn_Click(object sender, EventArgs e)
        {
            f3_btn.Enabled = false;
            f3_btn.Visible = false;
            test3_lb.Visible = true;
            test3_lb.Enabled = true;
            test3_box.Visible = true;
            test3_box.Enabled = true;
            f4_btn.Visible = true;
            f4_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f4_btn_Click(object sender, EventArgs e)
        {
            f4_btn.Enabled = false;
            f4_btn.Visible = false;
            test4_lb.Visible = true;
            test4_lb.Enabled = true;
            test4_box.Visible = true;
            test4_box.Enabled = true;
            f5_btn.Visible = true;
            f5_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f5_btn_Click(object sender, EventArgs e)
        {
            f5_btn.Enabled = false;
            f5_btn.Visible = false;
            test5_lb.Visible = true;
            test5_lb.Enabled = true;
            test5_box.Visible = true;
            test5_box.Enabled = true;
            f6_btn.Visible = true;
            f6_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f6_btn_Click(object sender, EventArgs e)
        {
            f6_btn.Enabled = false;
            f6_btn.Visible = false;
            test6_lb.Visible = true;
            test6_lb.Enabled = true;
            test6_box.Visible = true;
            test6_box.Enabled = true;
            f7_btn.Visible = true;
            f7_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f7_btn_Click(object sender, EventArgs e)
        {
            f7_btn.Enabled = false;
            f7_btn.Visible = false;
            test7_lb.Visible = true;
            test7_lb.Enabled = true;
            test7_box.Visible = true;
            test7_box.Enabled = true;
            f8_btn.Visible = true;
            f8_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f8_btn_Click(object sender, EventArgs e)
        {
            f8_btn.Enabled = false;
            f8_btn.Visible = false;
            test8_lb.Visible = true;
            test8_lb.Enabled = true;
            test8_box.Visible = true;
            test8_box.Enabled = true;
            f9_btn.Visible = true;
            f9_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f9_btn_Click(object sender, EventArgs e)
        {
            f9_btn.Enabled = false;
            f9_btn.Visible = false;
            test9_lb.Visible = true;
            test9_lb.Enabled = true;
            test9_box.Visible = true;
            test9_box.Enabled = true;
            f10_btn.Visible = true;
            f10_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f10_btn_Click(object sender, EventArgs e)
        {
            f10_btn.Enabled = false;
            f10_btn.Visible = false;
            test10_lb.Visible = true;
            test10_lb.Enabled = true;
            test10_box.Visible = true;
            test10_box.Enabled = true;
            f11_btn.Visible = true;
            f11_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f11_btn_Click(object sender, EventArgs e)
        {
            f11_btn.Enabled = false;
            f11_btn.Visible = false;
            test11_lb.Visible = true;
            test11_lb.Enabled = true;
            test11_box.Visible = true;
            test11_box.Enabled = true;
            f12_btn.Visible = true;
            f12_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f12_btn_Click(object sender, EventArgs e)
        {
            f12_btn.Enabled = false;
            f12_btn.Visible = false;
            test12_lb.Visible = true;
            test12_lb.Enabled = true;
            test12_box.Visible = true;
            test12_box.Enabled = true;
            f13_btn.Visible = true;
            f13_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f13_btn_Click(object sender, EventArgs e)
        {
            f13_btn.Enabled = false;
            f13_btn.Visible = false;
            test13_lb.Visible = true;
            test13_lb.Enabled = true;
            test13_box.Visible = true;
            test13_box.Enabled = true;
            f14_btn.Visible = true;
            f14_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f14_btn_Click(object sender, EventArgs e)
        {
            f14_btn.Enabled = false;
            f14_btn.Visible = false;
            test14_lb.Visible = true;
            test14_lb.Enabled = true;
            test14_box.Visible = true;
            test14_box.Enabled = true;
            f15_btn.Visible = true;
            f15_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f15_btn_Click(object sender, EventArgs e)
        {
            f15_btn.Enabled = false;
            f15_btn.Visible = false;
            test15_lb.Visible = true;
            test15_lb.Enabled = true;
            test15_box.Visible = true;
            test15_box.Enabled = true;
            f16_btn.Visible = true;
            f16_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f16_btn_Click(object sender, EventArgs e)
        {
            f16_btn.Enabled = false;
            f16_btn.Visible = false;
            test16_lb.Visible = true;
            test16_lb.Enabled = true;
            test16_box.Visible = true;
            test16_box.Enabled = true;
            f17_btn.Visible = true;
            f17_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f17_btn_Click(object sender, EventArgs e)
        {
            f17_btn.Enabled = false;
            f17_btn.Visible = false;
            test17_lb.Visible = true;
            test17_lb.Enabled = true;
            test17_box.Visible = true;
            test17_box.Enabled = true;
            f18_btn.Visible = true;
            f18_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f18_btn_Click(object sender, EventArgs e)
        {
            f18_btn.Enabled = false;
            f18_btn.Visible = false;
            test18_lb.Visible = true;
            test18_lb.Enabled = true;
            test18_box.Visible = true;
            test18_box.Enabled = true;
            f19_btn.Visible = true;
            f19_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }
        
        private void f19_btn_Click(object sender, EventArgs e)
        {
            f19_btn.Enabled = false;
            f19_btn.Visible = false;
            test19_lb.Visible = true;
            test19_lb.Enabled = true;
            test19_box.Visible = true;
            test19_box.Enabled = true;
            f20_btn.Visible = true;
            f20_btn.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void f20_btn_Click(object sender, EventArgs e)
        {
            f20_btn.Enabled = false;
            f20_btn.Visible = false;
            test20_lb.Visible = true;
            test20_lb.Enabled = true;
            test20_box.Visible = true;
            test20_box.Enabled = true;
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }


        private void test_num_22_user_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBC.id_test(test_num_user_combo.SelectedItem.ToString());
            DBC.test_name(Convert.ToInt32(DBC.message));
            en_fild_user(DBC.no_f);
            //qus_textbox.Text = DBC.tests_qus;
            user_answ_lb1.Text = DBC.f1;
            user_answ_lb2.Text = DBC.f2;
            user_answ_lb3.Text = DBC.f3;
            user_answ_lb4.Text = DBC.f4;
            user_answ_lb5.Text = DBC.f5;
            user_answ_lb6.Text = DBC.f6;
            user_answ_lb7.Text = DBC.f7;
            user_answ_lb8.Text = DBC.f8;
            user_answ_lb9.Text = DBC.f9;
            user_answ_lb10.Text = DBC.f10;
            user_answ_lb11.Text = DBC.f11;
            user_answ_lb12.Text = DBC.f12;
            user_answ_lb13.Text = DBC.f13;
            user_answ_lb14.Text = DBC.f14;
            user_answ_lb15.Text = DBC.f15;
            user_answ_lb16.Text = DBC.f16;
            user_answ_lb17.Text = DBC.f17;
            user_answ_lb18.Text = DBC.f18;
            user_answ_lb19.Text = DBC.f19;
            user_answ_lb20.Text = DBC.f20;

            DBC.test_user_answr_id(Convert.ToInt32(test_num_22_user_combo.SelectedItem.ToString()));

            test_time_user_datepicker.Text = DBC.date_answer.ToString();
            user_answ_user_box.Text = DBC.answer;
            user_answ_box1.Text = DBC.f1;
            user_answ_box2.Text = DBC.f2;
            user_answ_box3.Text = DBC.f3;
            user_answ_box4.Text = DBC.f4;
            user_answ_box5.Text = DBC.f5;
            user_answ_box6.Text = DBC.f6;
            user_answ_box7.Text = DBC.f7;
            user_answ_box8.Text = DBC.f8;
            user_answ_box9.Text = DBC.f9;
            user_answ_box10.Text = DBC.f10;
            user_answ_box11.Text = DBC.f11;
            user_answ_box12.Text = DBC.f12;
            user_answ_box13.Text = DBC.f13;
            user_answ_box14.Text = DBC.f14;
            user_answ_box15.Text = DBC.f15;
            user_answ_box16.Text = DBC.f16;
            user_answ_box17.Text = DBC.f17;
            user_answ_box18.Text = DBC.f18;
            user_answ_box19.Text = DBC.f19;
            user_answ_box20.Text = DBC.f20;
            test_num_user_combo.Enabled = false;
            pr_cod_user_combo.Enabled = false;
            test_num_22_user_combo.Enabled = false;
            test_time_user_datepicker.Enabled = true;
            user_answ_user_box.Enabled = true;
            save_edit_user_btn.Enabled = true;
        }
        private void en_fild_user(int no_f)
        {
            int i = 0;
            if (no_f > i)
            {
                user_answ_lb1.Visible = true;
                user_answ_lb1.Enabled = true;
                user_answ_box1.Visible = true;
                user_answ_box1.Enabled = true;
                i++;
                if (no_f > i)
                {
                    user_answ_lb2.Visible = true;
                    user_answ_lb2.Enabled = true;
                    user_answ_box2.Visible = true;
                    user_answ_box2.Enabled = true;
                    i++;
                    if (no_f > i)
                    {
                        user_answ_lb3.Visible = true;
                        user_answ_lb3.Enabled = true;
                        user_answ_box3.Visible = true;
                        user_answ_box3.Enabled = true;
                        i++;
                        if (no_f > i)
                        {
                            user_answ_lb4.Visible = true;
                            user_answ_lb4.Enabled = true;
                            user_answ_box4.Visible = true;
                            user_answ_box4.Enabled = true;
                            i++;
                            if (no_f > i)
                            {
                                user_answ_lb5.Visible = true;
                                user_answ_lb5.Enabled = true;
                                user_answ_box5.Visible = true;
                                user_answ_box5.Enabled = true;
                                i++;
                                if (no_f > i)
                                {
                                    user_answ_lb6.Visible = true;
                                    user_answ_lb6.Enabled = true;
                                    user_answ_box6.Visible = true;
                                    user_answ_box6.Enabled = true;
                                    i++;
                                    if (no_f > i)
                                    {
                                        user_answ_lb7.Visible = true;
                                        user_answ_lb7.Enabled = true;
                                        user_answ_box7.Visible = true;
                                        user_answ_box7.Enabled = true;
                                        i++;
                                        if (no_f > i)
                                        {
                                            user_answ_lb8.Visible = true;
                                            user_answ_lb8.Enabled = true;
                                            user_answ_box8.Visible = true;
                                            user_answ_box8.Enabled = true;
                                            i++;
                                            if (no_f > i)
                                            {
                                                user_answ_lb9.Visible = true;
                                                user_answ_lb9.Enabled = true;
                                                user_answ_box9.Visible = true;
                                                user_answ_box9.Enabled = true;
                                                i++;

                                                if (no_f > i)
                                                {
                                                    user_answ_lb10.Visible = true;
                                                    user_answ_lb10.Enabled = true;
                                                    user_answ_box10.Visible = true;
                                                    user_answ_box10.Enabled = true;
                                                    i++;
                                                    if (no_f > i)
                                                    {
                                                        user_answ_lb11.Visible = true;
                                                        user_answ_lb11.Enabled = true;
                                                        user_answ_box11.Visible = true;
                                                        user_answ_box11.Enabled = true;
                                                        i++;
                                                        if (no_f > i)
                                                        {
                                                            user_answ_lb12.Visible = true;
                                                            user_answ_lb12.Enabled = true;
                                                            user_answ_box12.Visible = true;
                                                            user_answ_box12.Enabled = true;
                                                            i++;
                                                            if (no_f > i)
                                                            {
                                                                user_answ_lb13.Visible = true;
                                                                user_answ_lb13.Enabled = true;
                                                                user_answ_box13.Visible = true;
                                                                user_answ_box13.Enabled = true;
                                                                i++;
                                                                if (no_f > i)
                                                                {
                                                                    user_answ_lb14.Visible = true;
                                                                    user_answ_lb14.Enabled = true;
                                                                    user_answ_box14.Visible = true;
                                                                    user_answ_box14.Enabled = true;
                                                                    i++;
                                                                    if (no_f > i)
                                                                    {
                                                                        user_answ_lb15.Visible = true;
                                                                        user_answ_lb15.Enabled = true;
                                                                        user_answ_box15.Visible = true;
                                                                        user_answ_box15.Enabled = true;
                                                                        i++;
                                                                        if (no_f > i)
                                                                        {
                                                                            user_answ_lb16.Visible = true;
                                                                            user_answ_lb16.Enabled = true;
                                                                            user_answ_box16.Visible = true;
                                                                            user_answ_box16.Enabled = true;
                                                                            i++;
                                                                            if (no_f > i)
                                                                            {
                                                                                user_answ_lb17.Visible = true;
                                                                                user_answ_lb17.Enabled = true;
                                                                                user_answ_box17.Visible = true;
                                                                                user_answ_box17.Enabled = true;
                                                                                i++;
                                                                                if (no_f > i)
                                                                                {
                                                                                    user_answ_lb18.Visible = true;
                                                                                    user_answ_lb18.Enabled = true;
                                                                                    user_answ_box18.Visible = true;
                                                                                    user_answ_box18.Enabled = true;
                                                                                    i++;
                                                                                    if (no_f > i)
                                                                                    {
                                                                                        user_answ_lb19.Visible = true;
                                                                                        user_answ_lb19.Enabled = true;
                                                                                        user_answ_box19.Visible = true;
                                                                                        user_answ_box19.Enabled = true;
                                                                                        i++;
                                                                                        if (no_f > i)
                                                                                        {
                                                                                            user_answ_lb20.Visible = true;
                                                                                            user_answ_lb20.Enabled = true;
                                                                                            user_answ_box20.Visible = true;
                                                                                            user_answ_box20.Enabled = true;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //DBC.id_user(pr_cod_user_combo.Text);
            DBC.message = "";
            DBC.id_test(test_num_user_combo.SelectedItem.ToString());
            DBC.sync_test_22_user(Convert.ToInt32( DBC.message),Convert.ToInt32( pr_cod_user_combo.SelectedItem.ToString()));
            DBC.sync_test_22_user_name();


            String[] test_list = File.ReadAllText("temp").ToString().Split('%');
            for (int i = 0; i < Convert.ToInt32(test_list.Length.ToString()) - 1; i++)
            {
                test_num_22_user_combo.Items.Add(test_list[i]);
            }

            File.WriteAllText("temp", "");
            test_num_22_user_combo.Enabled = true;
        }

        private void user_answ_box1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box1.Text, "[^0-9&.]"))
            {

                user_answ_box1.Text = user_answ_box1.Text.Remove(user_answ_box1.Text.Length - 1);
            }
        }

        private void user_answ_box2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box2.Text, "[^0-9&.]"))
            {

                user_answ_box2.Text = user_answ_box2.Text.Remove(user_answ_box2.Text.Length - 1);
            }
        }

        private void user_answ_box3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box3.Text, "[^0-9&.]"))
            {

                user_answ_box3.Text = user_answ_box3.Text.Remove(user_answ_box3.Text.Length - 1);
            }
        }

        private void user_answ_box4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box4.Text, "[^0-9&.]"))
            {

                user_answ_box4.Text = user_answ_box4.Text.Remove(user_answ_box4.Text.Length - 1);
            }
        }

        private void user_answ_box5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box5.Text, "[^0-9&.]"))
            {

                user_answ_box5.Text = user_answ_box5.Text.Remove(user_answ_box5.Text.Length - 1);
            }
        }

        private void user_answ_box6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box6.Text, "[^0-9&.]"))
            {

                user_answ_box6.Text = user_answ_box6.Text.Remove(user_answ_box6.Text.Length - 1);
            }
        }

        private void user_answ_box7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box7.Text, "[^0-9&.]"))
            {

                user_answ_box7.Text = user_answ_box7.Text.Remove(user_answ_box7.Text.Length - 1);
            }
        }

        private void user_answ_box8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box8.Text, "[^0-9&.]"))
            {

                user_answ_box8.Text = user_answ_box8.Text.Remove(user_answ_box8.Text.Length - 1);
            }
        }

        private void user_answ_box9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box9.Text, "[^0-9&.]"))
            {

                user_answ_box9.Text = user_answ_box9.Text.Remove(user_answ_box9.Text.Length - 1);
            }
        }

        private void user_answ_box10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box10.Text, "[^0-9&.]"))
            {

                user_answ_box10.Text = user_answ_box10.Text.Remove(user_answ_box10.Text.Length - 1);
            }
        }

        private void user_answ_box11_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box11.Text, "[^0-9&.]"))
            {

                user_answ_box11.Text = user_answ_box11.Text.Remove(user_answ_box11.Text.Length - 1);
            }
        }

        private void user_answ_box12_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box12.Text, "[^0-9&.]"))
            {

                user_answ_box12.Text = user_answ_box12.Text.Remove(user_answ_box12.Text.Length - 1);
            }
        }

        private void user_answ_box13_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box13.Text, "[^0-9&.]"))
            {

                user_answ_box13.Text = user_answ_box13.Text.Remove(user_answ_box13.Text.Length - 1);
            }
        }

        private void user_answ_box14_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box14.Text, "[^0-9&.]"))
            {

                user_answ_box14.Text = user_answ_box14.Text.Remove(user_answ_box14.Text.Length - 1);
            }
        }

        private void user_answ_box15_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box15.Text, "[^0-9&.]"))
            {

                user_answ_box15.Text = user_answ_box15.Text.Remove(user_answ_box15.Text.Length - 1);
            }
        }

        private void user_answ_box16_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box16.Text, "[^0-9&.]"))
            {

                user_answ_box16.Text = user_answ_box16.Text.Remove(user_answ_box16.Text.Length - 1);
            }
        }

        private void user_answ_box17_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box17.Text, "[^0-9&.]"))
            {

                user_answ_box17.Text = user_answ_box17.Text.Remove(user_answ_box17.Text.Length - 1);
            }
        }

        private void user_answ_box18_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box18.Text, "[^0-9&.]"))
            {

                user_answ_box18.Text = user_answ_box18.Text.Remove(user_answ_box18.Text.Length - 1);
            }
        }

        private void user_answ_box19_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box19.Text, "[^0-9&.]"))
            {

                user_answ_box19.Text = user_answ_box19.Text.Remove(user_answ_box19.Text.Length - 1);
            }
        }

        private void user_answ_box20_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(user_answ_box20.Text, "[^0-9&.]"))
            {

                user_answ_box20.Text = user_answ_box20.Text.Remove(user_answ_box20.Text.Length - 1);
            }
        }
    }
}
