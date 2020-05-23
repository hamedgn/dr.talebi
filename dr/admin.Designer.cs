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
            this.components = new System.ComponentModel.Container();
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
            this.edit_user_test_btn = new System.Windows.Forms.Button();
            this.qus_tab = new System.Windows.Forms.TabPage();
            this.test_time_test_datepicker = new System.Windows.Forms.DateTimePicker();
            this.pr_cod_test_combo = new System.Windows.Forms.ComboBox();
            this.save_edit_test_btn = new System.Windows.Forms.Button();
            this.user_answ_test_box = new System.Windows.Forms.TextBox();
            this.user_answ_test_lb = new System.Windows.Forms.Label();
            this.time_test_test_lb = new System.Windows.Forms.Label();
            this.test_num_test_combo = new System.Windows.Forms.ComboBox();
            this.test_num_test_lb = new System.Windows.Forms.Label();
            this.pr_cod_test_lb = new System.Windows.Forms.Label();
            this.uesr_tab = new System.Windows.Forms.TabPage();
            this.pr_cod_user_combo = new System.Windows.Forms.ComboBox();
            this.save_edit_user_btn = new System.Windows.Forms.Button();
            this.user_answ_user_box = new System.Windows.Forms.TextBox();
            this.user_answ_user_lb = new System.Windows.Forms.Label();
            this.time_test_user_lb = new System.Windows.Forms.Label();
            this.test_num_user_combo = new System.Windows.Forms.ComboBox();
            this.test_num_user_lb = new System.Windows.Forms.Label();
            this.pr_cod_user_lb = new System.Windows.Forms.Label();
            this.edit_qus_user_tab = new System.Windows.Forms.TabControl();
            this.timer_get_test_user = new System.Windows.Forms.Timer(this.components);
            this.test_time_user_datepicker = new System.Windows.Forms.DateTimePicker();
            this.timer_get_user_test = new System.Windows.Forms.Timer(this.components);
            this.qus_tab.SuspendLayout();
            this.uesr_tab.SuspendLayout();
            this.edit_qus_user_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_user
            // 
            this.create_user.Location = new System.Drawing.Point(873, 12);
            this.create_user.Name = "create_user";
            this.create_user.Size = new System.Drawing.Size(96, 23);
            this.create_user.TabIndex = 0;
            this.create_user.Text = "تعریف کاربر";
            this.create_user.UseVisualStyleBackColor = true;
            this.create_user.Click += new System.EventHandler(this.create_user_Click);
            // 
            // create_dep
            // 
            this.create_dep.Location = new System.Drawing.Point(762, 12);
            this.create_dep.Name = "create_dep";
            this.create_dep.Size = new System.Drawing.Size(75, 23);
            this.create_dep.TabIndex = 1;
            this.create_dep.Text = "تعریف بخش";
            this.create_dep.UseVisualStyleBackColor = true;
            this.create_dep.Click += new System.EventHandler(this.create_dep_Click);
            // 
            // create_machine
            // 
            this.create_machine.Location = new System.Drawing.Point(627, 11);
            this.create_machine.Name = "create_machine";
            this.create_machine.Size = new System.Drawing.Size(85, 23);
            this.create_machine.TabIndex = 2;
            this.create_machine.Text = "تعریف دستگاه";
            this.create_machine.UseVisualStyleBackColor = true;
            this.create_machine.Click += new System.EventHandler(this.create_machine_Click);
            // 
            // create_test
            // 
            this.create_test.Location = new System.Drawing.Point(268, 11);
            this.create_test.Name = "create_test";
            this.create_test.Size = new System.Drawing.Size(75, 23);
            this.create_test.TabIndex = 3;
            this.create_test.Text = "تعریف تست";
            this.create_test.UseVisualStyleBackColor = true;
            this.create_test.Click += new System.EventHandler(this.create_test_Click);
            // 
            // connect_mach_dep
            // 
            this.connect_mach_dep.Location = new System.Drawing.Point(457, 12);
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
            this.pr_code_lb.Location = new System.Drawing.Point(895, 64);
            this.pr_code_lb.Name = "pr_code_lb";
            this.pr_code_lb.Size = new System.Drawing.Size(57, 13);
            this.pr_code_lb.TabIndex = 5;
            this.pr_code_lb.Text = "کد پرسنلی";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Location = new System.Drawing.Point(917, 103);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(22, 13);
            this.password_lb.TabIndex = 6;
            this.password_lb.Text = "رمز";
            // 
            // premission_level_lb
            // 
            this.premission_level_lb.AutoSize = true;
            this.premission_level_lb.Location = new System.Drawing.Point(893, 142);
            this.premission_level_lb.Name = "premission_level_lb";
            this.premission_level_lb.Size = new System.Drawing.Size(76, 13);
            this.premission_level_lb.TabIndex = 7;
            this.premission_level_lb.Text = "سطح دسترسی";
            // 
            // prs_cod_box
            // 
            this.prs_cod_box.Enabled = false;
            this.prs_cod_box.Location = new System.Drawing.Point(873, 80);
            this.prs_cod_box.Name = "prs_cod_box";
            this.prs_cod_box.Size = new System.Drawing.Size(100, 20);
            this.prs_cod_box.TabIndex = 8;
            this.prs_cod_box.TextChanged += new System.EventHandler(this.prs_cod_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Enabled = false;
            this.password_box.Location = new System.Drawing.Point(873, 119);
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
            this.premission_level_combo.Location = new System.Drawing.Point(873, 158);
            this.premission_level_combo.Name = "premission_level_combo";
            this.premission_level_combo.Size = new System.Drawing.Size(100, 21);
            this.premission_level_combo.TabIndex = 10;
            // 
            // save_user_create_btn
            // 
            this.save_user_create_btn.Enabled = false;
            this.save_user_create_btn.Location = new System.Drawing.Point(887, 232);
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
            this.dep_name_lb.Location = new System.Drawing.Point(776, 64);
            this.dep_name_lb.Name = "dep_name_lb";
            this.dep_name_lb.Size = new System.Drawing.Size(43, 13);
            this.dep_name_lb.TabIndex = 12;
            this.dep_name_lb.Text = "نام بخش";
            // 
            // dep_id
            // 
            this.dep_id.AutoSize = true;
            this.dep_id.Location = new System.Drawing.Point(773, 103);
            this.dep_id.Name = "dep_id";
            this.dep_id.Size = new System.Drawing.Size(52, 13);
            this.dep_id.TabIndex = 13;
            this.dep_id.Text = "ایدی بخش";
            // 
            // dep_name_box
            // 
            this.dep_name_box.Enabled = false;
            this.dep_name_box.Location = new System.Drawing.Point(748, 80);
            this.dep_name_box.Name = "dep_name_box";
            this.dep_name_box.Size = new System.Drawing.Size(100, 20);
            this.dep_name_box.TabIndex = 14;
            this.dep_name_box.TextChanged += new System.EventHandler(this.dep_name_box_TextChanged);
            // 
            // dep_id_box
            // 
            this.dep_id_box.Enabled = false;
            this.dep_id_box.Location = new System.Drawing.Point(748, 119);
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
            this.save_dep_btn.Location = new System.Drawing.Point(762, 231);
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
            this.save_machine_btn.Location = new System.Drawing.Point(616, 231);
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
            this.machine_id_box.Location = new System.Drawing.Point(616, 119);
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
            this.machine_name_box.Location = new System.Drawing.Point(616, 80);
            this.machine_name_box.Name = "machine_name_box";
            this.machine_name_box.Size = new System.Drawing.Size(100, 20);
            this.machine_name_box.TabIndex = 19;
            // 
            // machine_id_lb
            // 
            this.machine_id_lb.AutoSize = true;
            this.machine_id_lb.Location = new System.Drawing.Point(635, 103);
            this.machine_id_lb.Name = "machine_id_lb";
            this.machine_id_lb.Size = new System.Drawing.Size(67, 13);
            this.machine_id_lb.TabIndex = 18;
            this.machine_id_lb.Text = "ایدی دستگاه";
            // 
            // machine_name_lb
            // 
            this.machine_name_lb.AutoSize = true;
            this.machine_name_lb.Location = new System.Drawing.Point(635, 64);
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
            this.dep_combo.Location = new System.Drawing.Point(464, 80);
            this.dep_combo.Name = "dep_combo";
            this.dep_combo.Size = new System.Drawing.Size(121, 21);
            this.dep_combo.TabIndex = 22;
            // 
            // machine_combo
            // 
            this.machine_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machine_combo.Enabled = false;
            this.machine_combo.FormattingEnabled = true;
            this.machine_combo.Location = new System.Drawing.Point(464, 117);
            this.machine_combo.Name = "machine_combo";
            this.machine_combo.Size = new System.Drawing.Size(121, 21);
            this.machine_combo.TabIndex = 23;
            // 
            // dep_lb
            // 
            this.dep_lb.AutoSize = true;
            this.dep_lb.Location = new System.Drawing.Point(514, 64);
            this.dep_lb.Name = "dep_lb";
            this.dep_lb.Size = new System.Drawing.Size(27, 13);
            this.dep_lb.TabIndex = 24;
            this.dep_lb.Text = "بخش";
            // 
            // machine_lb
            // 
            this.machine_lb.AutoSize = true;
            this.machine_lb.Location = new System.Drawing.Point(503, 104);
            this.machine_lb.Name = "machine_lb";
            this.machine_lb.Size = new System.Drawing.Size(42, 13);
            this.machine_lb.TabIndex = 25;
            this.machine_lb.Text = "دستگاه";
            // 
            // save_sync_mach_dep_btn
            // 
            this.save_sync_mach_dep_btn.Enabled = false;
            this.save_sync_mach_dep_btn.Location = new System.Drawing.Point(492, 231);
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
            this.test_name_lb.Location = new System.Drawing.Point(280, 64);
            this.test_name_lb.Name = "test_name_lb";
            this.test_name_lb.Size = new System.Drawing.Size(44, 13);
            this.test_name_lb.TabIndex = 27;
            this.test_name_lb.Text = "نام تست";
            // 
            // test_name_box
            // 
            this.test_name_box.Enabled = false;
            this.test_name_box.Location = new System.Drawing.Point(252, 80);
            this.test_name_box.Name = "test_name_box";
            this.test_name_box.Size = new System.Drawing.Size(100, 20);
            this.test_name_box.TabIndex = 28;
            // 
            // test_machine_lb
            // 
            this.test_machine_lb.AutoSize = true;
            this.test_machine_lb.Location = new System.Drawing.Point(282, 101);
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
            this.test_machine_combo.Location = new System.Drawing.Point(252, 117);
            this.test_machine_combo.Name = "test_machine_combo";
            this.test_machine_combo.Size = new System.Drawing.Size(100, 21);
            this.test_machine_combo.TabIndex = 30;
            // 
            // test_text_lb
            // 
            this.test_text_lb.AutoSize = true;
            this.test_text_lb.Location = new System.Drawing.Point(283, 145);
            this.test_text_lb.Name = "test_text_lb";
            this.test_text_lb.Size = new System.Drawing.Size(47, 13);
            this.test_text_lb.TabIndex = 31;
            this.test_text_lb.Text = "متن تست";
            // 
            // test_text_box
            // 
            this.test_text_box.Enabled = false;
            this.test_text_box.Location = new System.Drawing.Point(230, 161);
            this.test_text_box.Multiline = true;
            this.test_text_box.Name = "test_text_box";
            this.test_text_box.Size = new System.Drawing.Size(157, 205);
            this.test_text_box.TabIndex = 32;
            // 
            // save_test_btn
            // 
            this.save_test_btn.Enabled = false;
            this.save_test_btn.Location = new System.Drawing.Point(268, 382);
            this.save_test_btn.Name = "save_test_btn";
            this.save_test_btn.Size = new System.Drawing.Size(75, 23);
            this.save_test_btn.TabIndex = 33;
            this.save_test_btn.Text = "ذخیره تست";
            this.save_test_btn.UseVisualStyleBackColor = true;
            this.save_test_btn.Click += new System.EventHandler(this.save_test_btn_Click);
            // 
            // edit_user_test_btn
            // 
            this.edit_user_test_btn.Location = new System.Drawing.Point(56, 12);
            this.edit_user_test_btn.Name = "edit_user_test_btn";
            this.edit_user_test_btn.Size = new System.Drawing.Size(102, 23);
            this.edit_user_test_btn.TabIndex = 34;
            this.edit_user_test_btn.Text = "ویرایش تست کاربر";
            this.edit_user_test_btn.UseVisualStyleBackColor = true;
            this.edit_user_test_btn.Click += new System.EventHandler(this.edit_user_test_btn_Click);
            // 
            // qus_tab
            // 
            this.qus_tab.BackColor = System.Drawing.SystemColors.Control;
            this.qus_tab.Controls.Add(this.test_time_test_datepicker);
            this.qus_tab.Controls.Add(this.pr_cod_test_combo);
            this.qus_tab.Controls.Add(this.save_edit_test_btn);
            this.qus_tab.Controls.Add(this.user_answ_test_box);
            this.qus_tab.Controls.Add(this.user_answ_test_lb);
            this.qus_tab.Controls.Add(this.time_test_test_lb);
            this.qus_tab.Controls.Add(this.test_num_test_combo);
            this.qus_tab.Controls.Add(this.test_num_test_lb);
            this.qus_tab.Controls.Add(this.pr_cod_test_lb);
            this.qus_tab.Location = new System.Drawing.Point(4, 22);
            this.qus_tab.Name = "qus_tab";
            this.qus_tab.Padding = new System.Windows.Forms.Padding(3);
            this.qus_tab.Size = new System.Drawing.Size(192, 333);
            this.qus_tab.TabIndex = 1;
            this.qus_tab.Text = "تست";
            this.qus_tab.Click += new System.EventHandler(this.qus_tab_Click);
            // 
            // test_time_test_datepicker
            // 
            this.test_time_test_datepicker.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.test_time_test_datepicker.AllowDrop = true;
            this.test_time_test_datepicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.test_time_test_datepicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.test_time_test_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.test_time_test_datepicker.Location = new System.Drawing.Point(6, 103);
            this.test_time_test_datepicker.Name = "test_time_test_datepicker";
            this.test_time_test_datepicker.Size = new System.Drawing.Size(178, 20);
            this.test_time_test_datepicker.TabIndex = 45;
            // 
            // pr_cod_test_combo
            // 
            this.pr_cod_test_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pr_cod_test_combo.FormattingEnabled = true;
            this.pr_cod_test_combo.Location = new System.Drawing.Point(6, 40);
            this.pr_cod_test_combo.Name = "pr_cod_test_combo";
            this.pr_cod_test_combo.Size = new System.Drawing.Size(121, 21);
            this.pr_cod_test_combo.TabIndex = 44;
            this.pr_cod_test_combo.SelectedIndexChanged += new System.EventHandler(this.pr_cod_test_combo_SelectedIndexChanged);
            // 
            // save_edit_test_btn
            // 
            this.save_edit_test_btn.Location = new System.Drawing.Point(52, 307);
            this.save_edit_test_btn.Name = "save_edit_test_btn";
            this.save_edit_test_btn.Size = new System.Drawing.Size(75, 23);
            this.save_edit_test_btn.TabIndex = 43;
            this.save_edit_test_btn.Text = "تایید ویرایش";
            this.save_edit_test_btn.UseVisualStyleBackColor = true;
            this.save_edit_test_btn.Click += new System.EventHandler(this.save_edit_test_btn_Click);
            // 
            // user_answ_test_box
            // 
            this.user_answ_test_box.Location = new System.Drawing.Point(6, 142);
            this.user_answ_test_box.Multiline = true;
            this.user_answ_test_box.Name = "user_answ_test_box";
            this.user_answ_test_box.Size = new System.Drawing.Size(178, 159);
            this.user_answ_test_box.TabIndex = 42;
            // 
            // user_answ_test_lb
            // 
            this.user_answ_test_lb.AutoSize = true;
            this.user_answ_test_lb.Location = new System.Drawing.Point(122, 126);
            this.user_answ_test_lb.Name = "user_answ_test_lb";
            this.user_answ_test_lb.Size = new System.Drawing.Size(63, 13);
            this.user_answ_test_lb.TabIndex = 41;
            this.user_answ_test_lb.Text = ":پاسخ کاربر";
            // 
            // time_test_test_lb
            // 
            this.time_test_test_lb.AutoSize = true;
            this.time_test_test_lb.Location = new System.Drawing.Point(134, 83);
            this.time_test_test_lb.Name = "time_test_test_lb";
            this.time_test_test_lb.Size = new System.Drawing.Size(55, 13);
            this.time_test_test_lb.TabIndex = 40;
            this.time_test_test_lb.Text = ":زمان تست";
            // 
            // test_num_test_combo
            // 
            this.test_num_test_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.test_num_test_combo.FormattingEnabled = true;
            this.test_num_test_combo.Location = new System.Drawing.Point(6, 11);
            this.test_num_test_combo.Name = "test_num_test_combo";
            this.test_num_test_combo.Size = new System.Drawing.Size(121, 21);
            this.test_num_test_combo.TabIndex = 39;
            this.test_num_test_combo.SelectedIndexChanged += new System.EventHandler(this.test_num_test_combo_SelectedIndexChanged);
            // 
            // test_num_test_lb
            // 
            this.test_num_test_lb.AutoSize = true;
            this.test_num_test_lb.Location = new System.Drawing.Point(127, 14);
            this.test_num_test_lb.Name = "test_num_test_lb";
            this.test_num_test_lb.Size = new System.Drawing.Size(31, 13);
            this.test_num_test_lb.TabIndex = 38;
            this.test_num_test_lb.Text = ":تست";
            // 
            // pr_cod_test_lb
            // 
            this.pr_cod_test_lb.AutoSize = true;
            this.pr_cod_test_lb.Location = new System.Drawing.Point(131, 43);
            this.pr_cod_test_lb.Name = "pr_cod_test_lb";
            this.pr_cod_test_lb.Size = new System.Drawing.Size(54, 13);
            this.pr_cod_test_lb.TabIndex = 37;
            this.pr_cod_test_lb.Text = ":کد پرسنل";
            // 
            // uesr_tab
            // 
            this.uesr_tab.BackColor = System.Drawing.SystemColors.Control;
            this.uesr_tab.Controls.Add(this.test_time_user_datepicker);
            this.uesr_tab.Controls.Add(this.pr_cod_user_combo);
            this.uesr_tab.Controls.Add(this.save_edit_user_btn);
            this.uesr_tab.Controls.Add(this.user_answ_user_box);
            this.uesr_tab.Controls.Add(this.user_answ_user_lb);
            this.uesr_tab.Controls.Add(this.time_test_user_lb);
            this.uesr_tab.Controls.Add(this.test_num_user_combo);
            this.uesr_tab.Controls.Add(this.test_num_user_lb);
            this.uesr_tab.Controls.Add(this.pr_cod_user_lb);
            this.uesr_tab.Location = new System.Drawing.Point(4, 22);
            this.uesr_tab.Name = "uesr_tab";
            this.uesr_tab.Padding = new System.Windows.Forms.Padding(3);
            this.uesr_tab.Size = new System.Drawing.Size(192, 333);
            this.uesr_tab.TabIndex = 0;
            this.uesr_tab.Text = "کاربر";
            this.uesr_tab.Click += new System.EventHandler(this.uesr_tab_Click);
            // 
            // pr_cod_user_combo
            // 
            this.pr_cod_user_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pr_cod_user_combo.FormattingEnabled = true;
            this.pr_cod_user_combo.Location = new System.Drawing.Point(6, 11);
            this.pr_cod_user_combo.Name = "pr_cod_user_combo";
            this.pr_cod_user_combo.Size = new System.Drawing.Size(121, 21);
            this.pr_cod_user_combo.TabIndex = 9;
            this.pr_cod_user_combo.SelectedIndexChanged += new System.EventHandler(this.pr_cod_user_combo_SelectedIndexChanged);
            // 
            // save_edit_user_btn
            // 
            this.save_edit_user_btn.Location = new System.Drawing.Point(52, 304);
            this.save_edit_user_btn.Name = "save_edit_user_btn";
            this.save_edit_user_btn.Size = new System.Drawing.Size(75, 23);
            this.save_edit_user_btn.TabIndex = 8;
            this.save_edit_user_btn.Text = "تایید ویرایش";
            this.save_edit_user_btn.UseVisualStyleBackColor = true;
            this.save_edit_user_btn.Click += new System.EventHandler(this.save_edit_user_btn_Click);
            // 
            // user_answ_user_box
            // 
            this.user_answ_user_box.Location = new System.Drawing.Point(7, 139);
            this.user_answ_user_box.Multiline = true;
            this.user_answ_user_box.Name = "user_answ_user_box";
            this.user_answ_user_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_answ_user_box.Size = new System.Drawing.Size(178, 159);
            this.user_answ_user_box.TabIndex = 7;
            // 
            // user_answ_user_lb
            // 
            this.user_answ_user_lb.AutoSize = true;
            this.user_answ_user_lb.Location = new System.Drawing.Point(123, 121);
            this.user_answ_user_lb.Name = "user_answ_user_lb";
            this.user_answ_user_lb.Size = new System.Drawing.Size(63, 13);
            this.user_answ_user_lb.TabIndex = 6;
            this.user_answ_user_lb.Text = ":پاسخ کاربر";
            // 
            // time_test_user_lb
            // 
            this.time_test_user_lb.AutoSize = true;
            this.time_test_user_lb.Location = new System.Drawing.Point(134, 81);
            this.time_test_user_lb.Name = "time_test_user_lb";
            this.time_test_user_lb.Size = new System.Drawing.Size(55, 13);
            this.time_test_user_lb.TabIndex = 5;
            this.time_test_user_lb.Text = ":زمان تست";
            // 
            // test_num_user_combo
            // 
            this.test_num_user_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.test_num_user_combo.FormattingEnabled = true;
            this.test_num_user_combo.Location = new System.Drawing.Point(6, 40);
            this.test_num_user_combo.Name = "test_num_user_combo";
            this.test_num_user_combo.Size = new System.Drawing.Size(121, 21);
            this.test_num_user_combo.TabIndex = 3;
            this.test_num_user_combo.SelectedIndexChanged += new System.EventHandler(this.test_num_user_combo_SelectedIndexChanged);
            // 
            // test_num_user_lb
            // 
            this.test_num_user_lb.AutoSize = true;
            this.test_num_user_lb.Location = new System.Drawing.Point(130, 43);
            this.test_num_user_lb.Name = "test_num_user_lb";
            this.test_num_user_lb.Size = new System.Drawing.Size(31, 13);
            this.test_num_user_lb.TabIndex = 2;
            this.test_num_user_lb.Text = ":تست";
            // 
            // pr_cod_user_lb
            // 
            this.pr_cod_user_lb.AutoSize = true;
            this.pr_cod_user_lb.Location = new System.Drawing.Point(132, 11);
            this.pr_cod_user_lb.Name = "pr_cod_user_lb";
            this.pr_cod_user_lb.Size = new System.Drawing.Size(54, 13);
            this.pr_cod_user_lb.TabIndex = 0;
            this.pr_cod_user_lb.Text = ":کد پرسنل";
            // 
            // edit_qus_user_tab
            // 
            this.edit_qus_user_tab.Controls.Add(this.uesr_tab);
            this.edit_qus_user_tab.Controls.Add(this.qus_tab);
            this.edit_qus_user_tab.Enabled = false;
            this.edit_qus_user_tab.Location = new System.Drawing.Point(12, 55);
            this.edit_qus_user_tab.Name = "edit_qus_user_tab";
            this.edit_qus_user_tab.SelectedIndex = 0;
            this.edit_qus_user_tab.Size = new System.Drawing.Size(200, 359);
            this.edit_qus_user_tab.TabIndex = 35;
            // 
            // timer_get_test_user
            // 
            this.timer_get_test_user.Tick += new System.EventHandler(this.timer_get_test_user_Tick);
            // 
            // test_time_user_datepicker
            // 
            this.test_time_user_datepicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.test_time_user_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.test_time_user_datepicker.Location = new System.Drawing.Point(8, 98);
            this.test_time_user_datepicker.Name = "test_time_user_datepicker";
            this.test_time_user_datepicker.Size = new System.Drawing.Size(177, 20);
            this.test_time_user_datepicker.TabIndex = 11;
            this.test_time_user_datepicker.Value = new System.DateTime(2020, 5, 23, 19, 8, 0, 0);
            // 
            // timer_get_user_test
            // 
            this.timer_get_user_test.Tick += new System.EventHandler(this.timer_get_user_test_Tick);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.edit_qus_user_tab);
            this.Controls.Add(this.edit_user_test_btn);
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
            this.qus_tab.ResumeLayout(false);
            this.qus_tab.PerformLayout();
            this.uesr_tab.ResumeLayout(false);
            this.uesr_tab.PerformLayout();
            this.edit_qus_user_tab.ResumeLayout(false);
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
        private System.Windows.Forms.Button edit_user_test_btn;
        private System.Windows.Forms.TabPage qus_tab;
        private System.Windows.Forms.DateTimePicker test_time_test_datepicker;
        private System.Windows.Forms.ComboBox pr_cod_test_combo;
        private System.Windows.Forms.Button save_edit_test_btn;
        private System.Windows.Forms.TextBox user_answ_test_box;
        private System.Windows.Forms.Label user_answ_test_lb;
        private System.Windows.Forms.Label time_test_test_lb;
        private System.Windows.Forms.ComboBox test_num_test_combo;
        private System.Windows.Forms.Label test_num_test_lb;
        private System.Windows.Forms.Label pr_cod_test_lb;
        private System.Windows.Forms.TabPage uesr_tab;
        private System.Windows.Forms.ComboBox pr_cod_user_combo;
        private System.Windows.Forms.Button save_edit_user_btn;
        private System.Windows.Forms.TextBox user_answ_user_box;
        private System.Windows.Forms.Label user_answ_user_lb;
        private System.Windows.Forms.Label time_test_user_lb;
        private System.Windows.Forms.ComboBox test_num_user_combo;
        private System.Windows.Forms.Label test_num_user_lb;
        private System.Windows.Forms.Label pr_cod_user_lb;
        private System.Windows.Forms.TabControl edit_qus_user_tab;
        private System.Windows.Forms.Timer timer_get_test_user;
        private System.Windows.Forms.DateTimePicker test_time_user_datepicker;
        private System.Windows.Forms.Timer timer_get_user_test;
    }
}