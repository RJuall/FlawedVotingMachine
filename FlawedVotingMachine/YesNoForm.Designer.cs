namespace FlawedVotingMachine
{
    partial class YesNoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YesNoGrpBox = new System.Windows.Forms.GroupBox();
            this.fiveCandVoteBtn = new System.Windows.Forms.Button();
            this.VoteQuestionLbl = new System.Windows.Forms.Label();
            this.YesRdioBtn = new System.Windows.Forms.RadioButton();
            this.NoRdioBtn = new System.Windows.Forms.RadioButton();
            this.DblVoteBtn = new System.Windows.Forms.Button();
            this.YesNoGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // YesNoGrpBox
            // 
            this.YesNoGrpBox.Controls.Add(this.NoRdioBtn);
            this.YesNoGrpBox.Controls.Add(this.YesRdioBtn);
            this.YesNoGrpBox.Controls.Add(this.VoteQuestionLbl);
            this.YesNoGrpBox.Controls.Add(this.fiveCandVoteBtn);
            this.YesNoGrpBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesNoGrpBox.Location = new System.Drawing.Point(165, 102);
            this.YesNoGrpBox.Name = "YesNoGrpBox";
            this.YesNoGrpBox.Size = new System.Drawing.Size(482, 427);
            this.YesNoGrpBox.TabIndex = 4;
            this.YesNoGrpBox.TabStop = false;
            this.YesNoGrpBox.Text = "Yes or No Vote";
            this.YesNoGrpBox.Enter += new System.EventHandler(this.YesNoGrpBox_Enter);
            // 
            // fiveCandVoteBtn
            // 
            this.fiveCandVoteBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveCandVoteBtn.Location = new System.Drawing.Point(97, 342);
            this.fiveCandVoteBtn.Name = "fiveCandVoteBtn";
            this.fiveCandVoteBtn.Size = new System.Drawing.Size(287, 66);
            this.fiveCandVoteBtn.TabIndex = 7;
            this.fiveCandVoteBtn.Text = "Vote!";
            this.fiveCandVoteBtn.UseVisualStyleBackColor = true;
            this.fiveCandVoteBtn.Click += new System.EventHandler(this.fiveCandVoteBtn_Click);
            // 
            // VoteQuestionLbl
            // 
            this.VoteQuestionLbl.AutoSize = true;
            this.VoteQuestionLbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoteQuestionLbl.Location = new System.Drawing.Point(78, 88);
            this.VoteQuestionLbl.Name = "VoteQuestionLbl";
            this.VoteQuestionLbl.Size = new System.Drawing.Size(335, 32);
            this.VoteQuestionLbl.TabIndex = 5;
            this.VoteQuestionLbl.Text = "Do you support Prop. 42?";
            // 
            // YesRdioBtn
            // 
            this.YesRdioBtn.AutoSize = true;
            this.YesRdioBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesRdioBtn.Location = new System.Drawing.Point(97, 168);
            this.YesRdioBtn.Name = "YesRdioBtn";
            this.YesRdioBtn.Size = new System.Drawing.Size(80, 36);
            this.YesRdioBtn.TabIndex = 5;
            this.YesRdioBtn.Text = "Yes";
            this.YesRdioBtn.UseVisualStyleBackColor = true;
            // 
            // NoRdioBtn
            // 
            this.NoRdioBtn.AutoSize = true;
            this.NoRdioBtn.Checked = true;
            this.NoRdioBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRdioBtn.Location = new System.Drawing.Point(97, 222);
            this.NoRdioBtn.Name = "NoRdioBtn";
            this.NoRdioBtn.Size = new System.Drawing.Size(71, 36);
            this.NoRdioBtn.TabIndex = 8;
            this.NoRdioBtn.TabStop = true;
            this.NoRdioBtn.Text = "No";
            this.NoRdioBtn.UseVisualStyleBackColor = true;
            // 
            // DblVoteBtn
            // 
            this.DblVoteBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DblVoteBtn.Location = new System.Drawing.Point(745, 618);
            this.DblVoteBtn.Name = "DblVoteBtn";
            this.DblVoteBtn.Size = new System.Drawing.Size(1, 1);
            this.DblVoteBtn.TabIndex = 5;
            this.DblVoteBtn.Text = "DblVote";
            this.DblVoteBtn.UseVisualStyleBackColor = true;
            this.DblVoteBtn.Click += new System.EventHandler(this.DblVoteBtn_Click);
            // 
            // YesNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 653);
            this.Controls.Add(this.DblVoteBtn);
            this.Controls.Add(this.YesNoGrpBox);
            this.Name = "YesNoForm";
            this.Text = "Yes or No Vote";
            this.YesNoGrpBox.ResumeLayout(false);
            this.YesNoGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox YesNoGrpBox;
        private System.Windows.Forms.RadioButton NoRdioBtn;
        private System.Windows.Forms.RadioButton YesRdioBtn;
        private System.Windows.Forms.Label VoteQuestionLbl;
        private System.Windows.Forms.Button fiveCandVoteBtn;
        private System.Windows.Forms.Button DblVoteBtn;
    }
}