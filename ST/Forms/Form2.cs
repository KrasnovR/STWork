using ST.Controls;
using System;
using System.Windows.Forms;

namespace ST
{
    public partial class Form2 : Form
    {
        //Старт для таймера, который обновляет дату и время. Назначает панель и ползунок который указывает на выбранную панель.
        //Присваивает ФИО и проверяет нужны ли панели с данными подчиненных.
        public Form2()
        {            
            InitializeComponent();
            timerDateTime.Start();
            movePanelSlide(btnProf);
            AddControlsToPanel(prof);
            lbFullname.Text = all.Fullname();            
            if(Profile.SumCheck == 0) { btnPeople.Visible = false; panelGr.Visible = false; }
        }
        Contact all = new Contact();
        Profile prof = new Profile();
        People peop = new People();
        bool open = true;

        //Открыть/закрыть меню
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (open) {panScoll.Width -= 5; if (panScoll.Width <= 68) { open = false; timerMenu.Stop(); } }
            else {panScoll.Width += 5; if (panScoll.Width >= 265) { open = true; timerMenu.Stop(); } }           
        }
        //Ползунок
        private void movePanelSlide (Control btn)
        {
            panelSlide.Height = btn.Height;
            panelSlide.Top = btn.Top;
        }
        //Запускает таймер в котором идет проверка закрыто или открыто меню 
        //и выполняет его исходя из этого открытие или же закрытие меню
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        //Вставляет контрол в панель с удалением прошлой, чтобы не накладывалось.
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        //Назначение панели и ползунок который указывает выбор
        private void btnProf_Click(object sender, EventArgs e)
        {
            movePanelSlide(btnProf);           
            AddControlsToPanel(prof);
        }
        //Назначение панели и ползунок который указывает выбор
        private void btnPeople_Click(object sender, EventArgs e)
        {
            movePanelSlide(btnPeople);
            AddControlsToPanel(peop);
        }
        //Дата и Время
        private void timer2_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToShortTimeString();
        }
        //выполняет сворачивание окна
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
