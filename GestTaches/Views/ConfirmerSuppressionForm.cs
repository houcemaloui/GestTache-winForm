using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestTaches.Views
{
    public partial class ConfirmerSuppressionForm : Form
    {

        public bool EstConfirmer { get; private  set; } = false; 
        public ConfirmerSuppressionForm()
        {
            InitializeComponent();
        }

        private void buttonConfSuppr_Click(object sender, EventArgs e)
        {
            EstConfirmer = true;
            this.DialogResult = DialogResult.OK;    
            this.Close();

        }

        private void buttonAnnulerSupp_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
