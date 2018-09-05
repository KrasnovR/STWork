using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ST.Controls
{
    public partial class State : UserControl
    {
        public State()
        {
            InitializeComponent();
            dataConnect();
        }

        SQLiteCommand Com;
        //Подсчет з.п, как сотрудников, так и подчиненных, количество людей в разных группах и список сотрудников.
        //Бюджет взят просто для визуального(написано вручную)
        private void dataConnect()
        {
            SQLiteConnection connect = new SQLiteConnection(@"Data Source =HR.db; Version=3;");
            string datagrid = "SELECT fullname,salary,groups FROM Users ORDER BY fullname";
            Com = new SQLiteCommand(datagrid, connect);
            connect.Open();
            SQLiteDataReader reader = Com.ExecuteReader();
            List<string[]> date = new List<string[]>();

            while (reader.Read())
            {
                date.Add(new string[3]);
                date[date.Count - 1][0] = reader[0].ToString();
                date[date.Count - 1][1] = reader[1].ToString();
                date[date.Count - 1][2] = reader[2].ToString();
            }

            foreach (string[] a in date) dgvUsers.Rows.Add(a);

            double SumSalary = 0;
            string[] prof = { "Users", "People" };
            for (int i = 0; i < prof.Length; i++)
            {
                string sumst = "SELECT SUM(salary) FROM "+prof[i]+"";
                Com = new SQLiteCommand(sumst, connect);
                SQLiteDataReader readSum = Com.ExecuteReader();
                while (readSum.Read()) { SumSalary += Convert.ToDouble(readSum[0].ToString()); }
            }
            lbSumSalary.Text = SumSalary.ToString("0,0.0" +" р");


            string[] groups = { "groups='Employee'", "groups='Manager'", "groups='Salesman'" };
            for (int i = 0; i < groups.Length; i++)
            {
                string grSum = "select count(*) from Users where " + groups[i] + "";
                Com = new SQLiteCommand(grSum, connect);
                SQLiteDataReader readgrSum = Com.ExecuteReader();
                while (readgrSum.Read())
                {
                    if (i == 0) lbemp.Text = readgrSum[0].ToString();
                    if (i == 1) lbSal.Text = readgrSum[0].ToString();
                    if (i == 2) lbMan.Text = readgrSum[0].ToString();
                }
            }
            
        }
    }
}
