using System;
using System.Windows.Forms;

namespace TFSF
{
    public partial class MainForm : Form
    {
        #region variable declartion
        private int seconds; // Seconds.
        private int minutes; // Minutes.
        private int hours;   // Hours.
        private bool paused; // State of the timer [PAUSED/WORKING].
        private bool keepSettings = true; // keep settings after timer finished for next run
        private static TimerForm timerForm = new TimerForm();
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region start/stop/pause button on click events
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!paused)
            {
                int.TryParse(txtHours.Text, out hours);
                int.TryParse(txtMinutes.Text, out minutes);
                int.TryParse(txtSeconds.Text, out seconds);

                if (hours < 1 && minutes < 1 && seconds < 1)
                {
                    MessageBox.Show("Mindestens eine Zahl eingeben!");
                    return;
                }
            }

            timerForm.Show();
            this.Focus();
            bTimer.Enabled = true;
            paused = false;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            UpdateStatusStrip("gestartet");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // Pause the timer.
            bTimer.Enabled = false;
            paused = true;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;
            UpdateStatusStrip("pausiert");
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop the timer.
            paused = false;
            BackToBase();
        }
        #endregion

        
        #region bTimer tick event
        private void bTimer_Tick(object sender, EventArgs e)
        {
            // Verify if the time didn't pass.
            if ((minutes == 0) && (hours == 0) && (seconds == 0))
            {
                BackToBase();
            }
            else
            {
                UpdateStatusStrip("läuft..");
                // Else continue counting.
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;

                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else
                    seconds -= 1;

                // Display the current values of hours, minutes and seconds in
                if(txtHours.Text.Length > 0)
                {
                    timerForm.SetTimerLabel(hours, minutes, seconds);
                    UpdateTimerStrip(hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString());
                    return;
                }
                else if (txtMinutes.Text.Length > 0)
                {
                    timerForm.SetTimerLabel(0, minutes, seconds);
                    UpdateTimerStrip(minutes.ToString() + ":" + seconds.ToString());
                    return;
                }
                else if (txtSeconds.Text.Length > 0)
                {
                    timerForm.SetTimerLabel(0, 0, seconds);
                    UpdateTimerStrip(seconds.ToString());
                    return;
                }
            }
        }
        #endregion


        private void chkKeepSettings_CheckedChanged(object sender, EventArgs e)
        {
            keepSettings = chkKeepSettings.Checked;
        }

        /// <summary>
        /// Update the bottom toolstrip status label
        /// </summary>
        /// <param name="statusString"></param>
        private void UpdateStatusStrip(string statusString)
        {
            sStrip.Items[1].Text = statusString;
        }
        /// <summary>
        /// Update the bottom toolstrip time label
        /// </summary>
        /// <param name="statusString"></param>
        private void UpdateTimerStrip(string timerString)
        {
            sStrip.Items[3].Text = timerString;
        }
        /// <summary>
        /// Reset everything. Clear fields depending on user preference
        /// </summary>
        private void BackToBase()
        {
            // If the time is over, clear all settings and fields.
            // Also, show the message, notifying that the time is over.
            bTimer.Enabled = false;

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            if (!keepSettings)
            {
                txtHours.Clear();
                txtMinutes.Clear();
                txtSeconds.Clear();
            }
            txtHours.Enabled = true;
            txtMinutes.Enabled = true;
            txtSeconds.Enabled = true;

            timerForm.SetTimerLabel(0, 0, 0);
            UpdateTimerStrip("00:00:00");
            UpdateStatusStrip("fertig");
        }
    }
}
