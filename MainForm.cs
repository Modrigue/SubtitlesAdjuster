using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SA
{
    public partial class MainForm : Form
    {
        private String filename_;

        private delegate void changeProgressLabel(string str);

        public MainForm()
        {
            InitializeComponent();

            labelVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            filename_ = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            string patternTime = @"[\d][\d]:[0-5][\d]:[0-5][\d],[\d][\d][\d]";
            string patternTimeLine = @"^" + patternTime + " --> " + patternTime + "$";
            Regex rgxTimeLine = new Regex(patternTimeLine, RegexOptions.IgnoreCase);
            Regex rgxTime = new Regex(patternTime, RegexOptions.IgnoreCase);

            string text = "00:56:48,874 --> 01:24:48,874";

            MatchCollection m1 = rgxTimeLine.Matches(text);
            int mc1 = m1.Count;

            MatchCollection m2 = rgxTime.Matches(text);
            int mc2 = m2.Count;
            foreach (Match match in m2)
            {
                string val = match.Value;
            }
            */

            /*
            Tools.SubtitleType type;
            long milli1 = Tools.TimeToMilliseconds("01:36:28,345", out type);
            string time1 = Tools.MillisecondsToTime(milli1, type);
            long milli2 = Tools.TimeToMilliseconds("01:36:28.34", out type);
            string time2 = Tools.MillisecondsToTime(milli2, type);
            string timeA1 = Tools.AdjustTime("01:36:28,345", 2, 1000); // SubRip
            string timeA2 = Tools.AdjustTime("01:36:28.34", 2, 1000); // SubViewer
            string timeA2b = Tools.AdjustTime("01:36:28.34", 1, 1006); // SubViewer
            */
        }

        #region Interface callbacks

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Subtitles files|*.srt;*.sub";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename_ = openFileDialog1.FileName;
                textboxFilename.Text = filename_;

                // update GUI and reset values

                tooltipFilename.SetToolTip(textboxFilename, filename_);

                radiobuttonSpeedDelay.Checked = true;
                panelAdjust.Enabled = true;

                numericupdownSpeed.Value = 1;
                numericupdownSpeed.Enabled = true;
                numericupdownDelay.Value = 0;
                numericupdownDelay.Enabled = true;

                timepickerPosCur1.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
                timepickerPosCur2.Value = new System.DateTime(2017, 2, 2, 1, 0, 0, 0);
                timepickerPosExp1.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
                timepickerPosExp2.Value = new System.DateTime(2017, 2, 2, 1, 0, 0, 0);

                numericupdownMilliPosCur1.Value = 0;
                numericupdownMilliPosCur2.Value = 0;
                numericupdownMilliPosExp1.Value = 0;
                numericupdownMilliPosExp2.Value = 0;

                buttonSave.Enabled = false;
                labelStatus.Visible = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // get speed and delay
            double speed = 1.0;
            long delay = 0;

            if (radiobuttonSpeedDelay.Checked)
            {
                speed = (double)numericupdownSpeed.Value;
                delay = (long)numericupdownDelay.Value;
            }
            else if (radiobuttonPositions.Checked)
                computeSpeedDelayFromPositions(out speed, out delay);

            if (speed == 1.0 && delay == 0)
                return; // secure

            string line;
            string adjustedSubtitles = "";

            Encoding encoding = Tools.GetEncoding(filename_); // not functional
            //Encoding encoding = Encoding.UTF7;
            StreamReader sr = new StreamReader(filename_, encoding);

            // Subtitles formats

            // SubRip: hh:mm:ss,mmm --> hh:mm:ss,mmm
            string patternSubRipTime = @"[\d][\d]:[0-5][\d]:[0-5][\d],[\d][\d][\d]";
            string patternSubRipTimeLine = @"^" + patternSubRipTime + " --> " + patternSubRipTime + "$";
            Regex rgxSubRipTimeLine = new Regex(patternSubRipTimeLine, RegexOptions.IgnoreCase);
            Regex rgxSubRipTime = new Regex(patternSubRipTime, RegexOptions.IgnoreCase);

            // SubViewer: hh:mm:ss.mm,hh:mm:ss.mm
            string patternSubViewerTime = @"[\d][\d]:[0-5][\d]:[0-5][\d].[\d][\d]";
            string patternSubViewerTimeLine = @"^" + patternSubViewerTime + "," + patternSubViewerTime + "$";
            Regex rgxSubViewerTimeLine = new Regex(patternSubViewerTimeLine, RegexOptions.IgnoreCase);
            Regex rgxSubViewerTime = new Regex(patternSubViewerTime, RegexOptions.IgnoreCase);

            while (sr.Peek() >= 0)
            {
                line = sr.ReadLine();
                MatchCollection matchesSubRipTimeLine = rgxSubRipTimeLine.Matches(line);
                MatchCollection matchesSubViewerTimeLine = rgxSubViewerTimeLine.Matches(line);

                if (matchesSubRipTimeLine.Count > 0)  // SubRip format
                {
                    MatchCollection matchesTime = rgxSubRipTime.Matches(line);
                    if (matchesTime.Count == 2)
                    {
                        string subtitleStart = matchesTime[0].Value;
                        string subtitleStop = matchesTime[1].Value;

                        string subtitleStartAdjusted = Tools.AdjustTime(subtitleStart, speed, delay);
                        string subtitleStopAdjusted = Tools.AdjustTime(subtitleStop, speed, delay);

                        adjustedSubtitles += subtitleStartAdjusted + " --> " + subtitleStopAdjusted + "\r\n";
                    }
                }
                else if (matchesSubViewerTimeLine.Count > 0)  // SubViewer format
                {
                    MatchCollection matchesTime = rgxSubViewerTime.Matches(line);
                    if (matchesTime.Count == 2)
                    {
                        string subtitleStart = matchesTime[0].Value;
                        string subtitleStop = matchesTime[1].Value;

                        string subtitleStartAdjusted = Tools.AdjustTime(subtitleStart, speed, delay);
                        string subtitleStopAdjusted = Tools.AdjustTime(subtitleStop, speed, delay);

                        adjustedSubtitles += subtitleStartAdjusted + "," + subtitleStopAdjusted + "\r\n";
                    }
                }
                else   // subtitle
                    adjustedSubtitles += line + "\r\n";
            }
            sr.Close(); 

            // save adjusted subtitles into file

            string adjustedFilename = Path.GetFileNameWithoutExtension(filename_);
            string extension = Path.GetExtension(filename_);
            if (speed != 1.0)
                adjustedFilename += "_s" + speed.ToString();
            if (delay != 0.0)
                adjustedFilename += "_d" + delay.ToString();
            adjustedFilename += extension;
            string adjustedDir = Path.GetDirectoryName(filename_);
            string adjustedPath = Path.Combine(adjustedDir, adjustedFilename);

            File.WriteAllText(adjustedPath, adjustedSubtitles);

            labelStatus.Visible = true;
            labelStatus.Text = "Adjusted subtitles saved to file:\n" + adjustedPath;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radiobuttonSpeedDelay_CheckedChanged(object sender, EventArgs e)
        {
            bool selected = radiobuttonSpeedDelay.Checked;

            panelSpeedDelay.Enabled = selected;
            panelPositions.Enabled = !selected;
        }

        private void radiobuttonPositions_CheckedChanged(object sender, EventArgs e)
        {
            bool selected = radiobuttonPositions.Checked;

            panelSpeedDelay.Enabled = !selected;
            panelPositions.Enabled = selected;
        }

        // speed / delay
        private void numericupdownSpeedDelay_ValueChanged(object sender, EventArgs e)
        {
            double speed = (double)numericupdownSpeed.Value;
            long delay = (long)numericupdownDelay.Value;

            bool idle = (speed == 1.0 && delay == 0);
            buttonSave.Enabled = !idle;

            labelStatus.Visible = false;
        }

        // positions
        private void timepickerPosition_ValueChanged(object sender, EventArgs e)
        {
            // update speed and delay displayed values
            double speed = 1.0;
            long delay = 0;
            computeSpeedDelayFromPositions(out speed, out delay);

            bool idle = (speed == 1.0 && delay == 0);

            labelComputedSpeed.Text = "Speed: " + speed.ToString("0.00") + "x";
            labelComputedDelay.Text = "Delay: " + (delay / 1000.0).ToString("0.000") + " s";

            labelComputedSpeed.Visible = !idle;
            labelComputedDelay.Visible = !idle;

            buttonSave.Enabled = !idle;
            labelStatus.Visible = false;
        }

        private void numericupdownMilliseconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            timepickerPosition_ValueChanged(sender, e);
        }

        /// <summary>
        /// Checks for only up to 4 digits and no negatives
        /// in a Numeric Up/Down box
        /// </summary>
        private void numericupdownMilliseconds_KeyDown(object sender, KeyEventArgs e)
        {
            //NumericUpDown control = (NumericUpDown)sender;

            //if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            //{
            //    // TODO: check if text is selected

            //    if (control.Text.Length >= 3 || e.KeyValue == 109)
            //    {
            //        e.SuppressKeyPress = true;
            //        e.Handled = true;
            //    }
            //}
        }

        #endregion

        private void computeSpeedDelayFromPositions(out double speed, out long delay)
        {
            string posCur1 = timepickerPosCur1.Value.ToLongTimeString() + "," + numericupdownMilliPosCur1.Value.ToString("000");
            string posCur2 = timepickerPosCur2.Value.ToLongTimeString() + "," + numericupdownMilliPosCur2.Value.ToString("000");
            string posExp1 = timepickerPosExp1.Value.ToLongTimeString() + "," + numericupdownMilliPosExp1.Value.ToString("000");
            string posExp2 = timepickerPosExp2.Value.ToLongTimeString() + "," + numericupdownMilliPosExp2.Value.ToString("000");

            Tools.SubtitleType type = Tools.SubtitleType.None; // dummy
            long milliCur1 = Tools.TimeToMilliseconds(posCur1, out type);
            long milliCur2 = Tools.TimeToMilliseconds(posCur2, out type);
            long milliExp1 = Tools.TimeToMilliseconds(posExp1, out type);
            long milliExp2 = Tools.TimeToMilliseconds(posExp2, out type);

            if (milliCur1 == milliCur2 || milliExp1 == milliExp2) // idle
            {
                speed = 1.0;
                delay = 0;
                return;
            }

            // compute speed
            speed = (double)((double)(milliCur2 - milliCur1) / (double)(milliExp2 - milliExp1));

            // compute delay
            double invSpeed = 1.0 / speed;
            double delay1 = milliExp1 - invSpeed * milliCur1;
            double delay2 = milliExp2 - invSpeed * milliCur2;
            delay = (long)Math.Round(0.5 * (delay1 + delay2));
        }
    }
}
