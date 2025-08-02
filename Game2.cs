using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class game2 : Form
    {
        ResizeHelper resizeHelper=new ResizeHelper();
        ScreenFixer screenFixer = new ScreenFixer();
        int player1Choice;
        int player2Choice;
        int player1Score = 0;
        int player2Score = 0;
        Menu m;
        public game2(Menu main)
        {
            m = main;
            InitializeComponent();
            btnEnter.Focus();
        }
        private void comparison(int player1Choice, int player2Choice)
        {
            //this method is similar to method of Game
            if (player1Choice - player2Choice == 1 || player1Choice - player2Choice == -2)
            {
                player1Score++;
                lblP1Score.Text = player1Score.ToString();
            }
            else if (player1Choice - player2Choice == -1 || player1Choice - player2Choice == 2)
            {
                player2Score++;
                lblP2Score.Text = player2Score.ToString();
            }
            if (player2Score == 10 || player1Score == 10)
            {
                btnRockP1.Enabled = false;
                btnPaperP1.Enabled = false;
                btnScissorsP1.Enabled = false;
                btnRockP2.Enabled = false;
                btnPaperP2.Enabled = false;
                btnScissorsP2.Enabled = false;
                lblResult.Visible = true;
                btnPlayAgainTwoPlayer.Visible = true;
                btnExitTwoPlayer.Visible = true;
                btnPlayAgainTwoPlayer.Focus();
                //When the Game is Finish image of buttons turn into Black and White
                btnRockP1.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Black&White Rock.bmp");
                btnScissorsP1.BackgroundImage= Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Black&White Scissors.bmp");
                btnPaperP1.BackgroundImage= Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Black&White Paper.bmp");
                btnRockP2.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Black&White Rock.bmp");
                btnScissorsP2.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Black&White Scissors.bmp");
                btnPaperP2.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Black&White Paper.bmp");

                if (player1Score > player2Score)
                {
                    if (m.op.num == 0) lblResult.Text = "PLAYER 1 WINS!";

                    else if(m.op.num == 1) lblResult.Text = "!بازیکن اول  برنده شد";
                    lblResult.ForeColor = Color.Blue;
                }
                else
                {

                    if (m.op.num == 0) lblResult.Text = "PLAYER 2 WINS";
                    else if (m.op.num == 1) lblResult.Text = "!بازیکن دوم  برنده شد"; 
                    lblResult.ForeColor = Color.Red; 
                }
            }
        }
        private void resetGame()
        {
            btnEnter.Focus();
            btnRockP1.Visible= false;
            btnPaperP1.Visible = false;
            btnScissorsP1.Visible = false;
            btnRockP2.Visible = false;
            btnPaperP2.Visible = false;
            btnScissorsP2.Visible = false;
            btnRockP1.Enabled = true;
            btnPaperP1.Enabled = true;
            btnScissorsP1.Enabled = true;
            btnRockP2.Enabled = true;
            btnPaperP2.Enabled = true;
            btnScissorsP2.Enabled = true;
            player1Score = 0;
            player2Score = 0;
            lblP1Score.Text = "0";
            lblP2Score .Text= "0";
            btnPlayAgainTwoPlayer.Visible = false;
            btnExitTwoPlayer.Visible = false;
            lblResult.Visible = false;
            btnEnter.Visible = true;
            pictureBoxP1.Image = null;
            pictureBoxP2.Image=null;
            btnRockP1.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Rock.png");
            btnScissorsP1.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Scissors.png");
            btnPaperP1.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Paper.png");
            btnRockP2.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Rock.png");
            btnScissorsP2.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Scissors.png");
            btnPaperP2.BackgroundImage = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Paper.png");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            resizeHelper.SetTargetForm(this);
            resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());
            screenFixer.setOnScreen(this);
        }
        private void game2_Resize(object sender, EventArgs e)
        {
            resizeHelper.ResizeControls();
        }

        private void game2_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter: btnEnter.PerformClick();break;
                case Keys.Z: btnRockP1.PerformClick();break; 
                case Keys.X:btnPaperP1.PerformClick();break;
                case Keys.C:btnScissorsP1.PerformClick();break;
                case Keys.NumPad1:btnRockP2.PerformClick();break;
                case Keys.NumPad2:btnPaperP2.PerformClick();break;
                case Keys.NumPad3:btnScissorsP2.PerformClick();break;                 
            }   
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnEnter.Visible = false;
            btnRockP1.Visible = true;
            btnRockP2.Visible=true;
            btnPaperP1.Visible = true;
            btnPaperP2.Visible=true;
            btnScissorsP1.Visible = true;
            btnScissorsP2.Visible=true;
        }

        private void btnRockP1_Click(object sender, EventArgs e)
        {
            pictureBoxP1.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Rock.png");
            pictureBoxP1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1Choice = 0;
            comparison(player1Choice, player2Choice);
        }

        private void btnPaperP1_Click(object sender, EventArgs e)
        {
            pictureBoxP1.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Paper.png");
            pictureBoxP1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1Choice = 1;
            comparison(player1Choice, player2Choice);
        }

        private void btnScissorsP1_Click(object sender, EventArgs e)
        {
            pictureBoxP1.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Scissors.png");
            pictureBoxP1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1Choice = 2;
            comparison(player1Choice, player2Choice);
        }

        private void btnRockP2_Click(object sender, EventArgs e)
        {
            pictureBoxP2.Image=Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Rock.png");
            pictureBoxP2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Choice = 0;
            comparison(player1Choice, player2Choice);
        }

        private void btnPaperP2_Click(object sender, EventArgs e)
        {

            pictureBoxP2.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Paper.png");
            pictureBoxP2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Choice = 1;
            comparison(player1Choice, player2Choice);
        }

        private void btnScissorsP2_Click(object sender, EventArgs e)
        {

            pictureBoxP2.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Scissors.png");
            pictureBoxP2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Choice = 2;
            comparison(player1Choice, player2Choice);
        }
        private void btnPlayAgainTwoPlayer_Click(object sender, EventArgs e)
        {
            resetGame();
            btnEnter.Focus();
        }

        private void btnExitTwoPlayer_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Visible = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                m.Visible = true;
                return true; 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void game2_FormClosed(object sender, FormClosedEventArgs e)
        {
            m.Visible = true;
        }
    }
    
}
