/*
* Alex Drogo
* CIS 3309
* Due 2/05/2020
* Bingo - Form Class
* The form class is where all the other classes are combined and used to create the experiance the user will play with. 
* It also creates the board itself and controls all the buttons and checks to make sure the game stays fair and their are no 
* issues that would cause the game to become unstable or unplayable.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGame
{
    public partial class frmBingo : Form
    {
        // Named constants
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        // This next statement does three things.  See if you can figure out what they are
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];
        char nextCalledLetter;
        int nextCalledNumber;
        string playerName;

        private InternalCardType2DimArray internalCardRep2DArray = new InternalCardType2DimArray();
        private RNGType RNGObj = new RNGType();
        private SelectedNumbersListType selectedNumbersObj = new SelectedNumbersListType();
        private PlayerType player = new PlayerType();

        private string bingoLetters = "BINGO";
        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        public frmBingo()
        {
            InitializeComponent();
        }

        //Exits form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Saves the player's name
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Saves the name that the user types into the player name textbox.
            playerName = txtName.Text;
        }


        //The let's go button: it crates the bingo board and makes it visable to the user
        private void btnPlay_Click(object sender, EventArgs e)
        {  
            //If statement that checks to make sure a name is entered in the player name textbox
            if (txtName.Text == "")
            {
                MessageBox.Show("No name was entered.  Try again.", "Missing Name");
                txtName.Focus();
            }
            else
            {
                //makes the bingo board visable
                lblHowToPlay.Visible = true;
                lblWhatWeDo.Visible = true;
                txtNumberCalled.Visible = true;
                lblBingoCard.Visible = true;
                lblDontHave.Visible = true;
                btnDontHave.Visible = true;
                btnDontHave.Enabled = true;
                //Disables the play button after a proper name is inserted.
                btnPlay.Enabled = false;
                
                createBingoCardOnForm();
                playTheGame();
            }  // end if  // end btnLetsGo-Click Handler        
        }// end btnLetsGo-Click Handler  

        //The play game method creates the values that go into the number called text box
        //It creates the next number and next letter and concatinates them together
        private void playTheGame()
        {
            nextCalledNumber = RNGObj.getNextUniqueRandomValue(1, 75);
            nextCalledLetter = bingoLetters[(nextCalledNumber - 1) / NUMBERSPERCOLUMN];
            txtNumberCalled.Text = nextCalledLetter + "" + nextCalledNumber.ToString("n0");
        }

        //Makes form visable and calls the create card method
        private void createBingoCardOnForm()
        {
            pnlCard.Visible = true;
            createCard();
        }  // end createBingoCardOnForm


        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Enabled = true;

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                        newButton[row, col].Enabled = false;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    

                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            //Reset is used to reset the array to either all false or all 0 in the selecte numbers class.
            Globals.selectedNumbersListObj.reset();
         } // end createBoard


        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 40);
            lblColID.TabIndex = 0;
            lblColID.Text = "B      I      N     G     O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels

        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar

        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar

        //Performs all the tasks needed when the user clicks on a number on the bingo board
        //If the user has the number that is called they press the box and it turns orange
        //The if/else statement also prevents the user from being able to cheat and click any number on the board.
        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCount2D;
            int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!", "Selected Number");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if(selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                internalCardRep2DArray.recordSelectedSpace(rowID, colID);

                bingoCount2D = internalCardRep2DArray.isBingo(rowID, colID);

                if(bingoCount2D == 1)
                {
                    MessageBox.Show("You Win " + playerName.ToString() + "! Thanks For Playing!", "CONGRATS");
                    Close();
                }

                playTheGame();
            }
            else
            {
                MessageBox.Show("Hey! That number hasnt been called yet!", "CHEATER");
            }
        } // end button clickhandler 

        //Converts a character to an integer
        int convertCharToInt(char c)
        {
            return ((int)(c) - (int)('0'));
        } //  end convertCharToInt


        //This is a helper method for the dont have button method. It iterates through the row and then column to find the number on the board and 
        //compare it to the number called.
        private bool checkBoard(char column, int called)
        {
            //Finds the index
            int bLindex = (nextCalledNumber - 1) / NUMBERSPERCOLUMN;

            for (int i = 0; i < newButton.GetLength(0); i++)
            {
                //Check for freespace
                if(i == 2 && bLindex == 2)
                {
                    continue;
                }
                
                //Checks the column by index and then rows for the number being called. If it is found it returns false to be used in the dont have 
                //method to prevent user from pressing the dont have button.
                else if(Int32.Parse(newButton[i, bLindex].Text) == nextCalledNumber)
                {
                    return true;
                }
            }

            return false;
        }

        //This is the don't have button that the user presses if the number called is not on their board
        //It will also check to make sure the user does not miss a called number or press dont have by mistake
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            char column = char.Parse(txtNumberCalled.Text.Substring(0, 1));
            
            //Uses the check board method to find the number and if it returns true that the number was found on the board, this will alert the user
            //that they have the number called and they should check the board again.
            if (checkBoard(column, nextCalledNumber))
            {
                MessageBox.Show("You have that number on your board!", "Check Again");
                return;
            }
            else
            {
                playTheGame();
            }
        }
    }
}