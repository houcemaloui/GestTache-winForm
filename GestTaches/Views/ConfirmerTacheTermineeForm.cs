using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestTaches
{

    //
    public partial class ConfirmerTacheTermineeForm : Form
    {
        public bool EstConfirme { get; private set; } = false;

        public ConfirmerTacheTermineeForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            EstConfirme = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void labelTacheTerminee_Click(object sender, EventArgs e)
        {

        }
    }
}
