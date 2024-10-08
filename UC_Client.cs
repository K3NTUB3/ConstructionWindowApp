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
    public partial class UC_Client : UserControl
    {
        ClientControllerClass clientController = new ClientControllerClass();
        public UC_Client()
        {
            InitializeComponent();
            LoadClientData();
            UC_AddClient.Visible = false;
        }
        private void LoadClientData()
        {
            DataTable clientData = clientController.GetClientData();
            ClientDataTable.DataSource = clientData;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UC_AddClient.Visible = true;
        }
    }
}
