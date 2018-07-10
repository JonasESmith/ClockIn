using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockInCockIn
{
    public partial class ClockInAlert : Form
    {
        public ClockInAlert()
        {
            InitializeComponent();
            LoadStyles();
        }

        public void LoadStyles()
        {
            this.WindowState = FormWindowState.Maximized;

            ButtonPanel.BackColor = Color.FromArgb(65,65,65);
            panelAlertLabel.BackColor = Color.FromArgb(65, 65, 65);
            clockINButton.FlatStyle = FlatStyle.Flat;
            clockINButton.FlatAppearance.BorderSize = 0;
            clockINButton.ForeColor = Color.White;
            clockINButton.BackColor = Color.FromArgb(0, 137, 68);
            panelAlertLabel.ForeColor = Color.DarkGray;
        }

        private void clockINButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
