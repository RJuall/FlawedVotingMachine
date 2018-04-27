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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=Voting.sqlite;Version=3";
            string sql;

            string login_id_str = loginBox.Text;
            int login_id;
            bool result = Int32.TryParse(login_id_str, out login_id);

            if (result)
            {
                if (login_id < 10000000)
                {
                    loginBox.Text = "Invalid Login";
                }
                else if (login_id > 99999999)
                {
                    loginBox.Text = "Invalid Login";
                }
                else if (login_id > 90000000)
                {
                    sql = "SELECT * FROM voter_admins WHERE admin_id=" + login_id + ";";
                    using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                    {
                        c.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    VotingSystem.successful_login_id = login_id;
                                    if (VotingSystem.VotingStarted == false)
                                    {
                                        var frm = new AdminForm();
                                        frm.Location = this.Location;
                                        frm.StartPosition = FormStartPosition.Manual;
                                        frm.FormClosing += delegate { this.Show(); };
                                        frm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        var frm = new AdminVoteResults();
                                        frm.Location = this.Location;
                                        frm.StartPosition = FormStartPosition.Manual;
                                        frm.FormClosing += delegate { this.Show(); };
                                        frm.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    loginBox.Text = "Invalid Login";
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    if (VotingSystem.VotingStarted == false)
                    {
                        loginBox.Text = "Voting has not started";
                    }
                    else
                    {
                        sql = "SELECT * FROM voter_list WHERE voter_id=" + login_id + ";";
                        using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                        {
                            c.Open();
                            using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                            {
                                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                                {
                                    if (rdr.HasRows)
                                    {
                                        VotingSystem.successful_login_id = login_id;
                                        rdr.Read();
                                        VotingSystem.successful_login_id_can_vote = Convert.ToBoolean(rdr["voted"]);
                                        if (!VotingSystem.successful_login_id_can_vote)
                                        {
                                            if (VotingSystem.VoteType == 1)
                                            {
                                                var frm = new FiveCandForm();
                                                frm.Location = this.Location;
                                                frm.StartPosition = FormStartPosition.Manual;
                                                frm.FormClosing += delegate { this.Show(); };
                                                frm.Show();
                                                this.Hide();
                                            }
                                            else if (VotingSystem.VoteType == 2)
                                            {
                                                var frm = new MultipleCandForm();
                                                frm.Location = this.Location;
                                                frm.StartPosition = FormStartPosition.Manual;
                                                frm.FormClosing += delegate { this.Show(); };
                                                frm.Show();
                                                this.Hide();
                                            }
                                            else if (VotingSystem.VoteType == 3)
                                            {
                                                var frm = new YesNoForm();
                                                frm.Location = this.Location;
                                                frm.StartPosition = FormStartPosition.Manual;
                                                frm.FormClosing += delegate { this.Show(); };
                                                frm.Show();
                                                this.Hide();
                                            }
                                        }
                                        else
                                        {
                                            loginBox.Text = "Already Voted";
                                        }
                                    }
                                    else
                                    {
                                        loginBox.Text = "Invalid Login";
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
            else
            {
                loginBox.Text = "Invalid Login";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Application.Exit();
    }
}
