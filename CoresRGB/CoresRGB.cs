using System.Drawing;
using System.Windows.Forms;

namespace CoresRGB
{
    public partial class CoresRGB : Form
    {
        public CoresRGB()
        {
            InitializeComponent();
        }

        public void MesclarCores()
        {
            lblPainel.BackColor = Color.FromArgb(
                hScrollBarRed.Value,
                hScrollBarGreen.Value,
                hScrollBarBlue.Value
                );
         }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblNumberRed.Text = hScrollBarRed.Value.ToString();
            MesclarCores();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblNumberGreen.Text = hScrollBarGreen.Value.ToString();
            MesclarCores();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblNumberBlue.Text = hScrollBarBlue.Value.ToString();
            MesclarCores();
        }
    }
}
