namespace ProjectTracer.Forms.AdminView
{
    partial class AddProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closr = new System.Windows.Forms.Button();
            this.Minimizr = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.ProjectIdLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.NameTxtB = new System.Windows.Forms.TextBox();
            this.DescriptionTxtB = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClientLbl = new System.Windows.Forms.Label();
            this.DeadLineTxtB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.ClientTxtB = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Closr);
            this.panel1.Controls.Add(this.Minimizr);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 45;
            // 
            // Closr
            // 
            this.Closr.BackColor = System.Drawing.Color.Transparent;
            this.Closr.FlatAppearance.BorderSize = 0;
            this.Closr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Closr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closr.ForeColor = System.Drawing.Color.White;
            this.Closr.Image = global::ProjectTracer.Properties.Resources.error;
            this.Closr.Location = new System.Drawing.Point(750, -3);
            this.Closr.Name = "Closr";
            this.Closr.Size = new System.Drawing.Size(50, 50);
            this.Closr.TabIndex = 17;
            this.Closr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Closr.UseVisualStyleBackColor = false;
            this.Closr.Click += new System.EventHandler(this.Closr_Click);
            // 
            // Minimizr
            // 
            this.Minimizr.BackColor = System.Drawing.Color.Transparent;
            this.Minimizr.FlatAppearance.BorderSize = 0;
            this.Minimizr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Minimizr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimizr.ForeColor = System.Drawing.Color.White;
            this.Minimizr.Image = global::ProjectTracer.Properties.Resources.minimize;
            this.Minimizr.Location = new System.Drawing.Point(705, 0);
            this.Minimizr.Name = "Minimizr";
            this.Minimizr.Size = new System.Drawing.Size(50, 50);
            this.Minimizr.TabIndex = 16;
            this.Minimizr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Minimizr.UseVisualStyleBackColor = false;
            this.Minimizr.Click += new System.EventHandler(this.Minimizr_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Image = global::ProjectTracer.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(894, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 12;
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Minimize.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::ProjectTracer.Properties.Resources.error;
            this.Close.Location = new System.Drawing.Point(950, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 11;
            this.Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close.UseVisualStyleBackColor = false;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLbl.ForeColor = System.Drawing.Color.White;
            this.DescriptionLbl.Location = new System.Drawing.Point(151, 229);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(131, 25);
            this.DescriptionLbl.TabIndex = 43;
            this.DescriptionLbl.Text = "Description";
            // 
            // ProjectIdLbl
            // 
            this.ProjectIdLbl.AutoSize = true;
            this.ProjectIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectIdLbl.ForeColor = System.Drawing.Color.White;
            this.ProjectIdLbl.Location = new System.Drawing.Point(129, 162);
            this.ProjectIdLbl.Name = "ProjectIdLbl";
            this.ProjectIdLbl.Size = new System.Drawing.Size(153, 25);
            this.ProjectIdLbl.TabIndex = 42;
            this.ProjectIdLbl.Text = "Project Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(296, 260);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 1);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(296, 193);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(280, 1);
            this.richTextBox2.TabIndex = 38;
            this.richTextBox2.Text = "";
            // 
            // NameTxtB
            // 
            this.NameTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.NameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxtB.ForeColor = System.Drawing.Color.White;
            this.NameTxtB.Location = new System.Drawing.Point(296, 155);
            this.NameTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.NameTxtB.Name = "NameTxtB";
            this.NameTxtB.Size = new System.Drawing.Size(280, 29);
            this.NameTxtB.TabIndex = 37;
            this.NameTxtB.TabStop = false;
            // 
            // DescriptionTxtB
            // 
            this.DescriptionTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.DescriptionTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTxtB.ForeColor = System.Drawing.Color.White;
            this.DescriptionTxtB.Location = new System.Drawing.Point(296, 222);
            this.DescriptionTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.DescriptionTxtB.Name = "DescriptionTxtB";
            this.DescriptionTxtB.Size = new System.Drawing.Size(280, 29);
            this.DescriptionTxtB.TabIndex = 36;
            this.DescriptionTxtB.TabStop = false;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(473, 491);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(200, 40);
            this.RegisterBtn.TabIndex = 46;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClientLbl
            // 
            this.ClientLbl.AutoSize = true;
            this.ClientLbl.BackColor = System.Drawing.Color.Transparent;
            this.ClientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLbl.ForeColor = System.Drawing.Color.White;
            this.ClientLbl.Location = new System.Drawing.Point(209, 346);
            this.ClientLbl.Name = "ClientLbl";
            this.ClientLbl.Size = new System.Drawing.Size(73, 25);
            this.ClientLbl.TabIndex = 49;
            this.ClientLbl.Text = "Client";
            // 
            // DeadLineTxtB
            // 
            this.DeadLineTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.DeadLineTxtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeadLineTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeadLineTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeadLineTxtB.ForeColor = System.Drawing.Color.White;
            this.DeadLineTxtB.Location = new System.Drawing.Point(296, 286);
            this.DeadLineTxtB.Mask = "0000-00-00";
            this.DeadLineTxtB.MinimumSize = new System.Drawing.Size(0, 32);
            this.DeadLineTxtB.Name = "DeadLineTxtB";
            this.DeadLineTxtB.Size = new System.Drawing.Size(280, 22);
            this.DeadLineTxtB.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "DeadLine";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(296, 317);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(280, 1);
            this.richTextBox3.TabIndex = 52;
            this.richTextBox3.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox6.Location = new System.Drawing.Point(296, 377);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(280, 1);
            this.richTextBox6.TabIndex = 56;
            this.richTextBox6.Text = "";
            // 
            // ClientTxtB
            // 
            this.ClientTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientTxtB.ForeColor = System.Drawing.Color.White;
            this.ClientTxtB.Location = new System.Drawing.Point(296, 339);
            this.ClientTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.ClientTxtB.Name = "ClientTxtB";
            this.ClientTxtB.Size = new System.Drawing.Size(280, 29);
            this.ClientTxtB.TabIndex = 55;
            this.ClientTxtB.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(240, 491);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(200, 40);
            this.CancelBtn.TabIndex = 57;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround400x600;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.ClientTxtB);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeadLineTxtB);
            this.Controls.Add(this.ClientLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.ProjectIdLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.NameTxtB);
            this.Controls.Add(this.DescriptionTxtB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Closr;
        private System.Windows.Forms.Button Minimizr;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label ProjectIdLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox NameTxtB;
        private System.Windows.Forms.TextBox DescriptionTxtB;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label ClientLbl;
        private System.Windows.Forms.MaskedTextBox DeadLineTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.TextBox ClientTxtB;
        private System.Windows.Forms.Button CancelBtn;
    }
}