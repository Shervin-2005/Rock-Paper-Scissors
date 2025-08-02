namespace Rock_Paper_Scissors
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.lblRedLine = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxCpu = new System.Windows.Forms.PictureBox();
            this.lblScoreNumPlayer = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblScoreCpu = new System.Windows.Forms.Label();
            this.lblScoreNumCpu = new System.Windows.Forms.Label();
            this.lblResultOneRound = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExitForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRedLine
            // 
            this.lblRedLine.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.lblRedLine, "lblRedLine");
            this.lblRedLine.Name = "lblRedLine";
            // 
            // btnRock
            // 
            resources.ApplyResources(this.btnRock, "btnRock");
            this.btnRock.Name = "btnRock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            resources.ApplyResources(this.btnPaper, "btnPaper");
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            resources.ApplyResources(this.btnScissors, "btnScissors");
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // pictureBoxPlayer
            // 
            resources.ApplyResources(this.pictureBoxPlayer, "pictureBoxPlayer");
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxCpu
            // 
            resources.ApplyResources(this.pictureBoxCpu, "pictureBoxCpu");
            this.pictureBoxCpu.Name = "pictureBoxCpu";
            this.pictureBoxCpu.TabStop = false;
            // 
            // lblScoreNumPlayer
            // 
            resources.ApplyResources(this.lblScoreNumPlayer, "lblScoreNumPlayer");
            this.lblScoreNumPlayer.Name = "lblScoreNumPlayer";
            // 
            // lblScorePlayer
            // 
            resources.ApplyResources(this.lblScorePlayer, "lblScorePlayer");
            this.lblScorePlayer.Name = "lblScorePlayer";
            // 
            // lblScoreCpu
            // 
            resources.ApplyResources(this.lblScoreCpu, "lblScoreCpu");
            this.lblScoreCpu.Name = "lblScoreCpu";
            // 
            // lblScoreNumCpu
            // 
            resources.ApplyResources(this.lblScoreNumCpu, "lblScoreNumCpu");
            this.lblScoreNumCpu.Name = "lblScoreNumCpu";
            // 
            // lblResultOneRound
            // 
            resources.ApplyResources(this.lblResultOneRound, "lblResultOneRound");
            this.lblResultOneRound.ForeColor = System.Drawing.Color.Lime;
            this.lblResultOneRound.Name = "lblResultOneRound";
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Name = "lblResult";
            // 
            // btnStartGame
            // 
            resources.ApplyResources(this.btnStartGame, "btnStartGame");
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnPlayAgain
            // 
            resources.ApplyResources(this.btnPlayAgain, "btnPlayAgain");
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExitForm3
            // 
            resources.ApplyResources(this.btnExitForm3, "btnExitForm3");
            this.btnExitForm3.Name = "btnExitForm3";
            this.btnExitForm3.UseVisualStyleBackColor = true;
            this.btnExitForm3.Click += new System.EventHandler(this.btnExitForm3_Click);
            // 
            // game
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExitForm3);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultOneRound);
            this.Controls.Add(this.lblScoreNumCpu);
            this.Controls.Add(this.lblScoreCpu);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblScoreNumPlayer);
            this.Controls.Add(this.pictureBoxCpu);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblRedLine);
            this.KeyPreview = true;
            this.Name = "game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.game_FormClosed);
            this.Load += new System.EventHandler(this.game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            this.Resize += new System.EventHandler(this.game_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRedLine;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxCpu;
        private System.Windows.Forms.Label lblScoreNumPlayer;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblScoreCpu;
        private System.Windows.Forms.Label lblScoreNumCpu;
        private System.Windows.Forms.Label lblResultOneRound;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExitForm3;
    }
}