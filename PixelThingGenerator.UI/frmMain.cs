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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateSpaceship_click(object sender, EventArgs e)
        {
            try
            {
                var generator = new SpaceshipGenerator();
                picResult.BackgroundImage = generator.Generate();
            }
            catch (Exception ex)            
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
