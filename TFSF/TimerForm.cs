using System.Drawing;
using System.Windows.Forms;

namespace TFSF
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the timer label
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public bool SetTimerLabel(int hours = 0, int minutes = 0, int seconds = 0)
        {
            // Ghetto approach on resizing the timer font depending on the screen size
            lblTimer.Font = new Font(lblTimer.Font.FontFamily, this.Height/4, FontStyle.Regular);

            if (hours > 0)
            {
                lblTimer.Text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
                return true;
            }
            else if (minutes > 0)
            {
                lblTimer.Text = minutes.ToString() + ":" + seconds.ToString();
                return true;
            }
            else
            {
                lblTimer.Text = seconds.ToString();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Don't dispose the form object, just hide it away for further usage later on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
