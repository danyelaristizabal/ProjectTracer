﻿namespace ProjectTracer.Forms.ClientView
{
    partial class ClientTasksView
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
            this.DevelopersBtn = new System.Windows.Forms.Button();
            this.TasksBtn = new System.Windows.Forms.Button();
            this.ProjectsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ProjectsViewList = new MaterialSkin.Controls.MaterialListView();
            this.Project_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TasksViewList = new MaterialSkin.Controls.MaterialListView();
            this.Task_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeadlLineTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.Button();
            this.NavigationBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavigationBar.Controls.Add(this.DevelopersBtn);
            this.NavigationBar.Controls.Add(this.TasksBtn);
            this.NavigationBar.Controls.Add(this.ProjectsBtn);
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationBar.Location = new System.Drawing.Point(0, 50);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(130, 550);
            this.NavigationBar.TabIndex = 5;
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
            this.panel1.TabIndex = 4;
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
            this.Close.Size = new System.Drawing.Size(49, 50);
            this.Close.TabIndex = 13;
            this.Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ProjectsViewList
            // 
            this.ProjectsViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectsViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Project_Id,
            this.Description,
            this.DeadLine});
            this.ProjectsViewList.Depth = 0;
            this.ProjectsViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ProjectsViewList.FullRowSelect = true;
            this.ProjectsViewList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProjectsViewList.Location = new System.Drawing.Point(138, 109);
            this.ProjectsViewList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProjectsViewList.MouseState = MaterialSkin.MouseState.OUT;
            this.ProjectsViewList.Name = "ProjectsViewList";
            this.ProjectsViewList.OwnerDraw = true;
            this.ProjectsViewList.Size = new System.Drawing.Size(413, 405);
            this.ProjectsViewList.TabIndex = 35;
            this.ProjectsViewList.UseCompatibleStateImageBehavior = false;
            this.ProjectsViewList.View = System.Windows.Forms.View.Details;
            this.ProjectsViewList.ItemActivate += new System.EventHandler(this.ProjectsViewList_ItemActivate);
            // 
            // Project_Id
            // 
            this.Project_Id.Text = "Project Id";
            this.Project_Id.Width = 90;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 156;
            // 
            // DeadLine
            // 
            this.DeadLine.Text = "DeadLine";
            this.DeadLine.Width = 180;
            // 
            // TasksViewList
            // 
            this.TasksViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Task_Id,
            this.DescriptionTask,
            this.DeadlLineTask});
            this.TasksViewList.Depth = 0;
            this.TasksViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TasksViewList.FullRowSelect = true;
            this.TasksViewList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TasksViewList.Location = new System.Drawing.Point(557, 109);
            this.TasksViewList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TasksViewList.MouseState = MaterialSkin.MouseState.OUT;
            this.TasksViewList.Name = "TasksViewList";
            this.TasksViewList.OwnerDraw = true;
            this.TasksViewList.Size = new System.Drawing.Size(422, 405);
            this.TasksViewList.TabIndex = 34;
            this.TasksViewList.UseCompatibleStateImageBehavior = false;
            this.TasksViewList.View = System.Windows.Forms.View.Details;
            this.TasksViewList.ItemActivate += new System.EventHandler(this.TasksViewList_ItemActivate);
            // 
            // Task_Id
            // 
            this.Task_Id.Text = "Task";
            this.Task_Id.Width = 40;
            // 
            // DescriptionTask
            // 
            this.DescriptionTask.Text = "Description";
            this.DescriptionTask.Width = 196;
            // 
            // DeadlLineTask
            // 
            this.DeadlLineTask.Text = "DeadLine";
            this.DeadlLineTask.Width = 200;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(365, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 1);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.ForeColor = System.Drawing.Color.White;
            this.InputTextBox.Location = new System.Drawing.Point(365, 57);
            this.InputTextBox.MaxLength = 100;
            this.InputTextBox.MinimumSize = new System.Drawing.Size(100, 32);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(280, 29);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TabStop = false;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // ProjectName
            // 
            this.ProjectName.BackColor = System.Drawing.Color.Transparent;
            this.ProjectName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(138, 57);
            this.ProjectName.MinimumSize = new System.Drawing.Size(212, 32);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(212, 39);
            this.ProjectName.TabIndex = 31;
            this.ProjectName.Text = "Project Name";
            this.ProjectName.UseVisualStyleBackColor = false;
            this.ProjectName.Click += new System.EventHandler(this.ProjectName_Click);
            // 
            // ClientTasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ProjectsViewList);
            this.Controls.Add(this.TasksViewList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientTasksView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientTasksView";
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
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private MaterialSkin.Controls.MaterialListView ProjectsViewList;
        private System.Windows.Forms.ColumnHeader Project_Id;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DeadLine;
        private MaterialSkin.Controls.MaterialListView TasksViewList;
        private System.Windows.Forms.ColumnHeader Task_Id;
        private System.Windows.Forms.ColumnHeader DescriptionTask;
        private System.Windows.Forms.ColumnHeader DeadlLineTask;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ProjectName;
    }
}