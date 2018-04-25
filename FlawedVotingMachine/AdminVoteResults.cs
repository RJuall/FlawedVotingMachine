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
    public partial class AdminVoteResults : Form
    {
        public AdminVoteResults()
        {
            InitializeComponent();
            string ConnectionString = "Data Source=Voting.sqlite;Version=3";
            string sql;

            switch (VotingSystem.VoteType)
            {
                case 1:
                    //
                    string totalVotes = "SELECT COUNT(*) FROM five_candidates";
                    string braddockVotes = "Select COUNT(*) FROM five_candidates " +
                        "WHERE candidate_choice=1";
                    string worthingtonVotes = "Select COUNT(*) FROM five_candidates " +
                        "WHERE candidate_choice=2";
                    string rasputinVotes = "Select COUNT(*) FROM five_candidates " +
                        "WHERE candidate_choice=3";
                    string thurmanVotes = "Select COUNT(*) FROM five_candidates " +
                        "WHERE candidate_choice=4";
                    string carosellaVotes = "Select COUNT(*) FROM five_candidates " +
                        "WHERE candidate_choice=5";

                    //
                    using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                    {
                        c.Open();

                        sql = totalVotes;
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();
                                    totalVotesResTxt.Text = rdr[0].ToString();
                                }
                            }
                        }

                        sql = braddockVotes;
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();
                                    braddockResTxt.Text = rdr[0].ToString();
                                }
                            }
                        }

                        sql = worthingtonVotes;
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();
                                    worthingtonResTxt.Text = rdr[0].ToString();
                                }
                            }
                        }

                        sql = rasputinVotes;
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();
                                    rasputinResTxt.Text = rdr[0].ToString();
                                }
                            }
                        }

                        sql = thurmanVotes;
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();
                                    thurmanResTxt.Text = rdr[0].ToString();
                                }
                            }
                        }

                        sql = carosellaVotes;
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();
                                    carosellaResTxt.Text = rdr[0].ToString();
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }            
        }

        private void fiveCandResGrpBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
