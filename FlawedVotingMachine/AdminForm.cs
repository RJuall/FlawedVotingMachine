using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlawedVotingMachine
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void startVoteBtn_Click(object sender, EventArgs e)
        {
            if (voteType1rdio.Checked)
            {
                VotingSystem.VoteType = 1;
                VotingSystem.VotingStarted = true;
                MessageBox.Show("The Five Candidate Race has started", "Voting System Start Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (voteType2rdio.Checked)
            {
                VotingSystem.VoteType = 2;
                VotingSystem.VotingStarted = true;
                MessageBox.Show("The Variable Choice Selection Race has started", "Voting System Start Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (voteType3rdio.Checked)
            {
                VotingSystem.VoteType = 3;
                VotingSystem.VotingStarted = true;
                MessageBox.Show("The Yes or No Vote has started", "Voting System Start Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var frm = new LoginForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void voteType1rdio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void voteType2rdio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void voteType3rdio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void voteSelector_Enter(object sender, EventArgs e)
        {
            if (!Controls.OfType<RadioButton>().Any(rb => rb.Checked))
            {
                return;
            }

            if (voteType1rdio.Checked)
            {
                VotingSystem.VoteType = 1;
                VotingSystem.VotingStarted = true;
                MessageBox.Show("The Five Candidate Race has started", "Voting System Start Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (voteType2rdio.Checked)
            {
                VotingSystem.VoteType = 2;
                VotingSystem.VotingStarted = true;
                MessageBox.Show("The Variable Choice Selection Race has started", "Voting System Start Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (voteType3rdio.Checked)
            {
                VotingSystem.VoteType = 3;
                VotingSystem.VotingStarted = true;
                MessageBox.Show("The Yes or No Vote has started", "Voting System Start Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
