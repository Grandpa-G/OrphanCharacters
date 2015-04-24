using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using Terraria;
using TShockAPI;
using Mono.Data.Sqlite;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using TerrariaApi.Server;
using Newtonsoft.Json.Linq;
using TShockAPI.DB;


namespace OrphanCharacters
{
    public partial class OrphanGUI : Form
    {
        public OrphanGUI()
        {
            InitializeComponent();

            lblVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblServerName.Text = Terraria.Netplay.serverListenIP.ToString() + ":" + TShock.Config.ServerPort;
            lblVersion.Text = lblVersion.Text + " using " + TShock.Config.StorageType + " " + TShock.Config.MySqlDbName + " " + TShock.Config.MySqlHost;

            FindOrphans();

        }

        /// <summary>
        /// Gets a list of tsCharacter orphans from db.
        /// </summary>
        private void FindOrphans()
        {
            String sql;
            dataOrphans.Rows.Clear();
            try
            {
                sql = "SELECT * FROM tsCharacter ts where ts.account not in (select id from Users) order by Account";
                using (var reader = TShock.DB.QueryReader(sql))
                {
                    while (reader.Read())
                    {
                        dataOrphans.Rows.Add(false, reader.Get<Int32>("Account"), reader.Get<string>("Inventory"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return;
        }

        private void DeleteOrphans_Click(object sender, EventArgs e)
        {
            bool anyDeleted = false;
            int deleted = 0; 
            foreach (DataGridViewRow row in dataOrphans.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    deleteOrphan(row.Cells[1].Value.ToString());
                    anyDeleted = true;
                    deleted++;
                }
            }
            if (anyDeleted)
            {
                double oweMe = deleted * .001;
                youOweMe.Text = String.Format("You owe me {0:C} for {1} deletions", oweMe, deleted);

                FindOrphans();
            }
        }
        private void refreshOrphans_Click(object sender, EventArgs e)
        {
            FindOrphans();
        }
        private void deleteOrphan(string account)
        {
            String sql;

            try
            {
                sql = "DELETE FROM tsCharacter where Account =" + account;
                TShock.Log.ConsoleInfo("Orphan pruned account " + account);
                var reader = TShock.DB.Query(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
             return;
        }
        private void dataOrphan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dataOrphans.Rows[dataOrphans.CurrentRow.Index].Cells[0];

            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "True":
                    ch1.Value = false;
                    break;
                case "False":
                    ch1.Value = true;
                    break;
            }
        }
        private static bool selectAllFlag = true;
        private void selectAll_Click(object sender, EventArgs e)
        {
            string buttonText = "";
            if (selectAllFlag)
                buttonText = "Clear All";
            else
                buttonText = "Select All";
            foreach (DataGridViewRow row in dataOrphans.Rows)
            {
                row.Cells[0].Value = selectAllFlag;
            }
            selectAllFlag = !selectAllFlag;
            selectAll.Text = buttonText;
        }

    }
}
