using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlawedVotingMachine
{
    public partial class YesNoForm : Form
    {
        bool voted = false;
        string sql;

        public YesNoForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesNoGrpBox_Enter(object sender, EventArgs e)
        {
            /**
            
            **/
        }

        private void fiveCandVoteBtn_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if (YesRdioBtn.Checked) { choice = 1; }
            sql = "INSERT INTO yes_no (voter_id, voter_choice) VALUES (" +
                      VotingSystem.successful_login_id + "," + choice + ")";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=Voting.sqlite;Version=3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            this.Close();
        }

        private void DblVoteBtn_Click(object sender, EventArgs e)
        {
            if (!voted)
            {
                Random rnd = new Random();
                int voter = rnd.Next(10000000, 89999999);
                int choice = 0;
                if (YesRdioBtn.Checked) { choice = 1; }

                sql = "INSERT INTO yes_no (voter_id, voter_choice) VALUES (" +
                      voter + "," + choice + ")";
                using (SQLiteConnection c = new SQLiteConnection("Data Source=Voting.sqlite;Version=3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                voted = true;
            }
        }
    }
}
