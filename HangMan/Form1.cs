using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        const int MAX_WRONG_GUESSES = 6;
        int incorrectGuesses = 0;       // incorrect guess counter
        int letterNo = 0;               // keeps track of the highest amount of letters in a word
        HashSet<char> guessedLetters;   // all the letters the player has guessed
        WordList wl = new WordList();   // world list object

        public Form1()
        {
            InitializeComponent();
            guessedLetters = new HashSet<char>();   // stores guessed letters
            InitializeGame();                       // initialize game settings
        }

        private void buttonButton_Click(object sender, EventArgs e)
        {
            HandleGuess();
        }

        public void WrongGuess()
        {
            if (incorrectGuesses < MAX_WRONG_GUESSES)
            {
                incorrectGuesses++;                   // increment wrong guess counter
                toolStripStatusLabel1.Text = string.Format($"wrong guess #{incorrectGuesses}"); // add hint to debug label
                statusMessages.Refresh();             // refresh status messages
            }
            ChangeHangmanImageTo(incorrectGuesses);   // change image
            if (incorrectGuesses >= MAX_WRONG_GUESSES)
            {
                toolStripStatusLabel1.Text = string.Format("hint: {0}", wl.SecretWord); // add hint to debug label
                statusMessages.Refresh();             // refresh status messages
                MessageBox.Show($"Maximum number of {MAX_WRONG_GUESSES} guesses reached!", 
                                "You lose!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                InitializeGame();                     // start a new game
            }
        }

        public void ChangeHangmanImageTo(int i)
        {
            pbHangman.Image = (Image)Properties.Resources.ResourceManager.GetObject("image" + (i + 1));
            pbHangman.Invalidate();
        }

        public void InitializeGame()
        {
            wl.TestThis();

            guessedLetters.Clear();        // clear previous guesses
            labelGuessed.Text = "";        // reset list of guessed letter
            guessBox.Text = "";            // reset guess box
            this.ActiveControl = guessBox; // make guess box the focused control
            incorrectGuesses = 0;          // reset incorrect guess counter
            ChangeHangmanImageTo(0);       // reset hangman image
            wl.ResetSecretWord();          // reset secret word
            //toolStripStatusLabel1.Text = string.Format("hint: {0}", wl.SecretWord); // add hint to debug label
            //statusMessages.Refresh();      // refresh status messages

            // ensure we have a textbox for each letter
            while (letterNo < wl.SecretWord.Length) { AddNewTextBox(); }

            // format each textbox as needed
            for (int l = 0; l < letterNo; l++)
            {
                TextBox tb = (TextBox)this.Controls.Find("added" + l.ToString(), true).FirstOrDefault();

                if (l >= wl.SecretWord.Length)
                {
                    tb.Visible = false;
                    tb.Text = "";
                }
                else
                {
                    tb.Visible = true;
                    tb.Text = "_";
                }
            }
        }

        public TextBox AddNewTextBox()
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = 250;
            txt.Left = 20 + letterNo * 25;
            txt.Width = 20;
            txt.TextAlign = HorizontalAlignment.Center;
            txt.Name = "added" + letterNo.ToString();
            txt.Font = new Font(txt.Font, FontStyle.Bold);
            txt.ReadOnly = true;
            txt.BackColor = Color.White;
            letterNo++;
            return txt;
        }

        bool CheckGuess(char ch)
        {
            bool found = false;
            for (int i = 0; i < wl.SecretWord.Length; i++)
            {   //does char i in the word match char i in the word
                if (wl.SecretWord[i] == ch)
                {
                    found = true;             // match found!
                    TextBox tb = (TextBox)this.Controls.Find("added" + i.ToString(), true).FirstOrDefault();
                    tb.Text = ch.ToString();  // show matched letter
                }
            }
            return found;
        }

        private bool PlayerWon()
        {   //look at each char in the word and see if it has been guessed
            for (int i = 0; i < wl.SecretWord.Length; i++)
            {
                if (!guessedLetters.Contains(wl.SecretWord[i]))
                { return false; }       //found a character that hasn't been guessed yet
            }
            return true;                //if we reached here, all the characters must have been guessed
        }

        public void HandleGuess()
        {
            if (guessBox.Text.Length > 0)       //make sure player entered something
            {
                char ch = guessBox.Text[0];     //get the 1st character in the text
                if (guessedLetters.Contains(ch))
                {                               //see if the player has guessed the letter
                    MessageBox.Show($"You've already guessed '{ch}'.",
                                    "Error!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {                               //if it hasn't been guessed, see if it's in the word
                    guessedLetters.Add(ch);     //put the letter in the set of used letters
                    labelGuessed.Text += ch;    //append the character to the guessed letters text box
                    if (CheckGuess(ch))
                    {                           //see if the that letter was in the secret word
                        if (PlayerWon())
                        {
                            MessageBox.Show("You win!",
                                            "Congrats!",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        WrongGuess();           // call the wrong guess function
                    }
                }
                guessBox.Text = "";             // clear the guess box
            }
            else
            {
                MessageBox.Show("Please enter a letter a-z", 
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;         //bail out of this function
            }
            guessBox.Focus();   // focus on the guess box
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void guessBox_Enter(object sender, EventArgs e)
        {
            guessBox.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No help for you!",
                            "This is just a joke ;)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
