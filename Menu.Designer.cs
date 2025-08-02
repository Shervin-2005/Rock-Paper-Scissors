namespace Rock_Paper_Scissors
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // btnOnePlayer
            // 
            resources.ApplyResources(this.btnOnePlayer, "btnOnePlayer");
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.UseVisualStyleBackColor = true;
            this.btnOnePlayer.Click += new System.EventHandler(this.btnOnePlayer_Click);
            // 
            // btnTwoPlayers
            // 
            resources.ApplyResources(this.btnTwoPlayers, "btnTwoPlayers");
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.UseVisualStyleBackColor = true;
            this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOptions
            // 
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTwoPlayers);
            this.Controls.Add(this.btnOnePlayer);
            this.Controls.Add(this.lblWelcome);
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOptions;
    }
}

