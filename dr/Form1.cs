using System;
using System.Threading;
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
    public partial class Form1 : Form
    {
        private db Db;
        
        
        public Form1()
        {
            InitializeComponent();
            Db = new db();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Creating object of ExThread class 

           // Db.check_user_pass();
           // label1.Text = Db.id;
            //label2.Text = Db.user;
            // Creating thread 
            // Using thread class 
            Thread thr = new Thread(new ThreadStart(this.chlb));
            thr.Start();
           // Db.lists();
            
          
            
        }
        
        public void chlb()
        {
           // Db.lists();
            //label1.Text = Db.id;
            //label2.Text = Db.user;
        }
    }
}
