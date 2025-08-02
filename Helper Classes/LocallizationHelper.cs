using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment
{
    internal class LocallizationHelper
    {
        public void ReloadUI(Form targetForm)
        {
            
            var wasVisible = targetForm.Visible;
            var wasMaximized = targetForm.WindowState ==FormWindowState.Maximized;
            var previousSize = targetForm.Size;
            var previousLocation = targetForm.Location;

            
            if (wasVisible)
                targetForm.Hide();

            
            var resources = new ComponentResourceManager(targetForm.GetType());
            resources.ApplyResources(targetForm, "$this");
            ApplyResourcesToControls(resources, targetForm.Controls);

            
            if (wasMaximized)
            {
                targetForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                targetForm.WindowState = FormWindowState.Normal;
                targetForm.Size = previousSize;
                targetForm.Location = previousLocation;
            }

            
            if (wasVisible)
                targetForm.Show();
        }




        public void ApplyResourcesToControls(ComponentResourceManager resources, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                resources.ApplyResources(control, control.Name);


                if (control.HasChildren)
                    ApplyResourcesToControls(resources, control.Controls);
            }
        }
    }
}
