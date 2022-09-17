namespace EjercicioPOO
{
    partial class StartForm
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
            this.picWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // picWelcome
            // 
            this.picWelcome.BackColor = System.Drawing.Color.Transparent;
            this.picWelcome.BackgroundImage = global::EjercicioPOO.Properties.Resources.welcome;
            this.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWelcome.Location = new System.Drawing.Point(49, -1);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(450, 175);
            this.picWelcome.TabIndex = 0;
            this.picWelcome.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EjercicioPOO.Properties.Resources.startBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.picWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWelcome;
    }
}