using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    internal class ScreenFixer
    {
        /*Get the 4 integers that represent the location and size of a rectangle,
        and set them equal to working area (excluding taskbars, etc.) of the 
        primary display‍*/
        public void setOnScreen(Form form)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            //Set the size of the Form equal to 50% of the width and 50% of the height.
            form.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width),
              Convert.ToInt32(0.5 * workingRectangle.Height));
            //Set the location of the form to be 10,10 from upper left corner of display
            form.Location = new System.Drawing.Point(10, 10);
            //Set the  MinimizeSize 50% of WorkingArea
            form.MinimumSize = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width), Convert.ToInt32(0.5 * workingRectangle.Height));
        }
        
    }
}
