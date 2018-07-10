using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace clockInCockIn
{
    public partial class MainForm : Form
    {
        static List<int> intList = new List<int>();
        const int timeInterval = 60; // (seconds)
        const int timeCount = 30; // count of timeInterval


        #region Getting mouse location 
        /// <summary>
        ///     Used a tutorial found here http://www.blackwasp.co.uk/GetCursorPos.aspx
        /// </summary>
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        static int _x, _y;
        static int currentTime = 0;

        public struct POINT
        {
            public int X;
            public int Y;
        }

        static void ShowMousePosition()
        {
            POINT point;
            if (GetCursorPos(out point) && point.X != _x && point.Y != _y)
            {
                _x = point.X;
                _y = point.Y;
            }
        }
        #endregion

        private Timer timer;

        public MainForm()
        {

            InitializeComponent();
            /// <summary>
            ///     Starts the application in the bottom right hand corner of the screen
            /// </summary>
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

            StartTimers();
            LoadFormThemes();

        }

        public void LoadFormThemes()
        {
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.ForeColor = Color.Gray;

            minButton.FlatStyle = FlatStyle.Flat;
            minButton.FlatAppearance.BorderSize = 0;
            minButton.ForeColor = Color.Gray;

            titlePanel.BackColor = Color.FromArgb(45,45,45);
            timePanel.BackColor = Color.FromArgb(65,65,65);

            timeLabel.ForeColor = Color.FromArgb(155, 155, 155);
        }

        #region Close/Min ButtonClicks

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }
        #endregion

        #region Timer Init/Events
        public void StartTimers()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime++;
            ShowMousePosition();
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            if (currentTime % timeInterval == 0)
            {
                intList.Add(_x + _y);
                for(int i = 0; i < intList.Count - 1; i++)
                {
                    if (intList.Count <= 1)
                    {
                        /// We just need to do nothing for now. 
                    }
                    else if(intList[i] != intList[i+1])
                    {
                        int currentPos = intList[i + 1];

                        intList.Clear();
                        intList.Add(currentPos);
                    }
                }
                if (intList.Count == timeCount)
                {
                    timer.Stop();
                    ClockInAlert alert = new ClockInAlert();

                    if (alert.ShowDialog(null) == DialogResult.OK)
                    {
                        timer.Start();
                        intList.Clear();
                    }
                    else
                    {
                        timer.Start();
                    }
                }
            }
        }

        #endregion
    }
}
