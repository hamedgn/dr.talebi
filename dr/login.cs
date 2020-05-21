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

            
            date_lb.Text = persiandate(Convert.ToDateTime(date_lb.Text));
        }
        string persiandate(DateTime dateTime1)
        {
            PersianCalendar persianCalendar1 = new PersianCalendar();
            return string.Format(@"{0}/{1}/{2}",
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
            MessageBox.Show(DBC.message);
            /*
            if (DBC.message == "wrong user or pass")
            {
                MessageBox.Show("دوباره تلاش کن");
            }
            else
            {
                MessageBox.Show("try again");
            }
            */
            Console.WriteLine(DBC.message);
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
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

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
    }
}
