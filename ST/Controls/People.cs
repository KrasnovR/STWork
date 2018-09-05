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
    public partial class People : UserControl
    {
        //Запуск методов заполняющие таблицу и окошки колл-во подчиненных и их суммарную заработную плату
        public People()
        {
            InitializeComponent();
            DataConnect();
            SumAll();
        }
        SQLiteCommand com;
        static string ID = Contact.ID;
        SQLiteConnection connect = new SQLiteConnection(@"Data Source C:\Users\ПК\Desktop\STWork1\STWork\ST; Version=3;");

        //Запрос суммы подчиненных данного пользователя и из количество 
        private void SumAll()
        {
            string SumSalary = "select sum(salary) from People where UserID='" + ID + "'";
            com = new SQLiteCommand(SumSalary, connect);
            SQLiteDataReader readerS = com.ExecuteReader();
            while (readerS.Read()) { lbSumSalary.Text = readerS[0].ToString(); }

            string CountPeople = "select count(id) from People where UserID='" + ID + "'";
            com = new SQLiteCommand(CountPeople, connect);
            SQLiteDataReader readerP = com.ExecuteReader();           
            while (readerP.Read()) { lbSumPeople.Text = readerP[0].ToString(); }
        }
        //Заполнение таблицы
        private void DataConnect()
        {           
            string datagrid = "SELECT fullname,salary,level FROM People where UserID='"+ ID +"' ORDER BY fullname";
            com = new SQLiteCommand(datagrid, connect);
            connect.Open();
            SQLiteDataReader reader = com.ExecuteReader();
            List<string[]> date = new List<string[]>();

            while (reader.Read())
            {
                date.Add(new string[3]);
                date[date.Count - 1][0] = reader[0].ToString();
                date[date.Count - 1][1] = reader[1].ToString();
                date[date.Count - 1][2] = reader[2].ToString();
            }

            foreach (string[] a in date) dgvPeople.Rows.Add(a);
        }
    }
}
