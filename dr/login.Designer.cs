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
            this.pr_cod_lb = new System.Windows.Forms.Label();
            this.passcod_lb = new System.Windows.Forms.Label();
            this.pr_cod_box = new System.Windows.Forms.TextBox();
            this.passcod_box = new System.Windows.Forms.TextBox();
            this.choose_dp_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.time_lb = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.choose_dp_DUD = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // pr_cod_lb
            // 
            this.pr_cod_lb.AutoSize = true;
            this.pr_cod_lb.Location = new System.Drawing.Point(328, 32);
            this.pr_cod_lb.Name = "pr_cod_lb";
            this.pr_cod_lb.Size = new System.Drawing.Size(57, 13);
            this.pr_cod_lb.TabIndex = 0;
            this.pr_cod_lb.Text = "کد پرسنلی";
            this.pr_cod_lb.Click += new System.EventHandler(this.pr_cod_lb_Click);
            // 
            // passcod_lb
            // 
            this.passcod_lb.AutoSize = true;
            this.passcod_lb.Location = new System.Drawing.Point(328, 67);
            this.passcod_lb.Name = "passcod_lb";
            this.passcod_lb.Size = new System.Drawing.Size(47, 13);
            this.passcod_lb.TabIndex = 1;
            this.passcod_lb.Text = "رمز عبور";
            this.passcod_lb.Click += new System.EventHandler(this.passcod_lb_Click);
            // 
            // pr_cod_box
            // 
            this.pr_cod_box.Location = new System.Drawing.Point(202, 29);
            this.pr_cod_box.Name = "pr_cod_box";
            this.pr_cod_box.Size = new System.Drawing.Size(120, 20);
            this.pr_cod_box.TabIndex = 2;
            // 
            // passcod_box
            // 
            this.passcod_box.Location = new System.Drawing.Point(202, 67);
            this.passcod_box.Name = "passcod_box";
            this.passcod_box.Size = new System.Drawing.Size(120, 20);
            this.passcod_box.TabIndex = 3;
            // 
            // choose_dp_lb
            // 
            this.choose_dp_lb.AutoSize = true;
            this.choose_dp_lb.Location = new System.Drawing.Point(331, 104);
            this.choose_dp_lb.Name = "choose_dp_lb";
            this.choose_dp_lb.Size = new System.Drawing.Size(60, 13);
            this.choose_dp_lb.TabIndex = 4;
            this.choose_dp_lb.Text = "انتخاب بخش";
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
            this.time_lb.Text = "21:34:56";
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(247, 147);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 23);
            this.enter_btn.TabIndex = 8;
            this.enter_btn.Text = "ورود";
            this.enter_btn.UseVisualStyleBackColor = true;
            // 
            // choose_dp_DUD
            // 
            this.choose_dp_DUD.Location = new System.Drawing.Point(202, 102);
            this.choose_dp_DUD.Name = "choose_dp_DUD";
            this.choose_dp_DUD.ReadOnly = true;
            this.choose_dp_DUD.Size = new System.Drawing.Size(120, 20);
            this.choose_dp_DUD.TabIndex = 5;
            this.choose_dp_DUD.SelectedItemChanged += new System.EventHandler(this.choose_dp_DUD_SelectedItemChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 182);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.choose_dp_DUD);
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
        private System.Windows.Forms.DomainUpDown choose_dp_DUD;
    }
}

