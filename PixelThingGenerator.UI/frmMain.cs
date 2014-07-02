using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelThingGenerator
{
    public partial class frmMain : Form
    {
        private Bitmap _lastResult;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateSpaceship_click(object sender, EventArgs e)
        {
            try
            {
                var generator = new SpaceshipGenerator();
                _lastResult = generator.Generate();
                picResult.BackgroundImage = _lastResult;
            }
            catch (Exception ex)            
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateRandomSeed();
        }

        private void chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRandomSeed();
        }

        private void UpdateRandomSeed()
        {
            numSeed.ReadOnly = chkRandom.Checked;
        }
    }
}
