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
            MessageBox.Show("X wins!");
        }
        void owin()
        {
            label1.Text = "O WINS!";
            MessageBox.Show("O wins!");
        }
      
        void end()
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            if(x==true)
            {
                button9.Enabled = false;
                x = false;
                button9.Text = "X";
                if(button6.Text == "X" && button3.Text == "X" || button8.Text == "X" && button7.Text == "X" || button5.Text == "X" && button1.Text == "X"  )
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
