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
            this.enter_btn.Location = new System.Drawing.Point(270, 147);
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
            this.timer_dep_list.Enabled = true;
            this.timer_dep_list.Interval = 2000;
            this.timer_dep_list.Tick += new System.EventHandler(this.timer_dep_list_Tick);
            // 
            // choose_machin_combo
            // 
            this.choose_machin_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 180);
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
    }
}

