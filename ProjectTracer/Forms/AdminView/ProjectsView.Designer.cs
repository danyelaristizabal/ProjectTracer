namespace ProjectTracer.Forms
{
    partial class ProjectsView
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
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.Clients = new System.Windows.Forms.Button();
            this.DevelopersBtn = new System.Windows.Forms.Button();
            this.TasksBtn = new System.Windows.Forms.Button();
            this.ProjectsBtn = new System.Windows.Forms.Button();
            this.AdminProjectsView = new MaterialSkin.Controls.MaterialListView();
            this.ProjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.GenerateInvitationCodeBtn = new System.Windows.Forms.Button();
            this.FindProject = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FindByIdTxtB = new System.Windows.Forms.TextBox();
            this.FindById = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.NavigationBar.SuspendLayout();
            this.FindProject.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.Minimize.TabIndex = 10;
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
            this.Close.TabIndex = 9;
            this.Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            this.NavigationBar.TabIndex = 1;
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
            this.ProjectsBtn.BackColor = System.Drawing.Color.Silver;
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
            // 
            // AdminProjectsView
            // 
            this.AdminProjectsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminProjectsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectId,
            this.Description,
            this.DeadLine,
            this.Result,
            this.Client});
            this.AdminProjectsView.Depth = 0;
            this.AdminProjectsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminProjectsView.FullRowSelect = true;
            this.AdminProjectsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AdminProjectsView.Location = new System.Drawing.Point(148, 124);
            this.AdminProjectsView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AdminProjectsView.MouseState = MaterialSkin.MouseState.OUT;
            this.AdminProjectsView.Name = "AdminProjectsView";
            this.AdminProjectsView.OwnerDraw = true;
            this.AdminProjectsView.Size = new System.Drawing.Size(840, 395);
            this.AdminProjectsView.TabIndex = 2;
            this.AdminProjectsView.UseCompatibleStateImageBehavior = false;
            this.AdminProjectsView.View = System.Windows.Forms.View.Details;
            this.AdminProjectsView.ItemActivate += new System.EventHandler(this.AdminProjectsView_ItemActivate);
            // 
            // ProjectId
            // 
            this.ProjectId.Text = "Project Name";
            this.ProjectId.Width = 120;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 340;
            // 
            // DeadLine
            // 
            this.DeadLine.Text = "DeadLine";
            this.DeadLine.Width = 121;
            // 
            // Result
            // 
            this.Result.Text = "Result";
            this.Result.Width = 120;
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.Width = 121;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(148, 535);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(200, 40);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add Project ";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(380, 535);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(200, 40);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete Project";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // GenerateInvitationCodeBtn
            // 
            this.GenerateInvitationCodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.GenerateInvitationCodeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.GenerateInvitationCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateInvitationCodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateInvitationCodeBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateInvitationCodeBtn.Location = new System.Drawing.Point(611, 535);
            this.GenerateInvitationCodeBtn.Name = "GenerateInvitationCodeBtn";
            this.GenerateInvitationCodeBtn.Size = new System.Drawing.Size(200, 40);
            this.GenerateInvitationCodeBtn.TabIndex = 10;
            this.GenerateInvitationCodeBtn.Text = "Generate Invitation Code";
            this.GenerateInvitationCodeBtn.UseVisualStyleBackColor = false;
            this.GenerateInvitationCodeBtn.Click += new System.EventHandler(this.GenerateInvitationCodeBtn_Click);
            // 
            // FindProject
            // 
            this.FindProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FindProject.Controls.Add(this.richTextBox1);
            this.FindProject.Controls.Add(this.FindByIdTxtB);
            this.FindProject.Controls.Add(this.FindById);
            this.FindProject.Location = new System.Drawing.Point(148, 56);
            this.FindProject.Name = "FindProject";
            this.FindProject.Size = new System.Drawing.Size(840, 62);
            this.FindProject.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(232, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 1);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // FindByIdTxtB
            // 
            this.FindByIdTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FindByIdTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByIdTxtB.ForeColor = System.Drawing.Color.White;
            this.FindByIdTxtB.Location = new System.Drawing.Point(232, 10);
            this.FindByIdTxtB.MinimumSize = new System.Drawing.Size(100, 32);
            this.FindByIdTxtB.Name = "FindByIdTxtB";
            this.FindByIdTxtB.Size = new System.Drawing.Size(280, 29);
            this.FindByIdTxtB.TabIndex = 22;
            this.FindByIdTxtB.TabStop = false;
            // 
            // FindById
            // 
            this.FindById.BackColor = System.Drawing.Color.Transparent;
            this.FindById.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FindById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindById.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindById.ForeColor = System.Drawing.Color.White;
            this.FindById.Location = new System.Drawing.Point(3, 10);
            this.FindById.MinimumSize = new System.Drawing.Size(212, 32);
            this.FindById.Name = "FindById";
            this.FindById.Size = new System.Drawing.Size(212, 39);
            this.FindById.TabIndex = 12;
            this.FindById.Text = "Find by Id:";
            this.FindById.UseVisualStyleBackColor = false;
            this.FindById.Click += new System.EventHandler(this.FindById_Click);
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.BackColor = System.Drawing.Color.Transparent;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code.ForeColor = System.Drawing.Color.White;
            this.Code.Location = new System.Drawing.Point(817, 535);
            this.Code.MinimumSize = new System.Drawing.Size(180, 40);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(180, 40);
            this.Code.TabIndex = 12;
            this.Code.Text = "Code";
            this.Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.FindProject);
            this.Controls.Add(this.GenerateInvitationCodeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AdminProjectsView);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.ProjectsView_Load);
            this.panel1.ResumeLayout(false);
            this.NavigationBar.ResumeLayout(false);
            this.FindProject.ResumeLayout(false);
            this.FindProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel NavigationBar;
        private System.Windows.Forms.Button ProjectsBtn;
        private System.Windows.Forms.Button DevelopersBtn;
        private System.Windows.Forms.Button TasksBtn;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private MaterialSkin.Controls.MaterialListView AdminProjectsView;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button GenerateInvitationCodeBtn;
        private System.Windows.Forms.Panel FindProject;
        private System.Windows.Forms.Button FindById;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox FindByIdTxtB;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.ColumnHeader ProjectId;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DeadLine;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.ColumnHeader Client;
    }
}