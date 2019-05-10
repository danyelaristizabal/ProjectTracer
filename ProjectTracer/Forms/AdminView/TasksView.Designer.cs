namespace ProjectTracer.Forms
{
    partial class TasksView
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
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.Clients = new System.Windows.Forms.Button();
            this.DevelopersBtn = new System.Windows.Forms.Button();
            this.TasksBtn = new System.Windows.Forms.Button();
            this.ProjectsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.Button();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTask = new System.Windows.Forms.Button();
            this.NavigationBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavigationBar.Controls.Add(this.Clients);
            this.NavigationBar.Controls.Add(this.DevelopersBtn);
            this.NavigationBar.Controls.Add(this.TasksBtn);
            this.NavigationBar.Controls.Add(this.ProjectsBtn);
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationBar.Location = new System.Drawing.Point(0, 50);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(130, 550);
            this.NavigationBar.TabIndex = 3;
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.Transparent;
            this.Clients.FlatAppearance.BorderSize = 0;
            this.Clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients.ForeColor = System.Drawing.Color.White;
            this.Clients.Image = global::ProjectTracer.Properties.Resources.Clients64;
            this.Clients.Location = new System.Drawing.Point(3, 405);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(128, 145);
            this.Clients.TabIndex = 11;
            this.Clients.TabStop = false;
            this.Clients.Text = "Clients ";
            this.Clients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.Clients_Click_1);
            // 
            // DevelopersBtn
            // 
            this.DevelopersBtn.BackColor = System.Drawing.Color.Transparent;
            this.DevelopersBtn.FlatAppearance.BorderSize = 0;
            this.DevelopersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DevelopersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevelopersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevelopersBtn.ForeColor = System.Drawing.Color.White;
            this.DevelopersBtn.Image = global::ProjectTracer.Properties.Resources.Developers64;
            this.DevelopersBtn.Location = new System.Drawing.Point(3, 268);
            this.DevelopersBtn.Name = "DevelopersBtn";
            this.DevelopersBtn.Size = new System.Drawing.Size(128, 128);
            this.DevelopersBtn.TabIndex = 9;
            this.DevelopersBtn.Text = "Developers ";
            this.DevelopersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DevelopersBtn.UseVisualStyleBackColor = false;
            this.DevelopersBtn.Click += new System.EventHandler(this.DevelopersBtn_Click);
            // 
            // TasksBtn
            // 
            this.TasksBtn.BackColor = System.Drawing.Color.Silver;
            this.TasksBtn.FlatAppearance.BorderSize = 0;
            this.TasksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.TasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksBtn.ForeColor = System.Drawing.Color.White;
            this.TasksBtn.Image = global::ProjectTracer.Properties.Resources.Tasks64;
            this.TasksBtn.Location = new System.Drawing.Point(2, 134);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Size = new System.Drawing.Size(128, 128);
            this.TasksBtn.TabIndex = 10;
            this.TasksBtn.Text = "Tasks";
            this.TasksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TasksBtn.UseVisualStyleBackColor = false;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // ProjectsBtn
            // 
            this.ProjectsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProjectsBtn.FlatAppearance.BorderSize = 0;
            this.ProjectsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ProjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectsBtn.ForeColor = System.Drawing.Color.White;
            this.ProjectsBtn.Image = global::ProjectTracer.Properties.Resources.projects64;
            this.ProjectsBtn.Location = new System.Drawing.Point(2, 0);
            this.ProjectsBtn.Name = "ProjectsBtn";
            this.ProjectsBtn.Size = new System.Drawing.Size(128, 128);
            this.ProjectsBtn.TabIndex = 8;
            this.ProjectsBtn.Text = "Projects";
            this.ProjectsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProjectsBtn.UseVisualStyleBackColor = false;
            this.ProjectsBtn.Click += new System.EventHandler(this.ProjectsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 2;
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
            this.Minimize.TabIndex = 14;
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
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
            this.Close.TabIndex = 13;
            this.Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(374, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 1);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtBox.Location = new System.Drawing.Point(374, 73);
            this.PasswordTxtBox.MinimumSize = new System.Drawing.Size(100, 32);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(280, 32);
            this.PasswordTxtBox.TabIndex = 25;
            this.PasswordTxtBox.TabStop = false;
            // 
            // ProjectName
            // 
            this.ProjectName.BackColor = System.Drawing.Color.Transparent;
            this.ProjectName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(147, 73);
            this.ProjectName.MinimumSize = new System.Drawing.Size(212, 32);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(212, 39);
            this.ProjectName.TabIndex = 24;
            this.ProjectName.Text = "Project Name";
            this.ProjectName.UseVisualStyleBackColor = false;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(148, 125);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(840, 395);
            this.materialListView1.TabIndex = 27;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(374, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Delete Task";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.Transparent;
            this.AddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTask.ForeColor = System.Drawing.Color.White;
            this.AddTask.Location = new System.Drawing.Point(147, 536);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(200, 40);
            this.AddTask.TabIndex = 28;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = false;
            // 
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasksView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TasksView";
            this.Load += new System.EventHandler(this.TasksView_Load);
            this.NavigationBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavigationBar;
        private System.Windows.Forms.Button DevelopersBtn;
        private System.Windows.Forms.Button TasksBtn;
        private System.Windows.Forms.Button ProjectsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button ProjectName;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddTask;
    }
}