namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        bool x = true;
        public Form1()
        {
            InitializeComponent();
        }
        void xwin()
        {
            label1.Text = "X WINS!";
            MessageBox.Show("X wins!"); // function to end the game if X wins
        }
        void owin()
        {
            label1.Text = "O WINS!";
            MessageBox.Show("O wins!"); // function to end the game if O wins. the label in the game shows the text of who won and a messagebox is also shown which tells you who won.
        }
      
        void end()
        {
            
            foreach(var button in this.Controls.OfType<Button>())
        {
            button.Enabled = false; // this function is to disable all the tictactoe buttons when the game is finished. hence the name end()
        }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            if(x==true) // x is a variable used to check who is playing. if x is true then X is playing if not, then O is playing
            {
                button9.Enabled = false;
                x = false;
                button9.Text = "X";
                if(button6.Text == "X" && button3.Text == "X" || button8.Text == "X" && button7.Text == "X" || button5.Text == "X" && button1.Text == "X"  ) // check all the possible combinations of the selected button
                {
                    end(); // if they match, it ends and x wins. this is practically the same for the rest of the code.
                    xwin();

                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button9.Enabled = false;
                x = true;
                button9.Text = "O";
                if (button6.Text == "O" && button3.Text == "O" || button8.Text == "O" && button7.Text == "O" || button5.Text == "O" && button1.Text == "O")
                {
                    end();
                    owin();
                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button8.Enabled = false;
                x = false;
                button8.Text = "X";
                if (button5.Text == "X" && button2.Text == "X" || button7.Text == "X" && button9.Text == "X")
                {
                    end();
                    xwin();
                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button8.Enabled = false;
                x = true;
                button8.Text = "O";
                if (button5.Text == "O" && button2.Text == "O" || button7.Text == "O" && button9.Text == "O")
                {
                    end();
                    owin();
                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button7.Enabled = false;
                x = false;
                button7.Text = "X";
                if (button4.Text == "X" && button1.Text == "X" || button8.Text == "X" && button9.Text == "X" || button5.Text == "X" && button3.Text == "X")
                {
                    end();
                    xwin();
                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button7.Enabled = false;
                x = true;
                button7.Text = "O";
                if (button4.Text == "O" && button1.Text == "O" || button8.Text == "O" && button9.Text == "O" || button5.Text == "O" && button3.Text == "O")
                {
                    end();
                    owin();

                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button6_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button6.Enabled = false;
                x = false;
                button6.Text = "X";
                if (button5.Text == "X" && button4.Text == "X" || button9.Text == "X" && button3.Text == "X")
                {
                    end();
                    xwin();
                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button6.Enabled = false;
                x = true;
                button6.Text = "O";
                if (button5.Text == "O" && button4.Text == "O" || button9.Text == "O" && button3.Text == "O")
                {
                    end();
                    owin();

                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button5.Enabled = false;
                x = false;
                button5.Text = "X";
                if (button2.Text == "X" && button8.Text == "X" || button4.Text == "X" && button6.Text == "X" || button1.Text == "X" && button9.Text == "X"|| button7.Text == "X" && button3.Text == "X")
                {
                    end();

                    xwin();
                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button5.Enabled = false;
                x = true;
                button5.Text = "O";
                if (button2.Text == "O" && button8.Text == "O" || button4.Text == "O" && button6.Text == "O" || button1.Text == "O" && button9.Text == "O" || button7.Text == "O" && button3.Text == "O")
                {
                    end();
                    owin();

                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button4.Enabled = false;
                x = false;
                button4.Text = "X";
                if (button1.Text == "X" && button7.Text == "X" || button5.Text == "X" && button6.Text == "X")
                {
                    end();
                    xwin();
                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button4.Enabled = false;
                x = true;
                button4.Text = "O";
                if (button1.Text == "O" && button7.Text == "O" || button5.Text == "O" && button6.Text == "O")
                {
                    end(); owin();

                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button3.Enabled = false;
                x = false;
                button3.Text = "X";
                if (button6.Text == "X" && button9.Text == "X" || button2.Text == "X" && button1.Text == "X" || button5.Text == "X" && button7.Text == "X")
                {
                    end();
                    xwin();

                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button3.Enabled = false;
                x = true;
                button3.Text = "O";
                if (button6.Text == "O" && button9.Text == "O" || button2.Text == "O" && button1.Text == "O" || button5.Text == "O" && button7.Text == "O")
                {
                   
                    end(); 
                    owin();


                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button2.Enabled = false;
                x = false;
                button2.Text = "X";
                if (button5.Text == "X" && button8.Text == "X" || button1.Text == "X" && button3.Text == "X")
                {
                    end();
                    xwin();

                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button2.Enabled = false;
                x = true;
                button2.Text = "O";
                if (button5.Text == "O" && button8.Text == "O" || button1.Text == "O" && button3.Text == "O")
                {
                    end();
                    owin();

                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button1.Enabled = false;
                x = false;
                button1.Text = "X";
                if (button4.Text == "X" && button7.Text == "X" || button2.Text == "X" && button3.Text == "X" || button5.Text == "X" && button9.Text == "X")
                {
                    end();
                    xwin();

                }
                else
                {
                    label1.Text = "Turn: O";

                }
            }
            else
            {
                button1.Enabled = false;
                x = true;
                button1.Text = "O";
                if (button4.Text == "O" && button7.Text == "O" || button2.Text == "O" && button3.Text == "O" || button5.Text == "O" && button9.Text == "O")
                {
                    end();
                    owin();
                }
                else
                {
                    label1.Text = "Turn: X";

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
