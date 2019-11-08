namespace ProjectTracer.Forms
{
    partial class ClientsView
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
            this.ClientsViewList = new MaterialSkin.Controls.MaterialListView();
            this.Client_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminProjectsView = new MaterialSkin.Controls.MaterialListView();
            this.ProjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowALL = new System.Windows.Forms.Button();
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
            this.Clients.BackColor = System.Drawing.Color.Silver;
            this.Clients.FlatAppearance.BorderSize = 0;
            this.Clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients.ForeColor = System.Drawing.Color.White;
            this.Clients.Image = global::ProjectTracer.Properties.Resources.Clients64;
            this.Clients.Location = new System.Drawing.Point(2, 405);
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
            this.Minimize.TabIndex = 12;
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
            this.Close.TabIndex = 11;
            this.Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ClientsViewList
            // 
            this.ClientsViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client_Id});
            this.ClientsViewList.Depth = 0;
            this.ClientsViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ClientsViewList.FullRowSelect = true;
            this.ClientsViewList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ClientsViewList.HideSelection = false;
            this.ClientsViewList.Location = new System.Drawing.Point(179, 181);
            this.ClientsViewList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ClientsViewList.MouseState = MaterialSkin.MouseState.OUT;
            this.ClientsViewList.Name = "ClientsViewList";
            this.ClientsViewList.OwnerDraw = true;
            this.ClientsViewList.Size = new System.Drawing.Size(797, 179);
            this.ClientsViewList.TabIndex = 30;
            this.ClientsViewList.UseCompatibleStateImageBehavior = false;
            this.ClientsViewList.View = System.Windows.Forms.View.Details;
            this.ClientsViewList.ItemActivate += new System.EventHandler(this.ClientsViewList_ItemActivate);
            // 
            // Client_Id
            // 
            this.Client_Id.Text = "Client Name";
            this.Client_Id.Width = 800;
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(383, 128);
            this.UserLbl.MinimumSize = new System.Drawing.Size(400, 50);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(400, 50);
            this.UserLbl.TabIndex = 31;
            this.UserLbl.Text = "Clients ";
            this.UserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 363);
            this.label1.MinimumSize = new System.Drawing.Size(400, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "Projects ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminProjectsView
            // 
            this.AdminProjectsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminProjectsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectId,
            this.Description,
            this.DeadLine});
            this.AdminProjectsView.Depth = 0;
            this.AdminProjectsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminProjectsView.FullRowSelect = true;
            this.AdminProjectsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AdminProjectsView.HideSelection = false;
            this.AdminProjectsView.Location = new System.Drawing.Point(179, 416);
            this.AdminProjectsView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AdminProjectsView.MouseState = MaterialSkin.MouseState.OUT;
            this.AdminProjectsView.Name = "AdminProjectsView";
            this.AdminProjectsView.OwnerDraw = true;
            this.AdminProjectsView.Size = new System.Drawing.Size(797, 150);
            this.AdminProjectsView.TabIndex = 33;
            this.AdminProjectsView.UseCompatibleStateImageBehavior = false;
            this.AdminProjectsView.View = System.Windows.Forms.View.Details;
            this.AdminProjectsView.ItemActivate += new System.EventHandler(this.AdminProjectsView_ItemActivate);
            // 
            // ProjectId
            // 
            this.ProjectId.Text = "Project Name";
            this.ProjectId.Width = 180;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 340;
            // 
            // DeadLine
            // 
            this.DeadLine.Text = "DeadLine";
            this.DeadLine.Width = 300;
            // 
            // ShowALL
            // 
            this.ShowALL.BackColor = System.Drawing.Color.Transparent;
            this.ShowALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ShowALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowALL.ForeColor = System.Drawing.Color.White;
            this.ShowALL.Location = new System.Drawing.Point(140, 56);
            this.ShowALL.Name = "ShowALL";
            this.ShowALL.Size = new System.Drawing.Size(848, 40);
            this.ShowALL.TabIndex = 47;
            this.ShowALL.Text = "SHOW ALL";
            this.ShowALL.UseVisualStyleBackColor = false;
            this.ShowALL.Click += new System.EventHandler(this.ShowALL_Click);
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ShowALL);
            this.Controls.Add(this.AdminProjectsView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.ClientsViewList);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsView";
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
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private MaterialSkin.Controls.MaterialListView ClientsViewList;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Client_Id;
        private MaterialSkin.Controls.MaterialListView AdminProjectsView;
        private System.Windows.Forms.ColumnHeader ProjectId;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DeadLine;
        private System.Windows.Forms.Button ShowALL;
    }
}