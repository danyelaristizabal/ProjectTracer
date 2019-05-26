namespace ProjectTracer.Forms
{
    partial class DevelopersView
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
            this.TeamsListView = new MaterialSkin.Controls.MaterialListView();
            this.Team_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FindByProjectTxtB = new System.Windows.Forms.TextBox();
            this.FindByProjectBtn = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.FindByTeamNumberTxtB = new System.Windows.Forms.TextBox();
            this.FindByTeamBtn = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.FindByIdTxtB = new System.Windows.Forms.TextBox();
            this.FindByIdBtn = new System.Windows.Forms.Button();
            this.RemoveDevBtn = new System.Windows.Forms.Button();
            this.DevelopersListView = new MaterialSkin.Controls.MaterialListView();
            this.Developer_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddDevToTeam = new System.Windows.Forms.Button();
            this.DeleteDevFromTeam = new System.Windows.Forms.Button();
            this.Developers = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.Label();
            this.ShowALL = new System.Windows.Forms.Button();
            this.CreateTeamBtn = new System.Windows.Forms.Button();
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
            // TeamsListView
            // 
            this.TeamsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team_Id,
            this.Senior});
            this.TeamsListView.Depth = 0;
            this.TeamsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TeamsListView.FullRowSelect = true;
            this.TeamsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TeamsListView.Location = new System.Drawing.Point(567, 139);
            this.TeamsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TeamsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.TeamsListView.Name = "TeamsListView";
            this.TeamsListView.OwnerDraw = true;
            this.TeamsListView.Size = new System.Drawing.Size(418, 242);
            this.TeamsListView.TabIndex = 28;
            this.TeamsListView.UseCompatibleStateImageBehavior = false;
            this.TeamsListView.View = System.Windows.Forms.View.Details;
            this.TeamsListView.ItemActivate += new System.EventHandler(this.TeamsListView_ItemActivate);
            this.TeamsListView.SelectedIndexChanged += new System.EventHandler(this.TeamsListView_SelectedIndexChanged);
            // 
            // Team_Id
            // 
            this.Team_Id.Text = "Team";
            this.Team_Id.Width = 160;
            // 
            // Senior
            // 
            this.Senior.Text = "Senior";
            this.Senior.Width = 258;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(767, 434);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 1);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // FindByProjectTxtB
            // 
            this.FindByProjectTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FindByProjectTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByProjectTxtB.ForeColor = System.Drawing.Color.White;
            this.FindByProjectTxtB.Location = new System.Drawing.Point(767, 396);
            this.FindByProjectTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.FindByProjectTxtB.Name = "FindByProjectTxtB";
            this.FindByProjectTxtB.Size = new System.Drawing.Size(194, 29);
            this.FindByProjectTxtB.TabIndex = 30;
            this.FindByProjectTxtB.TabStop = false;
            // 
            // FindByProjectBtn
            // 
            this.FindByProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.FindByProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FindByProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindByProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByProjectBtn.ForeColor = System.Drawing.Color.White;
            this.FindByProjectBtn.Location = new System.Drawing.Point(567, 396);
            this.FindByProjectBtn.MinimumSize = new System.Drawing.Size(194, 40);
            this.FindByProjectBtn.Name = "FindByProjectBtn";
            this.FindByProjectBtn.Size = new System.Drawing.Size(194, 40);
            this.FindByProjectBtn.TabIndex = 29;
            this.FindByProjectBtn.Text = "Find by Project";
            this.FindByProjectBtn.UseVisualStyleBackColor = false;
            this.FindByProjectBtn.Click += new System.EventHandler(this.FindByProjectBtn_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(363, 494);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(194, 1);
            this.richTextBox2.TabIndex = 34;
            this.richTextBox2.Text = "";
            // 
            // FindByTeamNumberTxtB
            // 
            this.FindByTeamNumberTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FindByTeamNumberTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByTeamNumberTxtB.ForeColor = System.Drawing.Color.White;
            this.FindByTeamNumberTxtB.Location = new System.Drawing.Point(363, 456);
            this.FindByTeamNumberTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.FindByTeamNumberTxtB.Name = "FindByTeamNumberTxtB";
            this.FindByTeamNumberTxtB.Size = new System.Drawing.Size(194, 29);
            this.FindByTeamNumberTxtB.TabIndex = 33;
            this.FindByTeamNumberTxtB.TabStop = false;
            this.FindByTeamNumberTxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindByTeamNumberTxtB_KeyPress);
            // 
            // FindByTeamBtn
            // 
            this.FindByTeamBtn.BackColor = System.Drawing.Color.Transparent;
            this.FindByTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FindByTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindByTeamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByTeamBtn.ForeColor = System.Drawing.Color.White;
            this.FindByTeamBtn.Location = new System.Drawing.Point(134, 456);
            this.FindByTeamBtn.MinimumSize = new System.Drawing.Size(212, 32);
            this.FindByTeamBtn.Name = "FindByTeamBtn";
            this.FindByTeamBtn.Size = new System.Drawing.Size(212, 39);
            this.FindByTeamBtn.TabIndex = 32;
            this.FindByTeamBtn.Text = "Find by Team Number";
            this.FindByTeamBtn.UseVisualStyleBackColor = false;
            this.FindByTeamBtn.Click += new System.EventHandler(this.FindByTeamBtn_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(363, 435);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(194, 1);
            this.richTextBox3.TabIndex = 37;
            this.richTextBox3.Text = "";
            // 
            // FindByIdTxtB
            // 
            this.FindByIdTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FindByIdTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByIdTxtB.ForeColor = System.Drawing.Color.White;
            this.FindByIdTxtB.Location = new System.Drawing.Point(363, 397);
            this.FindByIdTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.FindByIdTxtB.Name = "FindByIdTxtB";
            this.FindByIdTxtB.Size = new System.Drawing.Size(194, 29);
            this.FindByIdTxtB.TabIndex = 36;
            this.FindByIdTxtB.TabStop = false;
            // 
            // FindByIdBtn
            // 
            this.FindByIdBtn.BackColor = System.Drawing.Color.Transparent;
            this.FindByIdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FindByIdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindByIdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByIdBtn.ForeColor = System.Drawing.Color.White;
            this.FindByIdBtn.Location = new System.Drawing.Point(134, 397);
            this.FindByIdBtn.MinimumSize = new System.Drawing.Size(212, 32);
            this.FindByIdBtn.Name = "FindByIdBtn";
            this.FindByIdBtn.Size = new System.Drawing.Size(212, 39);
            this.FindByIdBtn.TabIndex = 35;
            this.FindByIdBtn.Text = "Find By Id";
            this.FindByIdBtn.UseVisualStyleBackColor = false;
            this.FindByIdBtn.Click += new System.EventHandler(this.FindByIdBtn_Click);
            // 
            // RemoveDevBtn
            // 
            this.RemoveDevBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveDevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.RemoveDevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveDevBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveDevBtn.Location = new System.Drawing.Point(134, 518);
            this.RemoveDevBtn.Name = "RemoveDevBtn";
            this.RemoveDevBtn.Size = new System.Drawing.Size(212, 40);
            this.RemoveDevBtn.TabIndex = 39;
            this.RemoveDevBtn.Text = "Delete Developer";
            this.RemoveDevBtn.UseVisualStyleBackColor = false;
            this.RemoveDevBtn.Click += new System.EventHandler(this.RemoveDevBtn_Click);
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
            this.DevelopersListView.Location = new System.Drawing.Point(136, 139);
            this.DevelopersListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DevelopersListView.MouseState = MaterialSkin.MouseState.OUT;
            this.DevelopersListView.Name = "DevelopersListView";
            this.DevelopersListView.OwnerDraw = true;
            this.DevelopersListView.Size = new System.Drawing.Size(421, 242);
            this.DevelopersListView.TabIndex = 40;
            this.DevelopersListView.UseCompatibleStateImageBehavior = false;
            this.DevelopersListView.View = System.Windows.Forms.View.Details;
            this.DevelopersListView.ItemActivate += new System.EventHandler(this.DevelopersListView_ItemActivate);
            this.DevelopersListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DevelopersListView_ItemSelectionChanged);
            this.DevelopersListView.SelectedIndexChanged += new System.EventHandler(this.DevelopersListView_SelectedIndexChanged);
            // 
            // Developer_Id
            // 
            this.Developer_Id.Text = "Developer";
            this.Developer_Id.Width = 423;
            // 
            // AddDevToTeam
            // 
            this.AddDevToTeam.BackColor = System.Drawing.Color.Transparent;
            this.AddDevToTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.AddDevToTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDevToTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDevToTeam.ForeColor = System.Drawing.Color.White;
            this.AddDevToTeam.Location = new System.Drawing.Point(567, 458);
            this.AddDevToTeam.Name = "AddDevToTeam";
            this.AddDevToTeam.Size = new System.Drawing.Size(194, 40);
            this.AddDevToTeam.TabIndex = 41;
            this.AddDevToTeam.Text = "Add Developer to Team";
            this.AddDevToTeam.UseVisualStyleBackColor = false;
            this.AddDevToTeam.Click += new System.EventHandler(this.AddDevToTeam_Click);
            // 
            // DeleteDevFromTeam
            // 
            this.DeleteDevFromTeam.BackColor = System.Drawing.Color.Transparent;
            this.DeleteDevFromTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DeleteDevFromTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDevFromTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDevFromTeam.ForeColor = System.Drawing.Color.White;
            this.DeleteDevFromTeam.Location = new System.Drawing.Point(770, 458);
            this.DeleteDevFromTeam.Name = "DeleteDevFromTeam";
            this.DeleteDevFromTeam.Size = new System.Drawing.Size(194, 40);
            this.DeleteDevFromTeam.TabIndex = 42;
            this.DeleteDevFromTeam.Text = "Delete Developer from Team";
            this.DeleteDevFromTeam.UseVisualStyleBackColor = false;
            this.DeleteDevFromTeam.Click += new System.EventHandler(this.DeleteDevFromTeam_Click);
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.BackColor = System.Drawing.Color.Transparent;
            this.Developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Developers.ForeColor = System.Drawing.Color.White;
            this.Developers.Location = new System.Drawing.Point(147, 104);
            this.Developers.MinimumSize = new System.Drawing.Size(400, 32);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(400, 32);
            this.Developers.TabIndex = 44;
            this.Developers.Text = "Developers";
            this.Developers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Developers.Click += new System.EventHandler(this.Developers_Click);
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.BackColor = System.Drawing.Color.Transparent;
            this.Teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teams.ForeColor = System.Drawing.Color.White;
            this.Teams.Location = new System.Drawing.Point(573, 104);
            this.Teams.MinimumSize = new System.Drawing.Size(400, 32);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(400, 32);
            this.Teams.TabIndex = 45;
            this.Teams.Text = "Teams";
            this.Teams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Teams.Click += new System.EventHandler(this.Teams_Click);
            // 
            // ShowALL
            // 
            this.ShowALL.BackColor = System.Drawing.Color.Transparent;
            this.ShowALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ShowALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowALL.ForeColor = System.Drawing.Color.White;
            this.ShowALL.Location = new System.Drawing.Point(137, 56);
            this.ShowALL.Name = "ShowALL";
            this.ShowALL.Size = new System.Drawing.Size(848, 40);
            this.ShowALL.TabIndex = 46;
            this.ShowALL.Text = "SHOW ALL";
            this.ShowALL.UseVisualStyleBackColor = false;
            this.ShowALL.Click += new System.EventHandler(this.ShowALL_Click);
            // 
            // CreateTeamBtn
            // 
            this.CreateTeamBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CreateTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTeamBtn.ForeColor = System.Drawing.Color.White;
            this.CreateTeamBtn.Location = new System.Drawing.Point(569, 520);
            this.CreateTeamBtn.Name = "CreateTeamBtn";
            this.CreateTeamBtn.Size = new System.Drawing.Size(395, 40);
            this.CreateTeamBtn.TabIndex = 47;
            this.CreateTeamBtn.Text = "Create Team";
            this.CreateTeamBtn.UseVisualStyleBackColor = false;
            this.CreateTeamBtn.Click += new System.EventHandler(this.CreateTeamBtn_Click);
            // 
            // DevelopersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.CreateTeamBtn);
            this.Controls.Add(this.ShowALL);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.DeleteDevFromTeam);
            this.Controls.Add(this.AddDevToTeam);
            this.Controls.Add(this.DevelopersListView);
            this.Controls.Add(this.RemoveDevBtn);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.FindByIdTxtB);
            this.Controls.Add(this.FindByIdBtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.FindByTeamNumberTxtB);
            this.Controls.Add(this.FindByTeamBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FindByProjectTxtB);
            this.Controls.Add(this.FindByProjectBtn);
            this.Controls.Add(this.TeamsListView);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevelopersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevelopersView";
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
        private MaterialSkin.Controls.MaterialListView TeamsListView;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox FindByProjectTxtB;
        private System.Windows.Forms.Button FindByProjectBtn;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox FindByTeamNumberTxtB;
        private System.Windows.Forms.Button FindByTeamBtn;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox FindByIdTxtB;
        private System.Windows.Forms.Button FindByIdBtn;
        private System.Windows.Forms.Button RemoveDevBtn;
        private MaterialSkin.Controls.MaterialListView DevelopersListView;
        private System.Windows.Forms.Button AddDevToTeam;
        private System.Windows.Forms.Button DeleteDevFromTeam;
        private System.Windows.Forms.Label Developers;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.ColumnHeader Team_Id;
        private System.Windows.Forms.ColumnHeader Developer_Id;
        private System.Windows.Forms.ColumnHeader Senior;
        private System.Windows.Forms.Button ShowALL;
        private System.Windows.Forms.Button CreateTeamBtn;
    }
}