using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionWindowApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            barPanel.Height = btnDashboard.Height;
            barPanel.Top = btnDashboard.Top;
            UC_Dashboard.Visible = true;
            UC_ClientView.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnDashboard.Height;
            barPanel.Top = btnDashboard.Top;
            UC_Dashboard.Visible = true;
            UC_ClientView.Visible = false;
            
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnSchedule.Height;
            barPanel.Top = btnSchedule.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = false;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnInventory.Height;
            barPanel.Top = btnInventory.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnBooking.Height;
            barPanel.Top = btnBooking.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = false;
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnBilling.Height;
            barPanel.Top = btnBilling.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = false;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnServices.Height;
            barPanel.Top = btnServices.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnReport.Height;
            barPanel.Top = btnReport.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            barPanel.Height = btnClient.Height;
            barPanel.Top = btnClient.Top;
            UC_Dashboard.Visible = false;
            UC_ClientView.Visible = true;
        }
    }
}
