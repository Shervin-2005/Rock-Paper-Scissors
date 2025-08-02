
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rock_Paper_Scissors
{
    public partial class Menu : Form
    {   
        ScreenFixer screenFixer=new ScreenFixer();
        ResizeHelper resizeHelper=new ResizeHelper();
        public options op;
        public game g;
        public game2 g2;
       
        public Menu()
        {
            InitializeComponent();
           
            op =new options(this);
            g=new game(this);
            g2 = new game2(this);
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
           op.ShowDialog();
        }

       
        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            g=new game(this);
            g.Show();
            this.Visible = false;  
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            g2=new game2(this);
            g2.Show();
            this.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
            resizeHelper.SetTargetForm(this);
            resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());
            screenFixer.setOnScreen(this);

        }
        private void Menu_Resize(object sender, EventArgs e)
        {
            resizeHelper.ResizeControls();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
