using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public class Database
    {
        public SQLiteConnection conn;

        public Database()
        {
            conn = new SQLiteConnection("Data source=database.sqliteASG");

            if (!File.Exists("./database.sqliteASG"))
            {
                SQLiteConnection.CreateFile("database.sqlliteASG");
                InitializeDB();
            }

            // plik do wczytania danych do bazy backup jeśli sie chce XML 
        }

        public void InitializeDB()
        {
            //first
            conn.Open();
            string sql = "CREATE TABLE ASGGuns(ID integer Primary Key not null, Model nvarchar(50), Type nvarchar(50), FPS tinyint, Capacity tinyint, PowerSource nvarchar(20));";
            sql += "create table ShooterCollection(ID integer Primary Key not null, ShooterName nvarchar(50), DateCreated date, IDGunModelFK int, FOREIGN KEY (IDGunModelFK) REFERENCES ASGGuns(ID));";
            sql += "create table Scores(ID integer Primary Key not null, ProgramMode nvarchar(50),MinTime decimal(9,2), AVGTime decimal(9,2), MaxTime decimal(9,2), IDShooterFK int, FOREIGN KEY (IDShooterFK) REFERENCES ShooterCollection(ID));";
           
            sql += "create table UserPermissions(ID integer Primary Key not null, UserName nvarchar(20), Password nvarchar(40), SecurityLevel tinyint);";
            sql += "create table Users(ID integer Primary Key not null, FirstName nvarchar(20), Surname nvarchar(40),  IDUser int, FOREIGN KEY (IDUser) REFERENCES UserPermissions(ID));";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();

            //Second


        }


    }
}
