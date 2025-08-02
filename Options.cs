
using Library_Managment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Rock_Paper_Scissors
{
    public partial class options : Form
    {
        LocallizationHelper lh=new LocallizationHelper();
        ScreenFixer screenFixer=new ScreenFixer();
        ResizeHelper resizeHelper = new ResizeHelper();
        Menu m;
        //This integer is used to determine the language of the labels in Game & Game2.
        public int num;
        public options(Menu m)
        {
            InitializeComponent();
            this.m = m;
        }
       
        private void options_Load(object sender, EventArgs e)
        {
            resizeHelper.SetTargetForm(this);
            resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());  
        }

        private void options_Resize(object sender, EventArgs e)
        {
            resizeHelper.ResizeControls();
        }

       

        private void options_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(comboBoxSelectLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    num = 0;
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa");
                    num = 1;
                    break;
            }
            lh.ReloadUI(this);
            lh.ReloadUI(m);
            lh.ReloadUI(m.g);
            lh.ReloadUI(m.g2);
            
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
        }
        private void radioBtnFarsi_CheckedChanged(object sender, EventArgs e)
        {



        }
        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {


        }

    }
}
