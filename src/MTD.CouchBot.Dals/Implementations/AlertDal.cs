﻿using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace MTD.CouchBot.Dals.Implementations
{
    public class AlertDal : IAlertDal
    {
        string MyConnection2 = "";

        public async Task LogAlert(string platform, ulong guildId)
        {
            var query = "INSERT INTO `alertlog`(`Platform`, `GuildId`, `CreatedDate`) VALUES ('" + platform + "','" + guildId + "','" + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();

            while (MyReader2.Read())
            {

            }
            MyConn2.Close();
            await MyConn2.ClearPoolAsync(MyConn2);
            await MyConn2.ClearAllPoolsAsync();
        }
    }
}
