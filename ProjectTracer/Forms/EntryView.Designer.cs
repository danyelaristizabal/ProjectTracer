namespace ProjectTracer
{
    partial class EntryView
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.Developer = new System.Windows.Forms.Button();
            this.SeniorDevBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::ProjectTracer.Properties.Resources.f5c55e90_4601_4bb1_9f3c_17d9e621208f;
            this.Logo.InitialImage = global::ProjectTracer.Properties.Resources.f5c55e90_4601_4bb1_9f3c_17d9e621208f;
            this.Logo.Location = new System.Drawing.Point(95, 38);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 200);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // ClientBtn
            // 
            this.ClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientBtn.ForeColor = System.Drawing.Color.White;
            this.ClientBtn.Location = new System.Drawing.Point(95, 284);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(200, 40);
            this.ClientBtn.TabIndex = 5;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = false;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // Developer
            // 
            this.Developer.BackColor = System.Drawing.Color.Transparent;
            this.Developer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Developer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Developer.ForeColor = System.Drawing.Color.White;
            this.Developer.Location = new System.Drawing.Point(95, 340);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(200, 40);
            this.Developer.TabIndex = 6;
            this.Developer.Text = "Developer";
            this.Developer.UseVisualStyleBackColor = false;
            this.Developer.Click += new System.EventHandler(this.Developer_Click);
            // 
            // SeniorDevBtn
            // 
            this.SeniorDevBtn.BackColor = System.Drawing.Color.Transparent;
            this.SeniorDevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.SeniorDevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeniorDevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeniorDevBtn.ForeColor = System.Drawing.Color.White;
            this.SeniorDevBtn.Location = new System.Drawing.Point(95, 396);
            this.SeniorDevBtn.Name = "SeniorDevBtn";
            this.SeniorDevBtn.Size = new System.Drawing.Size(200, 40);
            this.SeniorDevBtn.TabIndex = 7;
            this.SeniorDevBtn.Text = "SeniorDev";
            this.SeniorDevBtn.UseVisualStyleBackColor = false;
            this.SeniorDevBtn.Click += new System.EventHandler(this.SeniorDevBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminBtn.ForeColor = System.Drawing.Color.White;
            this.AdminBtn.Location = new System.Drawing.Point(95, 453);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(200, 40);
            this.AdminBtn.TabIndex = 8;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // EntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround400x600;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.SeniorDevBtn);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.ClientBtn);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button Developer;
        private System.Windows.Forms.Button SeniorDevBtn;
        private System.Windows.Forms.Button AdminBtn;
    }
}