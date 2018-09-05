namespace ST.Controls
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.label3 = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbgroup = new System.Windows.Forms.Label();
            this.cbPrec = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbrate = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panelGRCH = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelsal = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelgr = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbcountPeople = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDateWork = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelGRCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelsal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заработная плата";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Cambria", 21.75F);
            this.lbSalary.Location = new System.Drawing.Point(121, 46);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(0, 34);
            this.lbSalary.TabIndex = 3;
            this.lbSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Должность";
            // 
            // lbgroup
            // 
            this.lbgroup.AutoSize = true;
            this.lbgroup.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbgroup.Location = new System.Drawing.Point(36, 40);
            this.lbgroup.Name = "lbgroup";
            this.lbgroup.Size = new System.Drawing.Size(0, 36);
            this.lbgroup.TabIndex = 5;
            // 
            // cbPrec
            // 
            this.cbPrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbPrec.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbPrec.Checked = false;
            this.cbPrec.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbPrec.ForeColor = System.Drawing.Color.White;
            this.cbPrec.Location = new System.Drawing.Point(318, 146);
            this.cbPrec.Name = "cbPrec";
            this.cbPrec.Size = new System.Drawing.Size(20, 20);
            this.cbPrec.TabIndex = 6;
            this.cbPrec.OnChange += new System.EventHandler(this.cbrate_OnChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "С учетом подчиненных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "С учетом ставки";
            // 
            // cbrate
            // 
            this.cbrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbrate.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbrate.Checked = false;
            this.cbrate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbrate.ForeColor = System.Drawing.Color.White;
            this.cbrate.Location = new System.Drawing.Point(318, 103);
            this.cbrate.Name = "cbrate";
            this.cbrate.Size = new System.Drawing.Size(20, 20);
            this.cbrate.TabIndex = 8;
            this.cbrate.OnChange += new System.EventHandler(this.cbrate_OnChange);
            // 
            // panelGRCH
            // 
            this.panelGRCH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGRCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panelGRCH.Controls.Add(this.pictureBox1);
            this.panelGRCH.Controls.Add(this.label4);
            this.panelGRCH.Controls.Add(this.lbgroup);
            this.panelGRCH.Location = new System.Drawing.Point(462, 311);
            this.panelGRCH.Name = "panelGRCH";
            this.panelGRCH.Size = new System.Drawing.Size(257, 99);
            this.panelGRCH.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelsal
            // 
            this.panelsal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelsal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panelsal.Controls.Add(this.pictureBox5);
            this.panelsal.Controls.Add(this.label3);
            this.panelsal.Controls.Add(this.lbSalary);
            this.panelsal.Controls.Add(this.label6);
            this.panelsal.Controls.Add(this.label7);
            this.panelsal.Controls.Add(this.cbPrec);
            this.panelsal.Controls.Add(this.cbrate);
            this.panelsal.Location = new System.Drawing.Point(16, 181);
            this.panelsal.MaximumSize = new System.Drawing.Size(369, 178);
            this.panelsal.MinimumSize = new System.Drawing.Size(369, 135);
            this.panelsal.Name = "panelsal";
            this.panelsal.Size = new System.Drawing.Size(369, 178);
            this.panelsal.TabIndex = 11;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(302, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // panelgr
            // 
            this.panelgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelgr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panelgr.Controls.Add(this.pictureBox3);
            this.panelgr.Controls.Add(this.label8);
            this.panelgr.Controls.Add(this.lbcountPeople);
            this.panelgr.Location = new System.Drawing.Point(16, 405);
            this.panelgr.Name = "panelgr";
            this.panelgr.Size = new System.Drawing.Size(369, 98);
            this.panelgr.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(304, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 33);
            this.label8.TabIndex = 4;
            this.label8.Text = "Колличество подчиненных";
            // 
            // lbcountPeople
            // 
            this.lbcountPeople.AutoSize = true;
            this.lbcountPeople.Font = new System.Drawing.Font("Cambria", 21.75F);
            this.lbcountPeople.Location = new System.Drawing.Point(144, 39);
            this.lbcountPeople.Name = "lbcountPeople";
            this.lbcountPeople.Size = new System.Drawing.Size(0, 34);
            this.lbcountPeople.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lbDateWork);
            this.panel4.Location = new System.Drawing.Point(16, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 99);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(40, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 33);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата трудоустройства";
            // 
            // lbDateWork
            // 
            this.lbDateWork.AutoSize = true;
            this.lbDateWork.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDateWork.Location = new System.Drawing.Point(92, 50);
            this.lbDateWork.Name = "lbDateWork";
            this.lbDateWork.Size = new System.Drawing.Size(0, 34);
            this.lbDateWork.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(462, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(257, 244);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panelGRCH);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelgr);
            this.Controls.Add(this.panelsal);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(735, 573);
            this.panelGRCH.ResumeLayout(false);
            this.panelGRCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelsal.ResumeLayout(false);
            this.panelsal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelgr.ResumeLayout(false);
            this.panelgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbgroup;
        private Bunifu.Framework.UI.BunifuCheckbox cbPrec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCheckbox cbrate;
        private System.Windows.Forms.Panel panelGRCH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelsal;
        private System.Windows.Forms.Panel panelgr;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbcountPeople;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbDateWork;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
