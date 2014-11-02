namespace MaterialTestApp
{
    partial class Form1
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
            this.charm1 = new xMaterialControls.Charm();
            this.SuspendLayout();
            // 
            // charm1
            // 
            this.charm1.BackColor = System.Drawing.Color.Transparent;
            this.charm1.Icon = null;
            this.charm1.Location = new System.Drawing.Point(278, 128);
            this.charm1.Name = "charm1";
            this.charm1.Size = new System.Drawing.Size(48, 48);
            this.charm1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 408);
            this.Controls.Add(this.charm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private xMaterialControls.Charm charm1;

    }
}

