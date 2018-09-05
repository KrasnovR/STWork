using System;
using System.Windows.Forms;
using ST.Controls;

namespace ST.Forms
{
    public partial class Form3 : Form
    {
        //Старт для таймера, который обновляет дату и время. Назначает панель и ползунок который указывает на выбранную панель.
        public Form3()
        {
            InitializeComponent();
            MovePanelSlide(btnstate);
            timerDateTime.Start();
            AddControl(s);
        }
        State s = new State();
        AddUser us = new AddUser();
        bool open = true;
        //Вставляет контрол в панель с удалением прошлой, чтобы не накладывалось.
        public void AddControl (Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        //Ползунок
        public void MovePanelSlide (Control btn)
        {
            pnSlide.Height = btn.Height;
            pnSlide.Top = btn.Top;
        }
        //Назначение панели и ползунок который указывает выбор
        private void btnstate_Click(object sender, EventArgs e)
        {
            MovePanelSlide(btnstate);          
            AddControl(s);
        }
        //Назначение панели и ползунок который указывает выбор
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            MovePanelSlide(btnAddUser);
            AddControl(us);
        }
        //выполняет сворачивание окна
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Открыть/закрыть меню
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (open) {panScoll.Width -= 5; if (panScoll.Width <= 68) { open = false; timerMenu.Stop(); } }
            else { panScoll.Width += 5; if (panScoll.Width >= 265) { open = true; timerMenu.Stop(); } }
        }
        //Запускает таймер в котором идет проверка закрыто или открыто меню
        //и выполняет его исходя из этого открытие или же закрытие меню
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        //Дата и Время
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToShortTimeString();
            Date.Text = DateTime.Now.ToShortDateString();
        }
        //Кнопка чтобы выйти обратно к окну авторизации. 
        //Рестарт, чтобы не загружать память, избегая кучи кода для его очистки.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //Полный выход из приложения.
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
