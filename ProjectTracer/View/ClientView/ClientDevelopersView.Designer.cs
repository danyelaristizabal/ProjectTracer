﻿namespace ProjectTracer.Forms.ClientView
{
    partial class ClientDevelopersView
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
            this.ShowALL = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.Label();
            this.Developers = new System.Windows.Forms.Label();
            this.DevelopersListView = new MaterialSkin.Controls.MaterialListView();
            this.Developer_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamsListView = new MaterialSkin.Controls.MaterialListView();
            this.Team_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.DevelopersBtn.BackColor = System.Drawing.Color.Silver;
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
            // 
            // TasksBtn
            // 
            this.TasksBtn.BackColor = System.Drawing.Color.Transparent;
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
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 13;
            this.Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ShowALL
            // 
            this.ShowALL.BackColor = System.Drawing.Color.Transparent;
            this.ShowALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ShowALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowALL.ForeColor = System.Drawing.Color.White;
            this.ShowALL.Location = new System.Drawing.Point(136, 67);
            this.ShowALL.Name = "ShowALL";
            this.ShowALL.Size = new System.Drawing.Size(848, 40);
            this.ShowALL.TabIndex = 51;
            this.ShowALL.Text = "SHOW ALL";
            this.ShowALL.UseVisualStyleBackColor = false;
            this.ShowALL.Click += new System.EventHandler(this.ShowALL_Click);
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.BackColor = System.Drawing.Color.Transparent;
            this.Teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teams.ForeColor = System.Drawing.Color.White;
            this.Teams.Location = new System.Drawing.Point(134, 129);
            this.Teams.MinimumSize = new System.Drawing.Size(400, 32);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(400, 32);
            this.Teams.TabIndex = 50;
            this.Teams.Text = "Teams";
            this.Teams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.BackColor = System.Drawing.Color.Transparent;
            this.Developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Developers.ForeColor = System.Drawing.Color.White;
            this.Developers.Location = new System.Drawing.Point(574, 129);
            this.Developers.MinimumSize = new System.Drawing.Size(400, 32);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(400, 32);
            this.Developers.TabIndex = 49;
            this.Developers.Text = "Developers";
            this.Developers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevelopersListView
            // 
            this.DevelopersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DevelopersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Developer_Id});
            this.DevelopersListView.Depth = 0;
            this.DevelopersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DevelopersListView.FullRowSelect = true;
            this.DevelopersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DevelopersListView.Location = new System.Drawing.Point(563, 164);
            this.DevelopersListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DevelopersListView.MouseState = MaterialSkin.MouseState.OUT;
            this.DevelopersListView.Name = "DevelopersListView";
            this.DevelopersListView.OwnerDraw = true;
            this.DevelopersListView.Size = new System.Drawing.Size(421, 413);
            this.DevelopersListView.TabIndex = 48;
            this.DevelopersListView.UseCompatibleStateImageBehavior = false;
            this.DevelopersListView.View = System.Windows.Forms.View.Details;
            // 
            // Developer_Id
            // 
            this.Developer_Id.Text = "Developer";
            this.Developer_Id.Width = 423;
            // 
            // TeamsListView
            // 
            this.TeamsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team_Id,
            this.Senior,
            this.Project});
            this.TeamsListView.Depth = 0;
            this.TeamsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TeamsListView.FullRowSelect = true;
            this.TeamsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TeamsListView.Location = new System.Drawing.Point(139, 164);
            this.TeamsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TeamsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.TeamsListView.Name = "TeamsListView";
            this.TeamsListView.OwnerDraw = true;
            this.TeamsListView.Size = new System.Drawing.Size(418, 413);
            this.TeamsListView.TabIndex = 47;
            this.TeamsListView.UseCompatibleStateImageBehavior = false;
            this.TeamsListView.View = System.Windows.Forms.View.Details;
            this.TeamsListView.ItemActivate += new System.EventHandler(this.TeamsListView_ItemActivate);
            // 
            // Team_Id
            // 
            this.Team_Id.Text = "Team";
            this.Team_Id.Width = 120;
            // 
            // Senior
            // 
            this.Senior.Text = "Senior";
            this.Senior.Width = 150;
            // 
            // Project
            // 
            this.Project.Text = "Project";
            this.Project.Width = 150;
            // 
            // ClientDevelopersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ShowALL);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.DevelopersListView);
            this.Controls.Add(this.TeamsListView);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientDevelopersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDevelopersView";
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
        private System.Windows.Forms.Button ShowALL;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Label Developers;
        private MaterialSkin.Controls.MaterialListView DevelopersListView;
        private System.Windows.Forms.ColumnHeader Developer_Id;
        private MaterialSkin.Controls.MaterialListView TeamsListView;
        private System.Windows.Forms.ColumnHeader Team_Id;
        private System.Windows.Forms.ColumnHeader Senior;
        private System.Windows.Forms.ColumnHeader Project;
    }
}