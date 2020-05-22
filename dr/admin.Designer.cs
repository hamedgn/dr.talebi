namespace dr
{
    partial class admin
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
            this.create_user = new System.Windows.Forms.Button();
            this.create_dep = new System.Windows.Forms.Button();
            this.create_machine = new System.Windows.Forms.Button();
            this.create_test = new System.Windows.Forms.Button();
            this.connect_mach_dep = new System.Windows.Forms.Button();
            this.pr_code_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.premission_level_lb = new System.Windows.Forms.Label();
            this.prs_cod_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.premission_level_combo = new System.Windows.Forms.ComboBox();
            this.save_user_create_btn = new System.Windows.Forms.Button();
            this.dep_name_lb = new System.Windows.Forms.Label();
            this.dep_id = new System.Windows.Forms.Label();
            this.dep_name_box = new System.Windows.Forms.TextBox();
            this.dep_id_box = new System.Windows.Forms.TextBox();
            this.save_dep_btn = new System.Windows.Forms.Button();
            this.save_machine_btn = new System.Windows.Forms.Button();
            this.machine_id_box = new System.Windows.Forms.TextBox();
            this.machine_name_box = new System.Windows.Forms.TextBox();
            this.machine_id_lb = new System.Windows.Forms.Label();
            this.machine_name_lb = new System.Windows.Forms.Label();
            this.dep_combo = new System.Windows.Forms.ComboBox();
            this.machine_combo = new System.Windows.Forms.ComboBox();
            this.dep_lb = new System.Windows.Forms.Label();
            this.machine_lb = new System.Windows.Forms.Label();
            this.save_sync_mach_dep_btn = new System.Windows.Forms.Button();
            this.test_name_lb = new System.Windows.Forms.Label();
            this.test_name_box = new System.Windows.Forms.TextBox();
            this.test_machine_lb = new System.Windows.Forms.Label();
            this.test_machine_combo = new System.Windows.Forms.ComboBox();
            this.test_text_lb = new System.Windows.Forms.Label();
            this.test_text_box = new System.Windows.Forms.TextBox();
            this.save_test_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_user
            // 
            this.create_user.Location = new System.Drawing.Point(692, 13);
            this.create_user.Name = "create_user";
            this.create_user.Size = new System.Drawing.Size(96, 23);
            this.create_user.TabIndex = 0;
            this.create_user.Text = "تعریف کاربر";
            this.create_user.UseVisualStyleBackColor = true;
            this.create_user.Click += new System.EventHandler(this.create_user_Click);
            // 
            // create_dep
            // 
            this.create_dep.Location = new System.Drawing.Point(581, 13);
            this.create_dep.Name = "create_dep";
            this.create_dep.Size = new System.Drawing.Size(75, 23);
            this.create_dep.TabIndex = 1;
            this.create_dep.Text = "تعریف بخش";
            this.create_dep.UseVisualStyleBackColor = true;
            this.create_dep.Click += new System.EventHandler(this.create_dep_Click);
            // 
            // create_machine
            // 
            this.create_machine.Location = new System.Drawing.Point(446, 12);
            this.create_machine.Name = "create_machine";
            this.create_machine.Size = new System.Drawing.Size(85, 23);
            this.create_machine.TabIndex = 2;
            this.create_machine.Text = "تعریف دستگاه";
            this.create_machine.UseVisualStyleBackColor = true;
            this.create_machine.Click += new System.EventHandler(this.create_machine_Click);
            // 
            // create_test
            // 
            this.create_test.Location = new System.Drawing.Point(87, 12);
            this.create_test.Name = "create_test";
            this.create_test.Size = new System.Drawing.Size(75, 23);
            this.create_test.TabIndex = 3;
            this.create_test.Text = "تعریف تست";
            this.create_test.UseVisualStyleBackColor = true;
            this.create_test.Click += new System.EventHandler(this.create_test_Click);
            // 
            // connect_mach_dep
            // 
            this.connect_mach_dep.Location = new System.Drawing.Point(276, 13);
            this.connect_mach_dep.Name = "connect_mach_dep";
            this.connect_mach_dep.Size = new System.Drawing.Size(128, 23);
            this.connect_mach_dep.TabIndex = 4;
            this.connect_mach_dep.Text = "ارتباط دستگاه با بخش";
            this.connect_mach_dep.UseVisualStyleBackColor = true;
            this.connect_mach_dep.Click += new System.EventHandler(this.connect_mach_dep_Click);
            // 
            // pr_code_lb
            // 
            this.pr_code_lb.AutoSize = true;
            this.pr_code_lb.Location = new System.Drawing.Point(714, 65);
            this.pr_code_lb.Name = "pr_code_lb";
            this.pr_code_lb.Size = new System.Drawing.Size(57, 13);
            this.pr_code_lb.TabIndex = 5;
            this.pr_code_lb.Text = "کد پرسنلی";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Location = new System.Drawing.Point(736, 104);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(22, 13);
            this.password_lb.TabIndex = 6;
            this.password_lb.Text = "رمز";
            // 
            // premission_level_lb
            // 
            this.premission_level_lb.AutoSize = true;
            this.premission_level_lb.Location = new System.Drawing.Point(712, 143);
            this.premission_level_lb.Name = "premission_level_lb";
            this.premission_level_lb.Size = new System.Drawing.Size(76, 13);
            this.premission_level_lb.TabIndex = 7;
            this.premission_level_lb.Text = "سطح دسترسی";
            // 
            // prs_cod_box
            // 
            this.prs_cod_box.Enabled = false;
            this.prs_cod_box.Location = new System.Drawing.Point(692, 81);
            this.prs_cod_box.Name = "prs_cod_box";
            this.prs_cod_box.Size = new System.Drawing.Size(100, 20);
            this.prs_cod_box.TabIndex = 8;
            this.prs_cod_box.TextChanged += new System.EventHandler(this.prs_cod_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Enabled = false;
            this.password_box.Location = new System.Drawing.Point(692, 120);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 9;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // premission_level_combo
            // 
            this.premission_level_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.premission_level_combo.Enabled = false;
            this.premission_level_combo.FormattingEnabled = true;
            this.premission_level_combo.Items.AddRange(new object[] {
            "تایید نشده",
            "پرسنل",
            "ادمین"});
            this.premission_level_combo.Location = new System.Drawing.Point(692, 159);
            this.premission_level_combo.Name = "premission_level_combo";
            this.premission_level_combo.Size = new System.Drawing.Size(100, 21);
            this.premission_level_combo.TabIndex = 10;
            // 
            // save_user_create_btn
            // 
            this.save_user_create_btn.Enabled = false;
            this.save_user_create_btn.Location = new System.Drawing.Point(706, 233);
            this.save_user_create_btn.Name = "save_user_create_btn";
            this.save_user_create_btn.Size = new System.Drawing.Size(75, 23);
            this.save_user_create_btn.TabIndex = 11;
            this.save_user_create_btn.Text = "ذخیره کاربر";
            this.save_user_create_btn.UseVisualStyleBackColor = true;
            this.save_user_create_btn.Click += new System.EventHandler(this.save_user_create_btn_Click);
            // 
            // dep_name_lb
            // 
            this.dep_name_lb.AutoSize = true;
            this.dep_name_lb.Location = new System.Drawing.Point(595, 65);
            this.dep_name_lb.Name = "dep_name_lb";
            this.dep_name_lb.Size = new System.Drawing.Size(43, 13);
            this.dep_name_lb.TabIndex = 12;
            this.dep_name_lb.Text = "نام بخش";
            // 
            // dep_id
            // 
            this.dep_id.AutoSize = true;
            this.dep_id.Location = new System.Drawing.Point(592, 104);
            this.dep_id.Name = "dep_id";
            this.dep_id.Size = new System.Drawing.Size(52, 13);
            this.dep_id.TabIndex = 13;
            this.dep_id.Text = "ایدی بخش";
            // 
            // dep_name_box
            // 
            this.dep_name_box.Enabled = false;
            this.dep_name_box.Location = new System.Drawing.Point(567, 81);
            this.dep_name_box.Name = "dep_name_box";
            this.dep_name_box.Size = new System.Drawing.Size(100, 20);
            this.dep_name_box.TabIndex = 14;
            this.dep_name_box.TextChanged += new System.EventHandler(this.dep_name_box_TextChanged);
            // 
            // dep_id_box
            // 
            this.dep_id_box.Enabled = false;
            this.dep_id_box.Location = new System.Drawing.Point(567, 120);
            this.dep_id_box.Name = "dep_id_box";
            this.dep_id_box.ReadOnly = true;
            this.dep_id_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dep_id_box.Size = new System.Drawing.Size(100, 20);
            this.dep_id_box.TabIndex = 15;
            this.dep_id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_dep_btn
            // 
            this.save_dep_btn.Enabled = false;
            this.save_dep_btn.Location = new System.Drawing.Point(581, 232);
            this.save_dep_btn.Name = "save_dep_btn";
            this.save_dep_btn.Size = new System.Drawing.Size(75, 23);
            this.save_dep_btn.TabIndex = 16;
            this.save_dep_btn.Text = "ذخیره بخش";
            this.save_dep_btn.UseVisualStyleBackColor = true;
            this.save_dep_btn.Click += new System.EventHandler(this.save_dep_btn_Click);
            // 
            // save_machine_btn
            // 
            this.save_machine_btn.Enabled = false;
            this.save_machine_btn.Location = new System.Drawing.Point(435, 232);
            this.save_machine_btn.Name = "save_machine_btn";
            this.save_machine_btn.Size = new System.Drawing.Size(89, 23);
            this.save_machine_btn.TabIndex = 21;
            this.save_machine_btn.Text = "ذخیره دستگاه";
            this.save_machine_btn.UseVisualStyleBackColor = true;
            this.save_machine_btn.Click += new System.EventHandler(this.save_machine_btn_Click);
            // 
            // machine_id_box
            // 
            this.machine_id_box.Enabled = false;
            this.machine_id_box.Location = new System.Drawing.Point(435, 120);
            this.machine_id_box.Name = "machine_id_box";
            this.machine_id_box.ReadOnly = true;
            this.machine_id_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.machine_id_box.Size = new System.Drawing.Size(100, 20);
            this.machine_id_box.TabIndex = 20;
            this.machine_id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // machine_name_box
            // 
            this.machine_name_box.Enabled = false;
            this.machine_name_box.Location = new System.Drawing.Point(435, 81);
            this.machine_name_box.Name = "machine_name_box";
            this.machine_name_box.Size = new System.Drawing.Size(100, 20);
            this.machine_name_box.TabIndex = 19;
            // 
            // machine_id_lb
            // 
            this.machine_id_lb.AutoSize = true;
            this.machine_id_lb.Location = new System.Drawing.Point(454, 104);
            this.machine_id_lb.Name = "machine_id_lb";
            this.machine_id_lb.Size = new System.Drawing.Size(67, 13);
            this.machine_id_lb.TabIndex = 18;
            this.machine_id_lb.Text = "ایدی دستگاه";
            // 
            // machine_name_lb
            // 
            this.machine_name_lb.AutoSize = true;
            this.machine_name_lb.Location = new System.Drawing.Point(454, 65);
            this.machine_name_lb.Name = "machine_name_lb";
            this.machine_name_lb.Size = new System.Drawing.Size(58, 13);
            this.machine_name_lb.TabIndex = 17;
            this.machine_name_lb.Text = "نام دستگاه";
            // 
            // dep_combo
            // 
            this.dep_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dep_combo.Enabled = false;
            this.dep_combo.FormattingEnabled = true;
            this.dep_combo.Location = new System.Drawing.Point(283, 81);
            this.dep_combo.Name = "dep_combo";
            this.dep_combo.Size = new System.Drawing.Size(121, 21);
            this.dep_combo.TabIndex = 22;
            // 
            // machine_combo
            // 
            this.machine_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machine_combo.Enabled = false;
            this.machine_combo.FormattingEnabled = true;
            this.machine_combo.Location = new System.Drawing.Point(283, 118);
            this.machine_combo.Name = "machine_combo";
            this.machine_combo.Size = new System.Drawing.Size(121, 21);
            this.machine_combo.TabIndex = 23;
            // 
            // dep_lb
            // 
            this.dep_lb.AutoSize = true;
            this.dep_lb.Location = new System.Drawing.Point(333, 65);
            this.dep_lb.Name = "dep_lb";
            this.dep_lb.Size = new System.Drawing.Size(27, 13);
            this.dep_lb.TabIndex = 24;
            this.dep_lb.Text = "بخش";
            // 
            // machine_lb
            // 
            this.machine_lb.AutoSize = true;
            this.machine_lb.Location = new System.Drawing.Point(322, 105);
            this.machine_lb.Name = "machine_lb";
            this.machine_lb.Size = new System.Drawing.Size(42, 13);
            this.machine_lb.TabIndex = 25;
            this.machine_lb.Text = "دستگاه";
            // 
            // save_sync_mach_dep_btn
            // 
            this.save_sync_mach_dep_btn.Enabled = false;
            this.save_sync_mach_dep_btn.Location = new System.Drawing.Point(311, 232);
            this.save_sync_mach_dep_btn.Name = "save_sync_mach_dep_btn";
            this.save_sync_mach_dep_btn.Size = new System.Drawing.Size(75, 23);
            this.save_sync_mach_dep_btn.TabIndex = 26;
            this.save_sync_mach_dep_btn.Text = "ذخیره";
            this.save_sync_mach_dep_btn.UseVisualStyleBackColor = true;
            this.save_sync_mach_dep_btn.Click += new System.EventHandler(this.save_sync_mach_dep_btn_Click);
            // 
            // test_name_lb
            // 
            this.test_name_lb.AutoSize = true;
            this.test_name_lb.Location = new System.Drawing.Point(99, 65);
            this.test_name_lb.Name = "test_name_lb";
            this.test_name_lb.Size = new System.Drawing.Size(44, 13);
            this.test_name_lb.TabIndex = 27;
            this.test_name_lb.Text = "نام تست";
            // 
            // test_name_box
            // 
            this.test_name_box.Enabled = false;
            this.test_name_box.Location = new System.Drawing.Point(71, 81);
            this.test_name_box.Name = "test_name_box";
            this.test_name_box.Size = new System.Drawing.Size(100, 20);
            this.test_name_box.TabIndex = 28;
            // 
            // test_machine_lb
            // 
            this.test_machine_lb.AutoSize = true;
            this.test_machine_lb.Location = new System.Drawing.Point(101, 102);
            this.test_machine_lb.Name = "test_machine_lb";
            this.test_machine_lb.Size = new System.Drawing.Size(42, 13);
            this.test_machine_lb.TabIndex = 29;
            this.test_machine_lb.Text = "دستگاه";
            // 
            // test_machine_combo
            // 
            this.test_machine_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.test_machine_combo.Enabled = false;
            this.test_machine_combo.FormattingEnabled = true;
            this.test_machine_combo.Location = new System.Drawing.Point(71, 118);
            this.test_machine_combo.Name = "test_machine_combo";
            this.test_machine_combo.Size = new System.Drawing.Size(100, 21);
            this.test_machine_combo.TabIndex = 30;
            // 
            // test_text_lb
            // 
            this.test_text_lb.AutoSize = true;
            this.test_text_lb.Location = new System.Drawing.Point(102, 146);
            this.test_text_lb.Name = "test_text_lb";
            this.test_text_lb.Size = new System.Drawing.Size(47, 13);
            this.test_text_lb.TabIndex = 31;
            this.test_text_lb.Text = "متن تست";
            // 
            // test_text_box
            // 
            this.test_text_box.Enabled = false;
            this.test_text_box.Location = new System.Drawing.Point(49, 162);
            this.test_text_box.Multiline = true;
            this.test_text_box.Name = "test_text_box";
            this.test_text_box.Size = new System.Drawing.Size(157, 205);
            this.test_text_box.TabIndex = 32;
            // 
            // save_test_btn
            // 
            this.save_test_btn.Enabled = false;
            this.save_test_btn.Location = new System.Drawing.Point(87, 383);
            this.save_test_btn.Name = "save_test_btn";
            this.save_test_btn.Size = new System.Drawing.Size(75, 23);
            this.save_test_btn.TabIndex = 33;
            this.save_test_btn.Text = "ذخیره تست";
            this.save_test_btn.UseVisualStyleBackColor = true;
            this.save_test_btn.Click += new System.EventHandler(this.save_test_btn_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_test_btn);
            this.Controls.Add(this.test_text_box);
            this.Controls.Add(this.test_text_lb);
            this.Controls.Add(this.test_machine_combo);
            this.Controls.Add(this.test_machine_lb);
            this.Controls.Add(this.test_name_box);
            this.Controls.Add(this.test_name_lb);
            this.Controls.Add(this.save_sync_mach_dep_btn);
            this.Controls.Add(this.machine_lb);
            this.Controls.Add(this.dep_lb);
            this.Controls.Add(this.machine_combo);
            this.Controls.Add(this.dep_combo);
            this.Controls.Add(this.save_machine_btn);
            this.Controls.Add(this.machine_id_box);
            this.Controls.Add(this.machine_name_box);
            this.Controls.Add(this.machine_id_lb);
            this.Controls.Add(this.machine_name_lb);
            this.Controls.Add(this.save_dep_btn);
            this.Controls.Add(this.dep_id_box);
            this.Controls.Add(this.dep_name_box);
            this.Controls.Add(this.dep_id);
            this.Controls.Add(this.dep_name_lb);
            this.Controls.Add(this.save_user_create_btn);
            this.Controls.Add(this.premission_level_combo);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.prs_cod_box);
            this.Controls.Add(this.premission_level_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.pr_code_lb);
            this.Controls.Add(this.connect_mach_dep);
            this.Controls.Add(this.create_test);
            this.Controls.Add(this.create_machine);
            this.Controls.Add(this.create_dep);
            this.Controls.Add(this.create_user);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_user;
        private System.Windows.Forms.Button create_dep;
        private System.Windows.Forms.Button create_machine;
        private System.Windows.Forms.Button create_test;
        private System.Windows.Forms.Button connect_mach_dep;
        private System.Windows.Forms.Label pr_code_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label premission_level_lb;
        private System.Windows.Forms.TextBox prs_cod_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.ComboBox premission_level_combo;
        private System.Windows.Forms.Button save_user_create_btn;
        private System.Windows.Forms.Label dep_name_lb;
        private System.Windows.Forms.Label dep_id;
        private System.Windows.Forms.TextBox dep_name_box;
        private System.Windows.Forms.TextBox dep_id_box;
        private System.Windows.Forms.Button save_dep_btn;
        private System.Windows.Forms.Button save_machine_btn;
        private System.Windows.Forms.TextBox machine_id_box;
        private System.Windows.Forms.TextBox machine_name_box;
        private System.Windows.Forms.Label machine_id_lb;
        private System.Windows.Forms.Label machine_name_lb;
        private System.Windows.Forms.ComboBox dep_combo;
        private System.Windows.Forms.ComboBox machine_combo;
        private System.Windows.Forms.Label dep_lb;
        private System.Windows.Forms.Label machine_lb;
        private System.Windows.Forms.Button save_sync_mach_dep_btn;
        private System.Windows.Forms.Label test_name_lb;
        private System.Windows.Forms.TextBox test_name_box;
        private System.Windows.Forms.Label test_machine_lb;
        private System.Windows.Forms.ComboBox test_machine_combo;
        private System.Windows.Forms.Label test_text_lb;
        private System.Windows.Forms.TextBox test_text_box;
        private System.Windows.Forms.Button save_test_btn;
    }
}