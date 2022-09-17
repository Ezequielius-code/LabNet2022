namespace EjercicioPOO
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.picRestore = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.picSafeTrip = new System.Windows.Forms.PictureBox();
            this.buttonRunApp = new System.Windows.Forms.Button();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSafeTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBar
            // 
            this.panelToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToolBar.BackColor = System.Drawing.Color.Black;
            this.panelToolBar.Controls.Add(this.picRestore);
            this.panelToolBar.Controls.Add(this.picMinimize);
            this.panelToolBar.Controls.Add(this.picMaximize);
            this.panelToolBar.Controls.Add(this.picClose);
            this.panelToolBar.Controls.Add(this.picIcon);
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(800, 30);
            this.panelToolBar.TabIndex = 0;
            this.panelToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolBar_MouseDown);
            // 
            // picRestore
            // 
            this.picRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRestore.BackgroundImage = global::EjercicioPOO.Properties.Resources.restaurar;
            this.picRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRestore.Location = new System.Drawing.Point(734, 3);
            this.picRestore.Name = "picRestore";
            this.picRestore.Size = new System.Drawing.Size(24, 24);
            this.picRestore.TabIndex = 1;
            this.picRestore.TabStop = false;
            this.picRestore.Click += new System.EventHandler(this.picRestore_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.BackgroundImage = global::EjercicioPOO.Properties.Resources.minimizar;
            this.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Location = new System.Drawing.Point(704, 3);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.TabIndex = 1;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.BackgroundImage = global::EjercicioPOO.Properties.Resources.maximizar;
            this.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximize.Location = new System.Drawing.Point(734, 3);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(24, 24);
            this.picMaximize.TabIndex = 1;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackgroundImage = global::EjercicioPOO.Properties.Resources.cerrar;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(764, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackgroundImage = global::EjercicioPOO.Properties.Resources.iconImg;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcon.Location = new System.Drawing.Point(12, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(24, 24);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(0, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 418);
            this.panelContainer.TabIndex = 1;
            // 
            // picSafeTrip
            // 
            this.picSafeTrip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picSafeTrip.BackgroundImage = global::EjercicioPOO.Properties.Resources.safeTrip;
            this.picSafeTrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSafeTrip.Location = new System.Drawing.Point(700, 121);
            this.picSafeTrip.Name = "picSafeTrip";
            this.picSafeTrip.Size = new System.Drawing.Size(100, 225);
            this.picSafeTrip.TabIndex = 0;
            this.picSafeTrip.TabStop = false;
            // 
            // buttonRunApp
            // 
            this.buttonRunApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunApp.BackColor = System.Drawing.Color.Black;
            this.buttonRunApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRunApp.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonRunApp.FlatAppearance.BorderSize = 2;
            this.buttonRunApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonRunApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunApp.Font = new System.Drawing.Font("Colonna MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunApp.ForeColor = System.Drawing.Color.Gold;
            this.buttonRunApp.Location = new System.Drawing.Point(700, 186);
            this.buttonRunApp.Name = "buttonRunApp";
            this.buttonRunApp.Size = new System.Drawing.Size(100, 100);
            this.buttonRunApp.TabIndex = 2;
            this.buttonRunApp.TabStop = false;
            this.buttonRunApp.Text = "Start Trip!";
            this.buttonRunApp.UseVisualStyleBackColor = false;
            this.buttonRunApp.Click += new System.EventHandler(this.buttonRunApp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSafeTrip);
            this.Controls.Add(this.buttonRunApp);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cab & Bus";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSafeTrip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picRestore;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonRunApp;
        private System.Windows.Forms.PictureBox picSafeTrip;
    }
}

