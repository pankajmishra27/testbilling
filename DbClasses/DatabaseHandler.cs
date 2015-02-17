﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace ShopProducts.DbClasses
{
    class DatabaseHandler
    {
        public static string CONstr = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails\\DB_Products.mdf";

        public static DataSet SelectQuery(string query, string tablename)
        {
            //try
            //{

            DataSet DS = new DataSet();
            using (SQLiteConnection CON = new SQLiteConnection(CONstr))
            {
                SQLiteCommand CMD = new SQLiteCommand(query, CON);
                SQLiteDataAdapter AD = new SQLiteDataAdapter(CMD);
                AD.Fill(DS, tablename);

            }
            return DS;
            //}
            //catch
            //{
            //    return new DataSet();
            //}
        }

        public static void InsertQuery(string query, string tablename)
        {
            //try
            //{
            using (SQLiteConnection CON = new SQLiteConnection(CONstr))
            {
                SQLiteCommand CMD = new SQLiteCommand(query, CON);
                SQLiteDataAdapter AD = new SQLiteDataAdapter(CMD);
                DataSet DS = new DataSet();
                AD.Fill(DS, tablename);
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
        }

        public static void DeleteQuery(string query, string tablename)
        {
            //try
            //{
            using (SQLiteConnection CON = new SQLiteConnection(CONstr))
            {
                SQLiteCommand CMD = new SQLiteCommand(query, CON);
                SQLiteDataAdapter AD = new SQLiteDataAdapter(CMD);
                DataSet DS = new DataSet();
                AD.Fill(DS, tablename);
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
        }

        public static void UpdateQuery(string query, string tablename)
        {
            //try
            //{
            using (SQLiteConnection CON = new SQLiteConnection(CONstr))
            {
                SQLiteCommand CMD = new SQLiteCommand(query, CON);
                SQLiteDataAdapter AD = new SQLiteDataAdapter(CMD);
                DataSet DS = new DataSet();
                AD.Fill(DS, tablename);
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
        }
    }
}
