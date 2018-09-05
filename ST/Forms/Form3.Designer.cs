namespace ST.Forms
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panelControls = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnSlide = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panScoll = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnstate = new System.Windows.Forms.Button();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragCont1 = new ST.DragCont();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panScoll.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(265, 27);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(735, 573);
            this.panelControls.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.pnSlide;
            // 
            // pnSlide
            // 
            this.pnSlide.BackColor = System.Drawing.Color.Snow;
            this.pnSlide.Location = new System.Drawing.Point(0, 30);
            this.pnSlide.Name = "pnSlide";
            this.pnSlide.Size = new System.Drawing.Size(7, 62);
            this.pnSlide.TabIndex = 3;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(207)))));
            this.time.Location = new System.Drawing.Point(66, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(279, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Добро пожаловать";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(684, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(265, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 27);
            this.panel1.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 25);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(710, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 27);
            this.panel2.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(207)))));
            this.Date.Location = new System.Drawing.Point(154, 2);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 24);
            this.Date.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(16, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "HR";
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panScoll
            // 
            this.panScoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panScoll.Controls.Add(this.btnLogout);
            this.panScoll.Controls.Add(this.panel4);
            this.panScoll.Controls.Add(this.panel3);
            this.panScoll.Controls.Add(this.btnAddUser);
            this.panScoll.Controls.Add(this.panel2);
            this.panScoll.Controls.Add(this.pnSlide);
            this.panScoll.Controls.Add(this.btnstate);
            this.panScoll.Dock = System.Windows.Forms.DockStyle.Left;
            this.panScoll.Location = new System.Drawing.Point(0, 0);
            this.panScoll.Name = "panScoll";
            this.panScoll.Size = new System.Drawing.Size(265, 600);
            this.panScoll.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(0, 557);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(265, 43);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "         Выйти      ";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(13, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 1);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(13, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 1);
            this.panel3.TabIndex = 15;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(0, 90);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(265, 62);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "        Добавить\r\n        сотрудника";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnstate
            // 
            this.btnstate.FlatAppearance.BorderSize = 0;
            this.btnstate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnstate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnstate.Image = ((System.Drawing.Image)(resources.GetObject("btnstate.Image")));
            this.btnstate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstate.Location = new System.Drawing.Point(0, 27);
            this.btnstate.Name = "btnstate";
            this.btnstate.Size = new System.Drawing.Size(265, 62);
            this.btnstate.TabIndex = 1;
            this.btnstate.Text = "         Состояние\r\n         фирмы\r\n";
            this.btnstate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstate.UseVisualStyleBackColor = true;
            this.btnstate.Click += new System.EventHandler(this.btnstate_Click);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // dragCont1
            // 
            this.dragCont1.SelectControl = this.panel1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panScoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panScoll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnSlide;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel panScoll;
        private System.Windows.Forms.Button btnstate;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMenu;
        private DragCont dragCont1;
    }
}