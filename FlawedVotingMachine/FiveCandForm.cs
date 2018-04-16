using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FlawedVotingMachine
{
    public partial class FiveCandForm : Form
    {
        public FiveCandForm()
        {
            InitializeComponent();
        }

        private void fiveCandVoteBtn_Click(object sender, EventArgs e)
        {
            if (!fiveCandCheckCheck.Checked)
            {
                return;
            }
            else
            {
                int choice = 0;
                
                if (fiveCand1rdio.Checked)
                {
                    choice = 1;
                }
                else if (fiveCand2rdio.Checked)
                {
                    choice = 2;
                }
                else if (fiveCand3rdio.Checked)
                {
                    choice = 3;
                }
                else if (fiveCand4rdio.Checked)
                {
                    choice = 4;
                }
                else if (fiveCand5rdio.Checked)
                {
                    choice = 5;
                }

                string sql;
                sql = "INSERT INTO five_candidates (voter_id, candidate_choice) VALUES (" + VotingSystem.successful_login_id + ", " + choice + ")";
                using (SQLiteConnection c = new SQLiteConnection("Data Source=Voting.sqlite;Version=3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                sql = "UPDATE voter_list SET voted=1 WHERE voter_id=" + VotingSystem.successful_login_id;
                using (SQLiteConnection c = new SQLiteConnection("Data Source=Voting.sqlite;Version=3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                var frm = new LoginForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
        }
    }
}
