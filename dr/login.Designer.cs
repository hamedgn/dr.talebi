namespace dr
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pr_cod_lb = new System.Windows.Forms.Label();
            this.passcod_lb = new System.Windows.Forms.Label();
            this.pr_cod_box = new System.Windows.Forms.TextBox();
            this.passcod_box = new System.Windows.Forms.TextBox();
            this.choose_dp_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.time_lb = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.timer_date_time = new System.Windows.Forms.Timer(this.components);
            this.choose_dp_combo = new System.Windows.Forms.ComboBox();
            this.timer_dep_list = new System.Windows.Forms.Timer(this.components);
            this.choose_machin_combo = new System.Windows.Forms.ComboBox();
            this.timer_get_machine = new System.Windows.Forms.Timer(this.components);
            this.choose_machine_lb = new System.Windows.Forms.Label();
            this.login_to_test = new System.Windows.Forms.Button();
            this.tests_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qus_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answ_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pr_cod_lb
            // 
            this.pr_cod_lb.AutoSize = true;
            this.pr_cod_lb.Location = new System.Drawing.Point(351, 32);
            this.pr_cod_lb.Name = "pr_cod_lb";
            this.pr_cod_lb.Size = new System.Drawing.Size(57, 13);
            this.pr_cod_lb.TabIndex = 0;
            this.pr_cod_lb.Text = "کد پرسنلی";
            this.pr_cod_lb.Click += new System.EventHandler(this.pr_cod_lb_Click);
            // 
            // passcod_lb
            // 
            this.passcod_lb.AutoSize = true;
            this.passcod_lb.Location = new System.Drawing.Point(351, 67);
            this.passcod_lb.Name = "passcod_lb";
            this.passcod_lb.Size = new System.Drawing.Size(47, 13);
            this.passcod_lb.TabIndex = 1;
            this.passcod_lb.Text = "رمز عبور";
            this.passcod_lb.Click += new System.EventHandler(this.passcod_lb_Click);
            // 
            // pr_cod_box
            // 
            this.pr_cod_box.Location = new System.Drawing.Point(225, 29);
            this.pr_cod_box.Name = "pr_cod_box";
            this.pr_cod_box.Size = new System.Drawing.Size(120, 20);
            this.pr_cod_box.TabIndex = 2;
            this.pr_cod_box.TextChanged += new System.EventHandler(this.pr_cod_box_TextChanged);
            // 
            // passcod_box
            // 
            this.passcod_box.Location = new System.Drawing.Point(225, 67);
            this.passcod_box.Name = "passcod_box";
            this.passcod_box.Size = new System.Drawing.Size(120, 20);
            this.passcod_box.TabIndex = 3;
            this.passcod_box.UseSystemPasswordChar = true;
            this.passcod_box.TextChanged += new System.EventHandler(this.passcod_box_TextChanged);
            // 
            // choose_dp_lb
            // 
            this.choose_dp_lb.AutoSize = true;
            this.choose_dp_lb.Location = new System.Drawing.Point(347, 108);
            this.choose_dp_lb.Name = "choose_dp_lb";
            this.choose_dp_lb.Size = new System.Drawing.Size(63, 13);
            this.choose_dp_lb.TabIndex = 4;
            this.choose_dp_lb.Text = ":انتخاب بخش";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Location = new System.Drawing.Point(30, 32);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(65, 13);
            this.date_lb.TabIndex = 6;
            this.date_lb.Text = "1399/01/01";
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Location = new System.Drawing.Point(33, 66);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(49, 13);
            this.time_lb.TabIndex = 7;
            this.time_lb.Text = "12:34:56";
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(138, 65);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 23);
            this.enter_btn.TabIndex = 8;
            this.enter_btn.Text = "ورود";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // timer_date_time
            // 
            this.timer_date_time.Enabled = true;
            this.timer_date_time.Interval = 1000;
            this.timer_date_time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // choose_dp_combo
            // 
            this.choose_dp_combo.AllowDrop = true;
            this.choose_dp_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_dp_combo.Enabled = false;
            this.choose_dp_combo.FormattingEnabled = true;
            this.choose_dp_combo.Location = new System.Drawing.Point(224, 104);
            this.choose_dp_combo.Name = "choose_dp_combo";
            this.choose_dp_combo.Size = new System.Drawing.Size(121, 21);
            this.choose_dp_combo.TabIndex = 9;
            this.choose_dp_combo.SelectedIndexChanged += new System.EventHandler(this.choose_dp_combo_SelectedIndexChanged);
            // 
            // timer_dep_list
            // 
            this.timer_dep_list.Interval = 1000;
            this.timer_dep_list.Tick += new System.EventHandler(this.timer_dep_list_Tick);
            // 
            // choose_machin_combo
            // 
            this.choose_machin_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_machin_combo.Enabled = false;
            this.choose_machin_combo.FormattingEnabled = true;
            this.choose_machin_combo.Location = new System.Drawing.Point(12, 104);
            this.choose_machin_combo.Name = "choose_machin_combo";
            this.choose_machin_combo.Size = new System.Drawing.Size(121, 21);
            this.choose_machin_combo.TabIndex = 11;
            // 
            // timer_get_machine
            // 
            this.timer_get_machine.Interval = 1000;
            this.timer_get_machine.Tick += new System.EventHandler(this.timer_get_machine_Tick);
            // 
            // choose_machine_lb
            // 
            this.choose_machine_lb.AutoSize = true;
            this.choose_machine_lb.Location = new System.Drawing.Point(135, 108);
            this.choose_machine_lb.Name = "choose_machine_lb";
            this.choose_machine_lb.Size = new System.Drawing.Size(78, 13);
            this.choose_machine_lb.TabIndex = 12;
            this.choose_machine_lb.Text = ":انتخاب دستگاه";
            // 
            // login_to_test
            // 
            this.login_to_test.Enabled = false;
            this.login_to_test.Location = new System.Drawing.Point(12, 145);
            this.login_to_test.Name = "login_to_test";
            this.login_to_test.Size = new System.Drawing.Size(75, 23);
            this.login_to_test.TabIndex = 13;
            this.login_to_test.Text = "ورود به تست";
            this.login_to_test.UseVisualStyleBackColor = true;
            this.login_to_test.Click += new System.EventHandler(this.login_to_test_Click);
            // 
            // tests_combo
            // 
            this.tests_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tests_combo.Enabled = false;
            this.tests_combo.FormattingEnabled = true;
            this.tests_combo.Location = new System.Drawing.Point(209, 179);
            this.tests_combo.Name = "tests_combo";
            this.tests_combo.Size = new System.Drawing.Size(121, 21);
            this.tests_combo.TabIndex = 14;
            this.tests_combo.SelectedIndexChanged += new System.EventHandler(this.tests_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = ":انتخاب تست";
            // 
            // qus_textbox
            // 
            this.qus_textbox.Location = new System.Drawing.Point(12, 229);
            this.qus_textbox.Multiline = true;
            this.qus_textbox.Name = "qus_textbox";
            this.qus_textbox.ReadOnly = true;
            this.qus_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qus_textbox.Size = new System.Drawing.Size(393, 55);
            this.qus_textbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = ":متن سوال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = ":پاسخ شما";
            // 
            // answ_textbox
            // 
            this.answ_textbox.Enabled = false;
            this.answ_textbox.Location = new System.Drawing.Point(12, 323);
            this.answ_textbox.Multiline = true;
            this.answ_textbox.Name = "answ_textbox";
            this.answ_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.answ_textbox.Size = new System.Drawing.Size(393, 55);
            this.answ_textbox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(323, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(167, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "تغییر دستگاه";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(24, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "ذخیره نهایی و خروج";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 444);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answ_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qus_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tests_combo);
            this.Controls.Add(this.login_to_test);
            this.Controls.Add(this.choose_machine_lb);
            this.Controls.Add(this.choose_machin_combo);
            this.Controls.Add(this.choose_dp_combo);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.choose_dp_lb);
            this.Controls.Add(this.passcod_box);
            this.Controls.Add(this.pr_cod_box);
            this.Controls.Add(this.passcod_lb);
            this.Controls.Add(this.pr_cod_lb);
            this.Name = "login";
            this.Text = "ورود";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pr_cod_lb;
        private System.Windows.Forms.Label passcod_lb;
        private System.Windows.Forms.TextBox pr_cod_box;
        private System.Windows.Forms.TextBox passcod_box;
        private System.Windows.Forms.Label choose_dp_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Timer timer_date_time;
        private System.Windows.Forms.ComboBox choose_dp_combo;
        private System.Windows.Forms.Timer timer_dep_list;
        private System.Windows.Forms.ComboBox choose_machin_combo;
        private System.Windows.Forms.Timer timer_get_machine;
        private System.Windows.Forms.Label choose_machine_lb;
        private System.Windows.Forms.Button login_to_test;
        private System.Windows.Forms.ComboBox tests_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qus_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answ_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}

