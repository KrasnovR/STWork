using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ST.Controls
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            Info();
        }

        Contact all = new Contact();     
        private SQLiteCommand command;
        string ID = Contact.ID;
        static double salary, perSalary, peopleSalary, sumSalary, peopleSumSalary;
        static int PrecDate;
        public static int SumCheck = 0;

        //Исходя из группы выполняем расчет 
        public void Employee()
        {           
            lbSalary.Text = salary.ToString("0,0.00" + " р");
            double per = PrecDate * 3;
            if (per > 30) per = 30;
            perSalary = per / 100 * salary + salary;
        }
        //Исходя из группы выполняем расчет 
        public void Salesman()
        {
            lbSalary.Text = salary.ToString("0,0.00" + " р");
            double per = PrecDate * 1;
            if (per > 35) per = 35;
            perSalary = per / 100 * salary + salary;
            peopleSumSalary = peopleSalary * 0.03 + salary;
            sumSalary = peopleSalary * 0.03 + per / 100 * salary + salary;
        }
        //Исходя из группы выполняем расчет 
        public void Manager()
        {
            lbSalary.Text = salary.ToString("0,0.00" + " р");
            double per = PrecDate * 5;
            if (per > 40) per = 40;
            perSalary = per / 100 * salary + salary;
            peopleSumSalary = peopleSalary * 0.05 + salary;
            sumSalary = peopleSalary * 0.05 + per / 100 * salary + salary;
        }
        //Исходя из выбранных Чекбоксов отображаем заработную плату
        private void cbrate_OnChange(object sender, EventArgs e)
        {
            if (cbrate.Checked == true && cbPrec.Checked == false) lbSalary.Text = perSalary.ToString("0,0.00"+" р");
            else if (cbrate.Checked == false && cbPrec.Checked == false) lbSalary.Text = salary.ToString("0,0.00" + " р");
            else if (cbrate.Checked == false && cbPrec.Checked == true) lbSalary.Text = peopleSumSalary.ToString("0,0.00" + " р");
            else lbSalary.Text = sumSalary.ToString("0,0.00" + " р");
        }
        //Проверка есть ли в базе подчиненные данному пользователю, 
        //если есть выполняется подсчет суммы их З.П, если нет, тогда изменение панелей 
        public void CheckatPeople()
        {
            string check = "SELECT count(UserID) FROM People WHERE UserID=" + ID + "";
            command = new SQLiteCommand(check, all.connect);
            SQLiteDataReader readerCheck = command.ExecuteReader();
            while (readerCheck.Read()) { SumCheck = Convert.ToInt32(readerCheck[0].ToString()); }
            if(SumCheck>0)
            {
                lbcountPeople.Text = SumCheck.ToString();
                string Scom = "SELECT sum(salary) FROM People WHERE UserID=" + ID + "";
                command = new SQLiteCommand(Scom, all.connect);
                SQLiteDataReader readerS = command.ExecuteReader();
                while (readerS.Read()) { peopleSalary = Convert.ToDouble(readerS[0].ToString()); }
            }
            else
            {
                panelsal.Height = panelsal.MinimumSize.Height;
                panelgr.Visible = false;
                panelGRCH.Location = new Point(62, 365);
            }
        }

        //Основная информация из базы данных и запуск метода на проверку подчиненных, можно было бы
        //сюда записать, но для визуализации сделал отдельный метод
        public void Info()
        {
            string date="";
            all.OpenConnect();           
            string Infocom = "SELECT salary,datework,groups FROM Users WHERE ID="+ ID +"";
            command = new SQLiteCommand(Infocom, all.connect);
            SQLiteDataReader readerI = command.ExecuteReader();   
            while(readerI.Read())
            {
                salary = Convert.ToDouble(readerI[0].ToString());
                date = readerI[1].ToString();
                lbgroup.Text = readerI[2].ToString();
            }
            lbDateWork.Text = date;
            PrecDate = Calculatee(Convert.ToDateTime(date));
            CheckatPeople();
            if (lbgroup.Text == "Employee") Employee(); 
            else if (lbgroup.Text == "Manager") Manager();
            else Salesman();
        }
        //Подсчет сколько лет прошло со дня трудоустройства
        public static int Calculatee(DateTime date)
        {
            int Years = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
            {
                Years--;
            }
            return Years;
        }
    }
}
