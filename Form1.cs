using System.Xml.Linq;

namespace XOX
{
    public partial class Form1 : Form
    {
        bool turn = true;
        byte activeSquare = 0;
        bool redOrBlue = true;


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
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

            RedTeambtn.Enabled = false;
            BlueTeambtn.Enabled = false;

            StartGamebtn.Enabled = false;
            ResetGamebtn.Enabled = false;


        }

        //Choosing side first.
        public void ChooseSidebtn_Click(object sender, EventArgs e)
        {
            RedTeambtn.Enabled = true;
            BlueTeambtn.Enabled = true;
        }


        public void RedTeambtn_Click(object sender, EventArgs e)
        {
            redOrBlue = true;

            BlueTeambtn.Enabled = false;
            StartGamebtn.Enabled = true;
            ChooseSidebtn.Enabled = false;
        }

        public void BlueTeambtn_Click(object sender, EventArgs e)
        {
            redOrBlue = false;

            RedTeambtn.Enabled = false;
            StartGamebtn.Enabled = true;
            ChooseSidebtn.Enabled = false;
        }



        public void Check(object sender, EventArgs e)
        {
            bool winner = false;


            //Horizontal control
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                winner = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                winner = true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                winner = true;
            }
            //Vertical control
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                winner = true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                winner = true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                winner = true;
            }
            //Cross control
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                winner = true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                winner = true;
            }

            if (winner)
            {
                if (redOrBlue==true) // red kazandý
                {
                    string winnerSide;

                    if (turn)
                    {
                        winnerSide = "O";
                        MessageBox.Show($"Winner is Blue Team");

                    }
                    else
                    {
                        winnerSide = "X";
                        MessageBox.Show($"Winner is Red Team");

                    }

                    ResetGamebtn_Click(sender, e);

                    //string winnerSide;

                    //if (turn)
                    //{
                    //    winnerSide = "O";
                    //}
                    //else
                    //{
                    //    winnerSide = "X";
                    //}
                    //MessageBox.Show($"Winner is {winnerSide}");

                    //ResetGamebtn_Click(sender, e);

                }
                else if (redOrBlue==false) 
                {
                    string winnerSide;

                    if (turn)
                    {
                        winnerSide = "O";
                        MessageBox.Show($"Winner is Red Team");

                    }
                    else
                    {
                        winnerSide = "X";
                        MessageBox.Show($"Winner is Blue Team");

                    }

                    ResetGamebtn_Click(sender, e);

                }

               


            }
            else if (activeSquare == 9)
            {
                MessageBox.Show("There is no winner");
                ResetGamebtn_Click(sender, e);
            }

        }

        # region Choosing side completed and the game will be launched.
        public void StartGamebtn_Click(object sender, EventArgs e)
        {
            RedTeambtn.Enabled = false;
            BlueTeambtn.Enabled = false;

            ResetGamebtn.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            StartGamebtn.Enabled = false;
        }
        #endregion


        #region Buttons putting X or O which is turn.

        public void button_click(object sender, EventArgs e)
        {

            if (redOrBlue == false)
            {
                Button b = (Button)sender;

                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Blue;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Red;
                }

                turn = !turn;
                activeSquare++;


                Check(sender, e);
            }

            else if (redOrBlue == true)
            {
                Button b = (Button)sender;

                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Red;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Blue;
                }

                turn = !turn;
                activeSquare++;



                //b.Enabled = false;

                Check(sender, e);
            }




        }
        private void button1_Click(object sender, EventArgs e)
        {
            button_click(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_click(sender, e);

        }
        #endregion




        public void ResetGamebtn_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            turn = true;
            activeSquare = 0;

            ChooseSidebtn_Click(sender, e);
            MessageBox.Show("Choose Side Again");

        }


        public void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}