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
    public partial class UC_AddClient : UserControl
    {
        public UC_AddClient()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clientName.Clear();
            clientAddress.Clear();
            clientContact.Clear();
            clientEmail.Clear();
        }
    }
}
