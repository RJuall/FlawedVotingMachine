namespace FlawedVotingMachine
{
    partial class MultipleCandForm
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
            this.fiveCandGroupBox = new System.Windows.Forms.GroupBox();
            this.fiveCandVoteBtn = new System.Windows.Forms.Button();
            this.fiveCandListBox = new System.Windows.Forms.CheckedListBox();
            this.instructLabel = new System.Windows.Forms.Label();
            this.fiveCandGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fiveCandGroupBox
            // 
            this.fiveCandGroupBox.Controls.Add(this.instructLabel);
            this.fiveCandGroupBox.Controls.Add(this.fiveCandListBox);
            this.fiveCandGroupBox.Controls.Add(this.fiveCandVoteBtn);
            this.fiveCandGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveCandGroupBox.Location = new System.Drawing.Point(46, 40);
            this.fiveCandGroupBox.Name = "fiveCandGroupBox";
            this.fiveCandGroupBox.Size = new System.Drawing.Size(740, 572);
            this.fiveCandGroupBox.TabIndex = 1;
            this.fiveCandGroupBox.TabStop = false;
            this.fiveCandGroupBox.Text = "Vote for Your Candidates";
            // 
            // fiveCandVoteBtn
            // 
            this.fiveCandVoteBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveCandVoteBtn.Location = new System.Drawing.Point(222, 411);
            this.fiveCandVoteBtn.Name = "fiveCandVoteBtn";
            this.fiveCandVoteBtn.Size = new System.Drawing.Size(287, 66);
            this.fiveCandVoteBtn.TabIndex = 6;
            this.fiveCandVoteBtn.Text = "Vote!";
            this.fiveCandVoteBtn.UseVisualStyleBackColor = true;
            this.fiveCandVoteBtn.Click += new System.EventHandler(this.fiveCandVoteBtn_Click);
            // 
            // fiveCandListBox
            // 
            this.fiveCandListBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveCandListBox.FormattingEnabled = true;
            this.fiveCandListBox.Items.AddRange(new object[] {
            "Betsy Braddock",
            "Warren Worthington",
            "Piotr Rasputin",
            "Neena Thurman",
            "Guido Carosella"});
            this.fiveCandListBox.Location = new System.Drawing.Point(165, 162);
            this.fiveCandListBox.Name = "fiveCandListBox";
            this.fiveCandListBox.Size = new System.Drawing.Size(415, 189);
            this.fiveCandListBox.TabIndex = 7;
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Location = new System.Drawing.Point(46, 88);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(654, 23);
            this.instructLabel.TabIndex = 8;
            this.instructLabel.Text = "Please select at least one person for the council, but not more than three.";
            // 
            // MultipleCandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 653);
            this.Controls.Add(this.fiveCandGroupBox);
            this.Name = "MultipleCandForm";
            this.Text = "Council Vote";
            this.fiveCandGroupBox.ResumeLayout(false);
            this.fiveCandGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fiveCandGroupBox;
        private System.Windows.Forms.CheckedListBox fiveCandListBox;
        private System.Windows.Forms.Button fiveCandVoteBtn;
        private System.Windows.Forms.Label instructLabel;
    }
}