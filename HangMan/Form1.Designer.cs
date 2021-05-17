namespace HangMan
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbHangman = new System.Windows.Forms.PictureBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.groupGuesses = new System.Windows.Forms.GroupBox();
            this.labelGuessed = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.statusMessages = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).BeginInit();
            this.groupGuesses.SuspendLayout();
            this.statusMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbHangman
            // 
            this.pbHangman.Image = global::HangMan.Properties.Resources.image1;
            this.pbHangman.Location = new System.Drawing.Point(21, 31);
            this.pbHangman.Name = "pbHangman";
            this.pbHangman.Size = new System.Drawing.Size(300, 200);
            this.pbHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHangman.TabIndex = 1;
            this.pbHangman.TabStop = false;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(375, 347);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(89, 40);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonButton_Click);
            // 
            // groupGuesses
            // 
            this.groupGuesses.Controls.Add(this.labelGuessed);
            this.groupGuesses.Location = new System.Drawing.Point(21, 393);
            this.groupGuesses.Name = "groupGuesses";
            this.groupGuesses.Size = new System.Drawing.Size(443, 49);
            this.groupGuesses.TabIndex = 4;
            this.groupGuesses.TabStop = false;
            this.groupGuesses.Text = "Guessed Letters";
            // 
            // labelGuessed
            // 
            this.labelGuessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGuessed.Location = new System.Drawing.Point(6, 18);
            this.labelGuessed.Name = "labelGuessed";
            this.labelGuessed.Size = new System.Drawing.Size(431, 23);
            this.labelGuessed.TabIndex = 0;
            // 
            // guessBox
            // 
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(312, 347);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(57, 22);
            this.guessBox.TabIndex = 6;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guessBox.Enter += new System.EventHandler(this.guessBox_Enter);
            // 
            // statusMessages
            // 
            this.statusMessages.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusMessages.Location = new System.Drawing.Point(0, 463);
            this.statusMessages.Name = "statusMessages";
            this.statusMessages.Size = new System.Drawing.Size(473, 22);
            this.statusMessages.TabIndex = 8;
            this.statusMessages.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 19);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 485);
            this.Controls.Add(this.statusMessages);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.groupGuesses);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.pbHangman);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hangman";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).EndInit();
            this.groupGuesses.ResumeLayout(false);
            this.statusMessages.ResumeLayout(false);
            this.statusMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbHangman;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.GroupBox groupGuesses;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label labelGuessed;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusMessages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

