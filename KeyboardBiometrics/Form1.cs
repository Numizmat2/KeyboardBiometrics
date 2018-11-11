using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardBiometrics
{
    public partial class KeyboardBiometrics : Form
    {
        public KeyboardBiometrics()
        {
            InitializeComponent();
        }

        private void savePatternButton_Click(object sender, EventArgs e)
        {
            savePatternPanel.Visible = true;
            validatePanel.Visible = false;
        }

        private void validatePatternButton_Click(object sender, EventArgs e)
        {
            savePatternPanel.Visible = false;
            validatePanel.Visible = true;
        }
    }
}
