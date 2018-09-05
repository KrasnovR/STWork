using ST.Forms;
using System;
using System.Windows.Forms;

namespace ST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sqlCon.OpenConnect();
        }
        Contact sqlCon = new Contact();
        bool open = true;
        
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Авторизация с переходом на нужную форму возможно ужасная, за это извиняюсь,
        //учусь и буду рад увидеть лучшую 
        private void btnLog_Click(object sender, EventArgs e)
        {           
               int log = sqlCon.Login(tbLog.Text.ToString(), tbPass.Text.ToString());
            if (log == 0)
            {
                Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else if (log == 1)
            {
                Hide();
                Form3 f = new Form3();
                f.Show();
            }
            else { MessageBox.Show("Логин или пароль неверный!"); }                                   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //Открыть/закрыть шпаргалку
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (open) { panel1.Width -= 5; if ( panel1.Width <= panel1.MinimumSize.Width ) { timer1.Stop(); open = false; } }
            else { panel1.Width += 5; if ( panel1.Width >= panel1.MaximumSize.Width ) { timer1.Stop();open = true; } }    
        }
        //Ввод текста и запуск таймера для закрытия шпаргалки
        private void btnus_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tbLog.Text = "asd";
            tbPass.Text = "123";
        }
        //Ввод текста и запуск таймера для закрытия шпаргалки
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tbLog.Text = "admin";
            tbPass.Text = "admin";
        }
    }
}
