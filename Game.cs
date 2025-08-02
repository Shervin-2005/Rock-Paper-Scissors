using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class game : Form
    {
        
        ResizeHelper resizeHelper=new ResizeHelper();
        ScreenFixer screenFixer = new ScreenFixer();
        Random r = new Random();
        bool gameStart = false;
        int playerChoice;
        int cpuChoice;
        int cpuScore;
        int playerScore;
        private Menu m;

        public game(Menu main)
        {
            m = main;
            InitializeComponent();
        }
        private void comparison(int playerChoice)
        {
            cpuChoice = r.Next(3);
            lblResultOneRound.Visible = true;
            switch(cpuChoice)
            {
                case 0:
                    {
                        pictureBoxCpu.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Rock.png");
                        pictureBoxCpu.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 1:
                    {
                        pictureBoxCpu.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Paper.png");
                        pictureBoxCpu.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 2:
                    {
                        pictureBoxCpu.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Scissors.png");
                        pictureBoxCpu.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
            }
            // Rock=0,Paper=1,Scissors=2 So The difference between two numbers shows the result. 
            if (playerChoice - cpuChoice == 0)
            {
                if (m.op.num == 0) lblResultOneRound.Text = " DRAW";
                else if(m.op.num == 1) lblResultOneRound.Text = "مساوی";
                    lblResultOneRound.ForeColor = Color.Black;
            }
            else if (playerChoice - cpuChoice == 1 || playerChoice - cpuChoice == -2)
            {
                if (m.op.num == 0) lblResultOneRound.Text = "GREAT!";
                else if (m.op.num == 1) lblResultOneRound.Text = "آفرین";
                lblResultOneRound.ForeColor = Color.Green;
                playerScore++;
                lblScoreNumPlayer.Text=playerScore.ToString();
            }
            else if(playerChoice-cpuChoice ==-1||playerChoice-cpuChoice ==2)
            {
                 if (m.op.num == 0) lblResultOneRound.Text = "    NO!";
                else if (m.op.num == 1) lblResultOneRound.Text = "!وای نه";
                lblResultOneRound.ForeColor = Color.Red;
                cpuScore++;
                lblScoreNumCpu.Text=cpuScore.ToString();
            }
            if(cpuScore==10||playerScore==10)
            {
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
                lblResultOneRound.Visible = false;
                lblResult.Visible = true;
                btnPlayAgain.Visible = true;
                btnExitForm3.Visible = true;
                if (playerScore > cpuScore)
                {
                    if (m.op.num == 0) lblResult.Text = "YOU WIN!";
                    else if(m.op.num == 1) lblResult.Text = "!برنده شدی";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    if (m.op.num == 0) lblResult.Text = "YOU LOSE!";
                    else if (m.op.num == 1) lblResult.Text = "  !!باختی";
                    lblResult.ForeColor = Color.Red;
                }
                
            }
        }
        private void Message()
        {
            if (m.op.num == 0) MessageBox.Show("FIRST CLICK ON THE START BUTTON");
            else if (m.op.num == 1) MessageBox.Show("برای شروع رو روی دکمه کلیک کنید");
        }
        public void resetGame()
        {
            gameStart = false;
            btnStartGame.Visible = true;
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
            cpuScore = 0;
            playerScore = 0;
            lblScoreNumCpu.Text = "0";
            lblScoreNumPlayer.Text = "0";
            btnPlayAgain.Visible = false;
            btnExitForm3.Visible = false;
            pictureBoxPlayer.Image = null;
            pictureBoxCpu.Image = null;
            lblResult.Visible = false;
        }
       
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            gameStart = true;
            btnStartGame.Visible = false;
        }
       

        private void btnRock_Click(object sender, EventArgs e)
        {
            if(gameStart)
            {
                pictureBoxPlayer.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Rock.png");
                pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                playerChoice = 0;
                comparison(playerChoice);
            }
            else Message();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {

            if (gameStart)
            {
                pictureBoxPlayer.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Paper.png");
                pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                playerChoice = 1;
                comparison(playerChoice);

            }
            else Message();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {

            if (gameStart)
            {
                pictureBoxPlayer.Image = Image.FromFile("H:\\C#\\Projects\\Shervin\\Rock Paper Scissors\\Image\\Scissors.png");
                pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                playerChoice = 2;
                comparison(playerChoice);
            }
            else Message();
        }
        private void game_Load(object sender, EventArgs e)
        {
           
            resizeHelper.SetTargetForm(this);
            resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());
            screenFixer.setOnScreen(this);
         }                                
        private void game_Resize(object sender, EventArgs e)
        {
                resizeHelper.ResizeControls();
            
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {  
            m.Visible = true;
        }
        private void btnExitForm3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
