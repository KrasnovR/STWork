namespace ST
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panScoll = new System.Windows.Forms.Panel();
            this.panelGr = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragCont1 = new ST.DragCont();
            this.panScoll.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panScoll
            // 
            this.panScoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panScoll.Controls.Add(this.panelGr);
            this.panScoll.Controls.Add(this.panel3);
            this.panScoll.Controls.Add(this.btnLogout);
            this.panScoll.Controls.Add(this.panel2);
            this.panScoll.Controls.Add(this.panelSlide);
            this.panScoll.Controls.Add(this.btnPeople);
            this.panScoll.Controls.Add(this.btnProf);
            this.panScoll.Dock = System.Windows.Forms.DockStyle.Left;
            this.panScoll.Location = new System.Drawing.Point(0, 0);
            this.panScoll.Name = "panScoll";
            this.panScoll.Size = new System.Drawing.Size(265, 600);
            this.panScoll.TabIndex = 1;
            // 
            // panelGr
            // 
            this.panelGr.BackColor = System.Drawing.Color.Silver;
            this.panelGr.Location = new System.Drawing.Point(13, 151);
            this.panelGr.Name = "panelGr";
            this.panelGr.Size = new System.Drawing.Size(240, 1);
            this.panelGr.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(13, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 1);
            this.panel3.TabIndex = 14;
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
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "         Выйти      ";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 27);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(14, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "HR";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(207)))));
            this.Date.Location = new System.Drawing.Point(154, 1);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 24);
            this.Date.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Snow;
            this.panelSlide.Location = new System.Drawing.Point(0, 29);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(7, 62);
            this.panelSlide.TabIndex = 3;
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnPeople.Image")));
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(0, 90);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(265, 62);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "    Подчиненные";
            this.btnPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnProf
            // 
            this.btnProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnProf.Image = ((System.Drawing.Image)(resources.GetObject("btnProf.Image")));
            this.btnProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProf.Location = new System.Drawing.Point(0, 27);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(265, 62);
            this.btnProf.TabIndex = 1;
            this.btnProf.Text = "    Профиль";
            this.btnProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProf.UseVisualStyleBackColor = false;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(207)))));
            this.time.Location = new System.Drawing.Point(65, 1);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 5;
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbFullname);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(265, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 27);
            this.panel1.TabIndex = 2;
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
            this.btnMenu.TabIndex = 13;
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
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(130, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Добро пожаловать,";
            // 
            // lbFullname
            // 
            this.lbFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFullname.AutoSize = true;
            this.lbFullname.BackColor = System.Drawing.Color.Transparent;
            this.lbFullname.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.lbFullname.Location = new System.Drawing.Point(300, 1);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(0, 23);
            this.lbFullname.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(684, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panelSlide;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(265, 27);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(735, 573);
            this.panelControls.TabIndex = 3;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panScoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panScoll.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panScoll;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelControls;
        public System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panelGr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMenu;
        private DragCont dragCont1;
    }
}