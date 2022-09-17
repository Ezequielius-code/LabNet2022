using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EjercicioPOO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            picRestore.Visible = false;
            picSafeTrip.Visible = false;
            OpenChildForms(new StartForm());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the app?", "CLOSE APP", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaximize.Visible = false;
            picRestore.Visible = true;
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestore.Visible = false;
            picMaximize.Visible = true;
        }

        public void OpenChildForms(object childForm)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form newestForm = childForm as Form;
            newestForm.TopLevel = false;
            newestForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(newestForm);
            this.panelContainer.Tag = childForm;
            newestForm.Show();
        }

        private void buttonRunApp_Click(object sender, EventArgs e)
        {
            buttonRunApp.Visible = false;
            picSafeTrip.Visible = true;
            this.OpenChildForms(new AppForm());
        }
    }
}
