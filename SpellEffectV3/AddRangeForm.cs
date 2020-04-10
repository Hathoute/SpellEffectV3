using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellEffectV3 {
    public partial class AddRangeForm : Form {

        public int from, to;
        public AddRangeForm() {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if(!Int32.TryParse(txtbFrom.Text, out from) || !Int32.TryParse(txtbTo.Text, out to)) {
                MessageBox.Show("Both values must be int.");
                return;
            }
            else if(from > to) {
                MessageBox.Show("From must be less or equal to To.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
