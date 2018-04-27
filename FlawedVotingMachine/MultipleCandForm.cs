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
    public partial class MultipleCandForm : Form
    {
        string sql;
        int [] voted = { 0, 0, 0, 0, 0 };
        int checkedItemsLimit = 3;
        int votedAtt = 0;

        public MultipleCandForm()
        {
            InitializeComponent();
        }

        private void fiveCandVoteBtn_Click(object sender, EventArgs e)
        {
            if (fiveCandListBox.CheckedItems.Count != 0 &&
                fiveCandListBox.CheckedItems.Count <= 3 ||
                fiveCandListBox.CheckedItems.Count != 0 &&
                votedAtt > 3)
            {
                foreach (int indexChecked in fiveCandListBox.CheckedIndices)
                {
                    voted[indexChecked] = 1;
                }

                sql = "INSERT INTO variable_choice (voter_id, candidate_one, candidate_two," +
                    "candidate_three, candidate_four, candidate_five) VALUES (" +
                    VotingSystem.successful_login_id + "," + voted[0] + "," + voted[1] + "," +
                    voted[2] + "," + voted[3] + "," + voted[4] + ")";
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
            else
            {
                votedAtt++;
                MessageBox.Show("Please select one candidate, but not more than three", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fiveCandListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (fiveCandListBox.CheckedItems.Count == checkedItemsLimit)
                {
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }
    }
}
