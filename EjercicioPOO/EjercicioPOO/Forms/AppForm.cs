using System.Collections.Generic;
using System.Windows.Forms;

namespace EjercicioPOO
{
    public partial class AppForm : Form
    {
        Dictionary<int, Button> buttons = new Dictionary<int, Button>();
        public AppForm()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            buttons.Add(1, iconButtonBus1);
            buttons.Add(2, iconButtonBus2);
            buttons.Add(3, iconButtonBus3);
            buttons.Add(4, iconButtonBus4);
            buttons.Add(5, iconButtonBus5);
            buttons.Add(11, iconButtonCab1);
            buttons.Add(12, iconButtonCab2);
            buttons.Add(13, iconButtonCab3);
            buttons.Add(14, iconButtonCab4);
            buttons.Add(15, iconButtonCab5);
        }
    }
}
