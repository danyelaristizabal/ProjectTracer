namespace ProjectTracer.Forms.DeveloperView
{
    partial class DeveloperProjectsView
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
            this.TasksBtn = new System.Windows.Forms.Button();
            this.ProjectsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.FindProject = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FindByIdTxtB = new System.Windows.Forms.TextBox();
            this.FindById = new System.Windows.Forms.Button();
            this.ProjectsView = new MaterialSkin.Controls.MaterialListView();
            this.ProjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NavigationBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FindProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavigationBar.Controls.Add(this.TasksBtn);
            this.NavigationBar.Controls.Add(this.ProjectsBtn);
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationBar.Location = new System.Drawing.Point(0, 50);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(130, 550);
            this.NavigationBar.TabIndex = 3;
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
            // FindProject
            // 
            this.FindProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FindProject.Controls.Add(this.richTextBox1);
            this.FindProject.Controls.Add(this.FindByIdTxtB);
            this.FindProject.Controls.Add(this.FindById);
            this.FindProject.Location = new System.Drawing.Point(136, 61);
            this.FindProject.Name = "FindProject";
            this.FindProject.Size = new System.Drawing.Size(840, 62);
            this.FindProject.TabIndex = 14;
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
            this.FindByIdTxtB.Size = new System.Drawing.Size(280, 32);
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
            // 
            // ProjectsView
            // 
            this.ProjectsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectId,
            this.Description,
            this.DeadLine,
            this.Result});
            this.ProjectsView.Depth = 0;
            this.ProjectsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ProjectsView.FullRowSelect = true;
            this.ProjectsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProjectsView.Location = new System.Drawing.Point(136, 129);
            this.ProjectsView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProjectsView.MouseState = MaterialSkin.MouseState.OUT;
            this.ProjectsView.Name = "ProjectsView";
            this.ProjectsView.OwnerDraw = true;
            this.ProjectsView.Size = new System.Drawing.Size(840, 395);
            this.ProjectsView.TabIndex = 13;
            this.ProjectsView.UseCompatibleStateImageBehavior = false;
            this.ProjectsView.View = System.Windows.Forms.View.Details;
            // 
            // ProjectId
            // 
            this.ProjectId.Text = "Project Name";
            this.ProjectId.Width = 142;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 460;
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
            // DeveloperProjectsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTracer.Properties.Resources.BackGround1000x600;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.FindProject);
            this.Controls.Add(this.ProjectsView);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeveloperProjectsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeveloperProjectsView";
            this.NavigationBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.FindProject.ResumeLayout(false);
            this.FindProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationBar;
        private System.Windows.Forms.Button TasksBtn;
        private System.Windows.Forms.Button ProjectsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel FindProject;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox FindByIdTxtB;
        private System.Windows.Forms.Button FindById;
        private MaterialSkin.Controls.MaterialListView ProjectsView;
        private System.Windows.Forms.ColumnHeader ProjectId;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DeadLine;
        private System.Windows.Forms.ColumnHeader Result;
    }
}