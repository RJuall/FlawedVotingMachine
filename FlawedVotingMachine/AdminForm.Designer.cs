namespace FlawedVotingMachine
{
    partial class AdminForm
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
            this.voteSelector = new System.Windows.Forms.GroupBox();
            this.startVoteBtn = new System.Windows.Forms.Button();
            this.voteType3rdio = new System.Windows.Forms.RadioButton();
            this.voteType2rdio = new System.Windows.Forms.RadioButton();
            this.voteType1rdio = new System.Windows.Forms.RadioButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.voteSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // voteSelector
            // 
            this.voteSelector.Controls.Add(this.startVoteBtn);
            this.voteSelector.Controls.Add(this.voteType3rdio);
            this.voteSelector.Controls.Add(this.voteType2rdio);
            this.voteSelector.Controls.Add(this.voteType1rdio);
            this.voteSelector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteSelector.Location = new System.Drawing.Point(57, 65);
            this.voteSelector.Name = "voteSelector";
            this.voteSelector.Size = new System.Drawing.Size(331, 400);
            this.voteSelector.TabIndex = 0;
            this.voteSelector.TabStop = false;
            this.voteSelector.Text = "Vote Selector";
            this.voteSelector.Enter += new System.EventHandler(this.voteSelector_Enter);
            // 
            // startVoteBtn
            // 
            this.startVoteBtn.Location = new System.Drawing.Point(45, 306);
            this.startVoteBtn.Name = "startVoteBtn";
            this.startVoteBtn.Size = new System.Drawing.Size(245, 61);
            this.startVoteBtn.TabIndex = 3;
            this.startVoteBtn.Text = "Begin Vote";
            this.startVoteBtn.UseVisualStyleBackColor = true;
            this.startVoteBtn.Click += new System.EventHandler(this.startVoteBtn_Click);
            // 
            // voteType3rdio
            // 
            this.voteType3rdio.AutoSize = true;
            this.voteType3rdio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteType3rdio.Location = new System.Drawing.Point(45, 224);
            this.voteType3rdio.Name = "voteType3rdio";
            this.voteType3rdio.Size = new System.Drawing.Size(191, 31);
            this.voteType3rdio.TabIndex = 2;
            this.voteType3rdio.TabStop = true;
            this.voteType3rdio.Text = "Yes or No Vote";
            this.voteType3rdio.UseVisualStyleBackColor = true;
            this.voteType3rdio.CheckedChanged += new System.EventHandler(this.voteType3rdio_CheckedChanged);
            // 
            // voteType2rdio
            // 
            this.voteType2rdio.AutoSize = true;
            this.voteType2rdio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteType2rdio.Location = new System.Drawing.Point(45, 146);
            this.voteType2rdio.Name = "voteType2rdio";
            this.voteType2rdio.Size = new System.Drawing.Size(245, 31);
            this.voteType2rdio.TabIndex = 1;
            this.voteType2rdio.TabStop = true;
            this.voteType2rdio.Text = "Multple Option Vote";
            this.voteType2rdio.UseVisualStyleBackColor = true;
            this.voteType2rdio.CheckedChanged += new System.EventHandler(this.voteType2rdio_CheckedChanged);
            // 
            // voteType1rdio
            // 
            this.voteType1rdio.AutoSize = true;
            this.voteType1rdio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteType1rdio.Location = new System.Drawing.Point(45, 68);
            this.voteType1rdio.Name = "voteType1rdio";
            this.voteType1rdio.Size = new System.Drawing.Size(225, 31);
            this.voteType1rdio.TabIndex = 0;
            this.voteType1rdio.TabStop = true;
            this.voteType1rdio.Text = "5 Candidate Race";
            this.voteType1rdio.UseVisualStyleBackColor = true;
            this.voteType1rdio.CheckedChanged += new System.EventHandler(this.voteType1rdio_CheckedChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(341, 539);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(140, 49);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 653);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.voteSelector);
            this.Name = "AdminForm";
            this.Text = "Administrator Panel";
            this.voteSelector.ResumeLayout(false);
            this.voteSelector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox voteSelector;
        private System.Windows.Forms.Button startVoteBtn;
        private System.Windows.Forms.RadioButton voteType3rdio;
        private System.Windows.Forms.RadioButton voteType2rdio;
        private System.Windows.Forms.RadioButton voteType1rdio;
        private System.Windows.Forms.Button CloseBtn;
    }
}