using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ST
{
    
    //Считаю, что было бы правильнее написать все команды БД в отдельном классе.
    //Так как было бы меньше путаницы и приятней читать код, моя вина, прошу прощения, хотел скорее вам сдать проект.
    
    class Contact 
    {
        public SQLiteConnection connect = new SQLiteConnection(@"Data Source \ST\obj\Debug=HR.db; Version=3;");
        private SQLiteCommand command;
        public static string ID;

        //назначает ФИО во 2форме
        public string Fullname()
        {
            string fullname="";
            command = new SQLiteCommand("select fullname from Users where ID='" + ID + "'", connect);
            OpenConnect();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()) { fullname = reader[0].ToString();}
            return fullname;
        }

        //Авторизация, где еще узнаем ID, который нужен для дальнейших действий.
        //Уверен, что есть намного лучше авторизация, но решил попробовать так.
        public int Login(string log, string pass)
        {    
            int lo = 2;
            string [] acc = {"Users","SuperUser"};
            for (int i = 0; i < acc.Length; i++)
            {
                try
                {
                    string com = "SELECT ID FROM '" + acc[i] + "' WHERE login='" + log + "' AND password='" + pass + "'";
                    command = new SQLiteCommand(com, connect);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           ID = reader[0].ToString();
                        }
                        lo = i;
                        break;
                    }
                }
                catch(Exception e) { MessageBox.Show(e.ToString()); }
            }            
            return lo;
        }

        public void CloseConnect()
        {
            connect.Close();
        }

        public void OpenConnect()
        {
            connect.Open();
        }
    }
}
