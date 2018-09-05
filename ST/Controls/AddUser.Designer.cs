namespace ST.Controls
{
    partial class AddUser
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbChPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbLog = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelgroup = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSal = new System.Windows.Forms.Button();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnEpm = new System.Windows.Forms.Button();
            this.btngroups = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReg = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbSuName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbPatr = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(142, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(86, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Подтверждение";
            // 
            // DateTime
            // 
            this.DateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DateTime.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime.Location = new System.Drawing.Point(136, 356);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(122, 26);
            this.DateTime.TabIndex = 9;
            this.DateTime.Value = new System.DateTime(2018, 9, 3, 14, 15, 33, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(37, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата трудоустройства";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbPass.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbPass.BorderColorIdle = System.Drawing.Color.White;
            this.tbPass.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbPass.BorderThickness = 3;
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.isPassword = true;
            this.tbPass.Location = new System.Drawing.Point(43, 120);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(303, 39);
            this.tbPass.TabIndex = 2;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbChPass
            // 
            this.tbChPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbChPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbChPass.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbChPass.BorderColorIdle = System.Drawing.Color.White;
            this.tbChPass.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbChPass.BorderThickness = 3;
            this.tbChPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbChPass.ForeColor = System.Drawing.Color.White;
            this.tbChPass.isPassword = true;
            this.tbChPass.Location = new System.Drawing.Point(43, 197);
            this.tbChPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbChPass.Name = "tbChPass";
            this.tbChPass.Size = new System.Drawing.Size(303, 39);
            this.tbChPass.TabIndex = 3;
            this.tbChPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbLog.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbLog.BorderColorIdle = System.Drawing.Color.White;
            this.tbLog.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbLog.BorderThickness = 3;
            this.tbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLog.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.ForeColor = System.Drawing.Color.White;
            this.tbLog.isPassword = false;
            this.tbLog.Location = new System.Drawing.Point(43, 43);
            this.tbLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(303, 39);
            this.tbLog.TabIndex = 1;
            this.tbLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelgroup
            // 
            this.panelgroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelgroup.Controls.Add(this.panel3);
            this.panelgroup.Controls.Add(this.panel2);
            this.panelgroup.Controls.Add(this.btnSal);
            this.panelgroup.Controls.Add(this.btnMan);
            this.panelgroup.Controls.Add(this.btnEpm);
            this.panelgroup.Controls.Add(this.btngroups);
            this.panelgroup.Location = new System.Drawing.Point(392, 255);
            this.panelgroup.MaximumSize = new System.Drawing.Size(303, 162);
            this.panelgroup.MinimumSize = new System.Drawing.Size(303, 57);
            this.panelgroup.Name = "panelgroup";
            this.panelgroup.Size = new System.Drawing.Size(303, 57);
            this.panelgroup.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(124, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 1);
            this.panel3.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(124, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 1);
            this.panel2.TabIndex = 22;
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnSal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSal.FlatAppearance.BorderSize = 0;
            this.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSal.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnSal.ForeColor = System.Drawing.Color.White;
            this.btnSal.Location = new System.Drawing.Point(0, 126);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(303, 35);
            this.btnSal.TabIndex = 3;
            this.btnSal.Text = "Salesman";
            this.btnSal.UseVisualStyleBackColor = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // btnMan
            // 
            this.btnMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMan.FlatAppearance.BorderSize = 0;
            this.btnMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMan.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnMan.ForeColor = System.Drawing.Color.White;
            this.btnMan.Location = new System.Drawing.Point(0, 91);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(303, 35);
            this.btnMan.TabIndex = 2;
            this.btnMan.Text = "Manager";
            this.btnMan.UseVisualStyleBackColor = false;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // btnEpm
            // 
            this.btnEpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnEpm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEpm.FlatAppearance.BorderSize = 0;
            this.btnEpm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEpm.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEpm.ForeColor = System.Drawing.Color.White;
            this.btnEpm.Location = new System.Drawing.Point(0, 56);
            this.btnEpm.Name = "btnEpm";
            this.btnEpm.Size = new System.Drawing.Size(303, 35);
            this.btnEpm.TabIndex = 1;
            this.btnEpm.Text = "Employee";
            this.btnEpm.UseVisualStyleBackColor = false;
            this.btnEpm.Click += new System.EventHandler(this.btnEpm_Click);
            // 
            // btngroups
            // 
            this.btngroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngroups.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic);
            this.btngroups.ForeColor = System.Drawing.Color.White;
            this.btngroups.Location = new System.Drawing.Point(0, 0);
            this.btngroups.Name = "btngroups";
            this.btngroups.Size = new System.Drawing.Size(303, 56);
            this.btngroups.TabIndex = 8;
            this.btngroups.Text = "  Выбор группы";
            this.btngroups.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btngroups.UseVisualStyleBackColor = true;
            this.btngroups.Click += new System.EventHandler(this.btngroups_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(48, 202);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // groupTimer
            // 
            this.groupTimer.Interval = 15;
            this.groupTimer.Tick += new System.EventHandler(this.groupTimer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(48, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // tbSalary
            // 
            this.tbSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbSalary.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbSalary.BorderColorIdle = System.Drawing.Color.White;
            this.tbSalary.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbSalary.BorderThickness = 3;
            this.tbSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSalary.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSalary.ForeColor = System.Drawing.Color.White;
            this.tbSalary.isPassword = false;
            this.tbSalary.Location = new System.Drawing.Point(43, 273);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(303, 39);
            this.tbSalary.TabIndex = 4;
            this.tbSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(68, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Заработная плата";
            // 
            // btnReg
            // 
            this.btnReg.ActiveBorderThickness = 1;
            this.btnReg.ActiveCornerRadius = 20;
            this.btnReg.ActiveFillColor = System.Drawing.Color.White;
            this.btnReg.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnReg.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReg.BackgroundImage")));
            this.btnReg.ButtonText = "Зарегистрировать";
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.IdleBorderThickness = 1;
            this.btnReg.IdleCornerRadius = 20;
            this.btnReg.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnReg.IdleForecolor = System.Drawing.Color.White;
            this.btnReg.IdleLineColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(168, 477);
            this.btnReg.Margin = new System.Windows.Forms.Padding(8);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(413, 55);
            this.btnReg.TabIndex = 10;
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(397, 202);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(397, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // tbSuName
            // 
            this.tbSuName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbSuName.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbSuName.BorderColorIdle = System.Drawing.Color.White;
            this.tbSuName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbSuName.BorderThickness = 3;
            this.tbSuName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSuName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSuName.ForeColor = System.Drawing.Color.White;
            this.tbSuName.isPassword = false;
            this.tbSuName.Location = new System.Drawing.Point(392, 43);
            this.tbSuName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSuName.Name = "tbSuName";
            this.tbSuName.Size = new System.Drawing.Size(303, 39);
            this.tbSuName.TabIndex = 5;
            this.tbSuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPatr
            // 
            this.tbPatr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPatr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbPatr.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbPatr.BorderColorIdle = System.Drawing.Color.White;
            this.tbPatr.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbPatr.BorderThickness = 3;
            this.tbPatr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPatr.Font = new System.Drawing.Font("Cambria", 12F);
            this.tbPatr.ForeColor = System.Drawing.Color.White;
            this.tbPatr.isPassword = false;
            this.tbPatr.Location = new System.Drawing.Point(392, 197);
            this.tbPatr.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(303, 39);
            this.tbPatr.TabIndex = 7;
            this.tbPatr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(397, 125);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbName.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbName.BorderColorIdle = System.Drawing.Color.White;
            this.tbName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbName.BorderThickness = 3;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Cambria", 12F);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.isPassword = false;
            this.tbName.Location = new System.Drawing.Point(392, 120);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(303, 39);
            this.tbName.TabIndex = 6;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(470, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label7.Location = new System.Drawing.Point(509, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Имя";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label8.Location = new System.Drawing.Point(481, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "Фамилия";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tbSuName);
            this.Controls.Add(this.tbPatr);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelgroup);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.tbChPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReg);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(735, 573);
            this.panelgroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbChPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbLog;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelgroup;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnEpm;
        private System.Windows.Forms.Button btngroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer groupTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbSalary;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReg;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbSuName;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPatr;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
