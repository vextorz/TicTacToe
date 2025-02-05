///////////////////////////////////////////////////////////////////
// Duc Vy Dang
// TINFO-200 
//
// This program is a simple TicTacToe game with the human vs the computer
// each player will be choosing randomly in the beginning of the game.
// The winner is determine by placing 3 "X" or "O" in a line.
//
// Change History
// Date             Developer               Description
// 2024-02-06       Duc Vy Dang             Initial creation of program, app, and this file.
// 2024-02-06       Duc Vy Dang             Creating button, pannel, and text box on GUI. Making
//                                          simple function of button on the board.
// 2024-02-07       Duc Vy Dang             Creating operation method, variables, and event handler.
// 2024-02-08       Duc Vy Dang             Correcting determineWinner method to handle error.
//                                          Prevent human and computer moves from overlapping.
//                                          Testing cases that will happen during program operation.
//                                          Finishing up the program and adding more comments.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Create X and O as enum type to assign for player or computer
        // Create a random object to call
        // Create a list of button and initialized it in restartGame method
        // Create boolean nextTurn variable to prevent overlap move
        bool nextTurn = true;
        private enum Player { X, O }
        Player assignPlayer;
        Player assignComputer;
        private static Random randomNumb = new Random();
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            restartGame(); // Calling the restartGame method to setup the game
              
        }

        // Event handler for player button
        private void boardBtn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            // Determine if whether the human player play as X or O
            if (assignPlayer == Player.X)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O";
            }
            // Disable button so the player cannot press it,
            // and also remove the button from the "buttons" list 
            // so the computer cannot randomly choose it again
            btn.Enabled = false;
            buttons.Remove(btn);
            // Check for winner  by calling it's method
            // Switched nexTurn to false to give turn to computer
            nextTurn = false;
            determineWinner();
        }

        // Method for computer turn
        private void computerTurn()
        {
            // Generate a random number based on the length of
            // the buttons's list
            int move = randomNumb.Next(buttons.Count);
            // Check if there are still empty place on board
            // for next move. This will prevent error.
            if (buttons.Any())
            {
                if (assignComputer == Player.X)
                {
                    buttons[move].Text = "X";
                }
                else
                {
                    buttons[move].Text = "O";
                }
                // Disable button so the player cannot press it,
                // and also remove the button from the "buttons" list 
                // so the computer cannot randomly choose it again
                buttons[move].Enabled = false;
                buttons.RemoveAt(move);
            }
            // Check for winning player
            // Swtiched nextTurn to true to not calling
            // this method again in the determineWinner method
            nextTurn = true;
            determineWinner();

        }

        // This method is for the new game button
        // pressing it will call the restartGame method 
        // and restart the game.
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        // This method will decide who will win and if the game is tie
        private void determineWinner()
        {
            // Check for 3 "X" on horizontal or vertical or diagonal 
            if (a1Btn.Text == "X" && a2Btn.Text == "X" && a3Btn.Text == "X"
                || b1Btn.Text == "X" && b2Btn.Text == "X" && b3Btn.Text == "X"
                || c1Btn.Text == "X" && c2Btn.Text == "X" && c3Btn.Text == "X"
                || a1Btn.Text == "X" && b1Btn.Text == "X" && c1Btn.Text == "X"
                || a2Btn.Text == "X" && b2Btn.Text == "X" && c2Btn.Text == "X"
                || a3Btn.Text == "X" && b3Btn.Text == "X" && c3Btn.Text == "X"
                || a1Btn.Text == "X" && b2Btn.Text == "X" && c3Btn.Text == "X"
                || c1Btn.Text == "X" && b2Btn.Text == "X" && a3Btn.Text == "X")
            {
                // Display player or computer winning message 
                // based on who is assigned X
                if (assignPlayer == Player.X)
                {
                    display.Text = "Player Win!";
                }
                else if (assignComputer == Player.X)
                {
                    display.Text = "Computer Win!";
                }
                // Disable all the available empty spots on the board
                foreach (Button x in buttons)
                {
                    x.Enabled = false;
                }

            }
            // Check for 3 "O" on horizontal or vertical or diagonal 
            else if (a1Btn.Text == "O" && a2Btn.Text == "O" && a3Btn.Text == "O"
                || b1Btn.Text == "O" && b2Btn.Text == "O" && b3Btn.Text == "O"
                || c1Btn.Text == "O" && c2Btn.Text == "O" && c3Btn.Text == "O"
                || a1Btn.Text == "O" && b1Btn.Text == "O" && c1Btn.Text == "O"
                || a2Btn.Text == "O" && b2Btn.Text == "O" && c2Btn.Text == "O"
                || a3Btn.Text == "O" && b3Btn.Text == "O" && c3Btn.Text == "O"
                || a1Btn.Text == "O" && b2Btn.Text == "O" && c3Btn.Text == "O"
                || c1Btn.Text == "O" && b2Btn.Text == "O" && a3Btn.Text == "O")
            {
                // Display player or computer winning message 
                // based on who is assigned O
                if (assignPlayer == Player.O)
                {
                    display.Text = "Player Win!";
                }
                else if (assignComputer == Player.O)
                {
                    display.Text = "Computer Win!";
                }
                // Disable all the available empty spots on the board
                foreach (Button x in buttons)
                {
                    x.Enabled = false;
                }

            }
            // Check if all the spots on the board are full but no
            // matches, then display the game is tie
            else if (!buttons.Any())
            {
                display.Text = "It's a TIE game!";
                foreach (Button x in buttons)
                {
                    x.Enabled = false;
                }
            }
            // If the game still going, check to see whether
            // the computer had moved last turn to decide
            // if need to call it again
            else if(nextTurn == false)
            {
                computerTurn();
            }

        }

        // This method determine who will go first
        // and display which player is X or O
        private void whoIsFirst()
        {
            // Generate chances for player or computer to go first
            int rand = randomNumb.Next(1, 3);
            // If "rand" = 1 then human player will go first and vice versa
            if (rand == 1)
            {
                assignPlayer = Player.X;
                assignComputer = Player.O;
                display.Text = "Player is X, Computer is O";
            }
            else
            {
                assignPlayer = Player.O;
                assignComputer = Player.X;
                display.Text = "Computer is X, player is O";
                // Calling the computer method to begin it's turn
                computerTurn();
            }
        }

        // This method to refresh everything in the game
        // It also hold the list of button on the board
        private void restartGame()
        {
            // Create the list of button to place X/O on the board
            buttons = new List<Button> { a1Btn, a2Btn, a3Btn, b1Btn,
                b2Btn, b3Btn, c1Btn, c2Btn, c3Btn};
            // Clear every button in the list
            foreach (Button item in buttons)
            {
                item.Enabled = true;
                item.Text = null;
            }
            // Clear display message textbox
            display.Text = null;
            // Calling the whoIsFirst method to decide who will go first again
            whoIsFirst();
        }

        // This method stop everything immedately
        private void stopBtn_Click(object sender, EventArgs e)
        {
            // Disable all the buttons
            foreach (Button x in buttons)
            {
                x.Enabled = false;
            }
            // Notify user that the game has stopped
            display.Text = "The game has stopped!";
        }
    }
}
