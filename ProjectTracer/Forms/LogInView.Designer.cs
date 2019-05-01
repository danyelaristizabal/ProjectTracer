namespace ProjectTracer
{
    partial class LogInView
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.UserTxtB = new System.Windows.Forms.TextBox();
            this.UserBar = new System.Windows.Forms.RichTextBox();
            this.PswBar = new System.Windows.Forms.RichTextBox();
            this.PasswordIcon = new System.Windows.Forms.PictureBox();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(103, 351);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(200, 40);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.ForeColor = System.Drawing.Color.White;
            this.LogInBtn.Location = new System.Drawing.Point(103, 295);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(200, 40);
            this.LogInBtn.TabIndex = 7;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(166, 30);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(76, 31);
            this.UserLbl.TabIndex = 9;
            this.UserLbl.Text = "User";
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PasswordTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxtB.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtB.Location = new System.Drawing.Point(139, 220);
            this.PasswordTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.Size = new System.Drawing.Size(164, 29);
            this.PasswordTxtB.TabIndex = 10;
            this.PasswordTxtB.TabStop = false;
            this.PasswordTxtB.TextChanged += new System.EventHandler(this.PasswordTxtB_TextChanged);
            // 
            // UserTxtB
            // 
            this.UserTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.UserTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTxtB.ForeColor = System.Drawing.Color.White;
            this.UserTxtB.Location = new System.Drawing.Point(139, 165);
            this.UserTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.UserTxtB.Name = "UserTxtB";
            this.UserTxtB.Size = new System.Drawing.Size(164, 29);
            this.UserTxtB.TabIndex = 11;
            this.UserTxtB.TabStop = false;
            this.UserTxtB.TextChanged += new System.EventHandler(this.UserTxtB_TextChanged);
            // 
            // UserBar
            // 
            this.UserBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserBar.Location = new System.Drawing.Point(103, 203);
            this.UserBar.Name = "UserBar";
            this.UserBar.Size = new System.Drawing.Size(200, 1);
            this.UserBar.TabIndex = 12;
            this.UserBar.Text = "";
            // 
            // PswBar
            // 
            this.PswBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PswBar.Location = new System.Drawing.Point(103, 258);
            this.PswBar.Name = "PswBar";
            this.PswBar.Size = new System.Drawing.Size(200, 1);
            this.PswBar.TabIndex = 13;
            this.PswBar.Text = "";
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.PasswordIcon.BackgroundImage = global::ProjectTracer.Properties.Resources.login_1_;
            this.PasswordIcon.Location = new System.Drawing.Point(103, 220);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(32, 32);
            this.PasswordIcon.TabIndex = 16;
            this.PasswordIcon.TabStop = false;
            // 
            // UserIcon
            // 
            this.UserIcon.BackColor = System.Drawing.Color.Transparent;
            this.UserIcon.BackgroundImage = global::ProjectTracer.Properties.Resources.user_1_;
            this.UserIcon.Location = new System.Drawing.Point(103, 165);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(32, 32);
            this.UserIcon.TabIndex = 17;
            this.UserIcon.TabStop = false;
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround400x600;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.PasswordIcon);
            this.Controls.Add(this.PswBar);
            this.Controls.Add(this.UserBar);
            this.Controls.Add(this.UserTxtB);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LogInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.TextBox PasswordTxtB;
        private System.Windows.Forms.TextBox UserTxtB;
        private System.Windows.Forms.RichTextBox UserBar;
        private System.Windows.Forms.RichTextBox PswBar;
        private System.Windows.Forms.PictureBox PasswordIcon;
        private System.Windows.Forms.PictureBox UserIcon;
    }
}