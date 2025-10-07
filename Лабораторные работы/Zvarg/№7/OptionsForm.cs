using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_lab___C_
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }
        public bool SizeReturn()
        {
            if (SmallSizeButton.Checked) return true;
            else return false;
        }
        public bool DirectionReturn()
        {
            if (LeftRightMovementButton.Checked) return true;
            else return false;
        }
        public int RingColorReturn()
        {
            return ColorRingComboBox.SelectedIndex;
        }
        public int MtnDoomReturn()
        {
            return ColorMtnDoomComboBox.SelectedIndex + 3;
        }
        public int DoomFireReturn()
        {
            return ColorDoomFireComboBox.SelectedIndex + 5;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
