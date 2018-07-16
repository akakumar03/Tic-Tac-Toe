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
        bool turn = true; //Gives true if 'X' and false if 'O'
       int turn_count = 0; //Total no. of Counts 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Akshay","Tic-Tac-Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes the application
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            { 
            
                b.Text = "X";
            }
            else
            { 
            
                b.Text = "O";
            }

            turn = !turn; //flip the turns.
            b.Enabled = false;  //This property doesnt allow to rewrite on the same button.s
            turn_count++; //Increasing the turn 
            CheckWinner();
            
        }
        public void CheckWinner()
        {
            DisabledButton();
            bool ThereIsaWinner = false;
            //horizontal Checking of wins

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
            {
                ThereIsaWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
            {
                ThereIsaWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&& (!C1.Enabled))
            {
                ThereIsaWinner = true;
            }
            //Vertical Checking  
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                ThereIsaWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                ThereIsaWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                ThereIsaWinner = true;
            }
            //Diagonal checking
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                ThereIsaWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                ThereIsaWinner = true;
            }
           
            if (ThereIsaWinner)
            {
                string Winner = "";
                if (turn)
                {
                    Winner = "O";
                }
                else
                {
                    Winner = "X";
                }
                MessageBox.Show(Winner + " " + "Wins", "Yay");

            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("It's a draw"); 
                }

            }
           
        }
        public void DisabledButton() //Once the winner is declared
        {
            try                            //Foreach control we are changing it to a string
            {
                foreach (Control C in Controls) //Control is a generic object
                {
                    Button b = (Button)C; //The generic object is converted into a button.
                }
            }
            catch
            {

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control C in Controls) //Control is a generic object
                {
                    Button b = (Button)C; //The generic object is converted into a button.
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {

            }

        }
    }
}

//Study about Foreach.