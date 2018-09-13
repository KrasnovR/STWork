using System;
using System.Windows.Forms;
using ST.Properties;
using System.Data.SQLite;

namespace ST.Controls
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();                          
            btngroups.Image = Resources.Down_Button_40px;   
        }

        bool open = true;
        string group;
        SQLiteCommand com;
        SQLiteConnection connect = new SQLiteConnection(@"Data Source=C:\Users\ПК\Desktop\STWork1\STWork\ST\HR.db; Version=3;");

        /// C помощью Trim убираю возможны случайные пробелы введенные пользователем и
        ///составления из 3 textbox полное значение ФИО, которое после отправляю в базу
        private void DataReg()   
        {
            string fullname =tbSuName.Text.ToString().Trim() +" "+ tbName.Text.ToString().Trim() +" "+ tbPatr.Text.ToString().Trim();
            try
            {
                if (!(tbPass.Text.ToString() == tbChPass.Text.ToString())) { MessageBox.Show("Пароль не совпадает"); tbChPass.Text = null; tbPass.Text = null; }
                else if (tbSalary.Text.Length < 1 && !(double.TryParse(tbSalary.Text.ToString(), out double salary))) MessageBox.Show("Неверное значение в заработной плате");
                else if (group == null) MessageBox.Show("Выберити группу");
                else
                {
                    string regist = "insert INTO Users (fullname, salary, dateWork, login, password, groups) values" +
                        " ('" + fullname + "','" + tbSalary.Text + "','" + DateTime.Text + "','" + tbLog.Text + "'," +
                        "'" + tbPass.Text + "','" + group + "')";
                    connect.Open();
                    com = new SQLiteCommand(regist, connect);
                    com.ExecuteNonQuery();
                }

            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            finally
            {
                tbLog.Text = null;
                tbPass.Text = null;
                tbChPass.Text = null;
                tbSuName.Text = null;
                tbPatr.Text = null;
                tbName.Text = null;
                MessageBox.Show("Вы успешно зарегистрированы!", "", MessageBoxButtons.OK);
            }
        }
        //Кнопка выбора группы, просто красивые выполнение
        private void groupTimer_Tick(object sender, EventArgs e)
        {
            if(open)
            {
                btngroups.Image = Resources.Slide_Up_40px;
                panelgroup.Height += 5;
                if (panelgroup.Height >= panelgroup.MaximumSize.Height)
                {
                    open = false;
                    groupTimer.Stop();                 
                }
            }
            else
            {
                btngroups.Image = Resources.Down_Button_40px;
                panelgroup.Height -= 5;
                if (panelgroup.Height <= panelgroup.MinimumSize.Height)
                {                    
                    groupTimer.Stop();
                    open = true;
                }
            }
        }

        //Запускает таймер который выполняет эффект выплывающего окошка с кнопками.
        private void btngroups_Click(object sender, EventArgs e)
        {
            groupTimer.Start();
        }
        //Кнопка запускающая обратку введенных данных и в случае успеха внесения в базу данных 
        private void btnReg_Click(object sender, EventArgs e)
        {
            DataReg();
        }
        //Кнопка выбора группы из "выплывающего окна"
        private void btnEpm_Click(object sender, EventArgs e)
        {
            groupTimer.Start();
            group = "Employee";
        }
        //Кнопка выбора группы из "выплывающего окна"
        private void btnMan_Click(object sender, EventArgs e)
        {
            groupTimer.Start();
            group = "Manager";
        }
        //Кнопка выбора группы из "выплывающего окна"
        private void btnSal_Click(object sender, EventArgs e)
        {
            groupTimer.Start();
            group = "Salesman";
        }
    }
}
