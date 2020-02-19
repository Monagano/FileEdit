using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipMaster
{
    public partial class editClipForm : Form
    {
        public editClipForm(string text)
        {
            InitializeComponent();
            bodyTextbox.Text = text;
            DialogResult = DialogResult.Cancel;
        }
        public string result;
        private void OKButton_Click(object sender, EventArgs e)
        {
            result = bodyTextbox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
