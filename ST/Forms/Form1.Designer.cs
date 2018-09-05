namespace ST
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnLog = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dragCont1 = new ST.DragCont();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnLog
            // 
            this.btnLog.ActiveBorderThickness = 1;
            this.btnLog.ActiveCornerRadius = 20;
            this.btnLog.ActiveFillColor = System.Drawing.Color.White;
            this.btnLog.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnLog.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLog.BackgroundImage")));
            this.btnLog.ButtonText = "Войти";
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnLog.IdleBorderThickness = 1;
            this.btnLog.IdleCornerRadius = 20;
            this.btnLog.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnLog.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnLog.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnLog.Location = new System.Drawing.Point(296, 199);
            this.btnLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(221, 51);
            this.btnLog.TabIndex = 0;
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.btnus);
            this.bunifuGradientPanel1.Controls.Add(this.button2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(246, 256);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.MaximumSize = new System.Drawing.Size(246, 161);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 161);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 95.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 170);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnus
            // 
            this.btnus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btnus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnus.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnus.Location = new System.Drawing.Point(76, 77);
            this.btnus.Name = "btnus";
            this.btnus.Size = new System.Drawing.Size(93, 32);
            this.btnus.TabIndex = 2;
            this.btnus.Text = "Сотрудник";
            this.btnus.UseVisualStyleBackColor = false;
            this.btnus.Click += new System.EventHandler(this.btnus_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.button2.Location = new System.Drawing.Point(76, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "SuperUser";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.tbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLog.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.ForeColor = System.Drawing.Color.White;
            this.tbLog.Location = new System.Drawing.Point(281, 59);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(253, 32);
            this.tbLog.TabIndex = 2;
            this.tbLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(281, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(281, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.Location = new System.Drawing.Point(281, 144);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(253, 32);
            this.tbPass.TabIndex = 4;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.tbLog;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.tbPass;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(284, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(284, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHide.Image = ((System.Drawing.Image)(resources.GetObject("pbHide.Image")));
            this.pbHide.InitialImage = null;
            this.pbHide.Location = new System.Drawing.Point(523, 0);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(22, 22);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHide.TabIndex = 8;
            this.pbHide.TabStop = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.InitialImage = null;
            this.pbExit.Location = new System.Drawing.Point(545, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(22, 22);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 9;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dragCont1
            // 
            this.dragCont1.SelectControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(567, 256);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btnLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLog;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbHide;
        public System.Windows.Forms.TextBox tbPass;
        public System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private DragCont dragCont1;
    }
}

