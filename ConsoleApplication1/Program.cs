using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static readonly string DB_PATH = "Data Source=" + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "iWSDB.DB");

        static void Select()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"SELECT *
                                    FROM hero";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["hero_id"].ToString() + dr["hero_name"]);
                        }
                    }
                }
            }
        }

        static void Insert()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"INSERT INTO hero
                                  VALUES
                                  (
                                      1,
                                      '萨满'
                                  )";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void Update()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"UPDATE hero
                                     SET hero_name = '盗贼'
                                   WHERE hero_id = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void Delete()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"DELETE FROM hero";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void CreateTable()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"  create table hero
  (
	  hero_name varchar(100),
	  hero_id varchar(30)
  )";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        static void Main(string[] args)
        {
            var service = iWS.FW.Framework.Service.ServiceContainer.GetServiceProxy<iWS.IS.Organizations.IDistributeService.ILocationService>();
            var d= service.FindAll();
            //CreateTable();
            Insert();
            Select();
            Update();
            Select();
            Delete();
        }

    }
}
