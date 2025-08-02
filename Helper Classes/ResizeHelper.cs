using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{

 public class ResizeHelper
    {
        private Dictionary<Control, (Rectangle Bounds, float FontSize)> controlOriginalSizes = new Dictionary<Control, (Rectangle, float)>();
        private Rectangle originalFormSize;
        private Form targetForm;

        public void SetTargetForm(Form form)
        {
            //in form-load write this: SetTargetForm(this);
            targetForm = form;
            originalFormSize = new Rectangle(form.Location.X, form.Location.Y, form.Width, form.Height);
        }

        public void RegisterControls(params Control[] controls)
        {
            //in form-load write this: resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());
            controlOriginalSizes.Clear();
            foreach (var ctrl in controls)
            {
                var  bounds = new Rectangle(ctrl.Location.X, ctrl.Location.Y, ctrl.Width, ctrl.Height);
                float fontSize = ctrl.Font.Size;
                controlOriginalSizes[ctrl] = (bounds, fontSize);
            }
        }

        public void ResizeControls()
        {
            // in Resize Event write this: resizeHelper.ResizeControls(); 
            float xRatio = (float)targetForm.Width / originalFormSize.Width;
            float yRatio = (float)targetForm.Height / originalFormSize.Height;

            foreach (var kvp in controlOriginalSizes)
            {
                Control ctrl = kvp.Key;
                Rectangle r = kvp.Value.Bounds;
                float originalFontSize = kvp.Value.FontSize;

                int newX = (int)(r.X * xRatio);
                int newY = (int)(r.Y * yRatio);
                int newWidth = (int)(r.Width * xRatio);
                int newHeight = (int)(r.Height * yRatio);

                ctrl.Location = new Point(newX, newY);
                ctrl.Size = new Size(newWidth, newHeight);

               
                float newFontSize = originalFontSize * ((xRatio + yRatio) / 2f);
                ctrl.Font = new Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style);
            }
        }
    }

}

