using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutter
{
    public partial class BlackScreenForm : Form
    {
        int tooltipTimeLeft;
        Timer tooltipTimer;

        int tooltipTime = 2;

        public BlackScreenForm()
        {
            InitializeComponent();
            ShowTooltip();
        }

        private void ShowTooltip()
        {
            tooltipTimer = new Timer();
            tooltipLbl.Visible = true;
            tooltipTimeLeft = tooltipTime;
            tooltipTimer.Tick += tooltipTimer_Tick;
            tooltipTimer.Interval = 1000;
            tooltipTimer.Start();
        }

        private void tooltipTimer_Tick(object sender, EventArgs e)
        {
            if (tooltipTimeLeft > 0)
            {
                tooltipTimeLeft--;
            }
            else
            {
                tooltipTimer.Stop();
                tooltipLbl.Visible = false;
            }
        }

        private void BlackScreenForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Show();
                Close();
            }
        }
    }
}
