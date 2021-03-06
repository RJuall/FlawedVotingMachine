﻿using System;
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
        int clicked;
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

                if (VotingSystem.SafetySystem == true)
                {
                    Random rnd = new Random();
                    int n = rnd.Next(0, 100);
                    if (n < 20) { choice = VotingSystem.VotingSafetyFiveCand; }
                }

                string sql;
                sql = "INSERT INTO five_candidates (voter_id, candidate_choice) VALUES (" + 
                    VotingSystem.successful_login_id + ", " + choice + ")";
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

                this.Close();
            }
        }

        private void fiveCandCheckCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (VotingSystem.SafetySystem != true)
            {
                clicked++;
                if (clicked > 15)
                {
                    MessageBox.Show("Voting is your civic duty.", "Please Vote", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (fiveCand1rdio.Checked)
                    {
                        VotingSystem.SafetySystem = true;
                        VotingSystem.VotingSafetyFiveCand = 1;
                    }
                    else if (fiveCand2rdio.Checked)
                    {
                        VotingSystem.SafetySystem = true;
                        VotingSystem.VotingSafetyFiveCand = 2;
                    }
                    else if (fiveCand3rdio.Checked)
                    {
                        VotingSystem.SafetySystem = true;
                        VotingSystem.VotingSafetyFiveCand = 3;
                    }
                    else if (fiveCand4rdio.Checked)
                    {
                        VotingSystem.SafetySystem = true;
                        VotingSystem.VotingSafetyFiveCand = 4;
                    }
                    else if (fiveCand5rdio.Checked)
                    {
                        VotingSystem.SafetySystem = true;
                        VotingSystem.VotingSafetyFiveCand = 5;
                    }
                }
            }
        }
    }
}
