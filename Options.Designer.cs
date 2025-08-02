namespace Rock_Paper_Scissors
{
    partial class options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options));
            this.comboBoxSelectLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSelectLanguage
            // 
            this.comboBoxSelectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectLanguage.FormattingEnabled = true;
            this.comboBoxSelectLanguage.Items.AddRange(new object[] {
            resources.GetString("comboBoxSelectLanguage.Items"),
            resources.GetString("comboBoxSelectLanguage.Items1")});
            resources.ApplyResources(this.comboBoxSelectLanguage, "comboBoxSelectLanguage");
            this.comboBoxSelectLanguage.Name = "comboBoxSelectLanguage";
            this.comboBoxSelectLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // options
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.comboBoxSelectLanguage);
            this.KeyPreview = true;
            this.Name = "options";
            this.Load += new System.EventHandler(this.options_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.options_KeyDown);
            this.Resize += new System.EventHandler(this.options_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLanguage;
        public System.Windows.Forms.ComboBox comboBoxSelectLanguage;
    }
}