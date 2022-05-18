using Shutter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Shutter
{
    public enum Commands
    {
        Shutdown,
        Restart,
        Sleep
    }

    public partial class MainForm : Form
    {
        Commands command;
        bool escPressed;

        bool mouseOverMinutes;
        bool mouseOverHours;

        Timer countdownTimer;

        int hoursLeft;
        int minutesLeft;
        int secondsLeft;

        public MainForm()
        {
            InitializeComponent();
            SetButtons();
            IncreaseMinutes(3);
            this.MouseWheel += CheckForScroll;
            startProcessBtn.Text = Manager.Instance.Command.ToString();
        }

        private void SetButtons()
        {
            if (Manager.Instance.Hours == 0)
            {
                hoursDown.BackgroundImage = Resources.arrowDownBlank;
            }

            if (Manager.Instance.Minutes == 0)
            {
                minsDown.BackgroundImage = Resources.arrowDownBlank;
            }
        }

        private void ShutBtn_Click(object sender, EventArgs e)
        {
            StartTimer();
            Manager.Instance.StartCountdown();

            if (!Manager.Instance.Fullscreen)
            {
                Hide();
            }

            ShowCancelCountdownButton();
            HideMainPanel();
            ShowCancelPanel();
            SetSoundImage();
        }

        private void SetSoundImage()
        {
            if (Manager.Instance.PlayMusic)
            {
                toggleSoundBtn.Visible = true;
            }
            else
            {
                toggleSoundBtn.Visible = false;
            }
        }

        private void ShowCancelPanel()
        {
            cancelPanel.Visible = true;
        }


        private void HideMainPanel()
        {
            mainPanel.Visible = false;
            userPreferencesPanel.Visible = false;
        }

        private void ShowCancelCountdownButton()
        {
            startProcessBtn.Visible = false;
            cancelCountdownBtn.Visible = true;
        }

        private void UpdateTime()
        {
            string hoursLeft = "";
            string minutesLeft = "";

            if (Manager.Instance.Hours > 9)
            {
                hoursLeft = Manager.Instance.Hours.ToString();
            }
            else
            {
                hoursLeft = "0" + Manager.Instance.Hours.ToString();
            }

            if (Manager.Instance.Minutes > 9)
            {
                minutesLeft = Manager.Instance.Minutes.ToString();
            }
            else
            {
                minutesLeft = "0" + Manager.Instance.Minutes.ToString();
            }

            timeLbl.Text = hoursLeft + ":" + minutesLeft;
        }

        private void IncreaseHours(int amount)
        {
            if (amount > 0 && Manager.Instance.Hours == 99)
            {
                return;
            }
            else if (amount < 0 && Manager.Instance.Hours == 0)
            {
                return;
            }

            Manager.Instance.IncreaseHours(amount);
            UpdateTime();
            SetHoursButtons();
        }

        private void SetHours(int amount)
        {
            Manager.Instance.SetHours(amount);
            UpdateTime();
            SetHoursButtons();
        }

        private void SetHoursButtons()
        {
            if (Manager.Instance.Hours == 99)
            {
                hoursUp.BackgroundImage = Resources.arrowUpBlank;
                hoursDown.BackgroundImage = Resources.arrowDown;
            }
            else if (Manager.Instance.Hours == 0)
            {
                hoursUp.BackgroundImage = Resources.arrowUp;
                hoursDown.BackgroundImage = Resources.arrowDownBlank;
            }
            else
            {
                hoursUp.BackgroundImage = Resources.arrowUp;
                hoursDown.BackgroundImage = Resources.arrowDown;
            }
        }

        private void IncreaseMinutes(int amount)
        {
            if (amount > 0 && Manager.Instance.Minutes == 59)
            {
                return;
            }
            else if (amount < 0 && Manager.Instance.Minutes == 0)
            {
                return;
            }

            Manager.Instance.IncreaseMinutes(amount);

            UpdateTime();

            SetMinutesButtons();
        }

        private void SetMinutes(int mins)
        {
            Manager.Instance.SetMinutes(mins);

            UpdateTime();

            SetMinutesButtons();
        }

        private void IncreaseSeconds(int amount)
        {
            Manager.Instance.IncreaseSeconds(amount);

            UpdateTime();

            SetMinutesButtons();
        }

        private void SetSeconds(int amount)
        {
            Manager.Instance.SetSeconds(amount);

            UpdateTime();

            SetMinutesButtons();
        }

        private void SetMinutesButtons()
        {
            if (Manager.Instance.Minutes == 59)
            {
                minsUp.BackgroundImage = Resources.arrowUpBlank;
                minsDown.BackgroundImage = Resources.arrowDown;
            }
            else if (Manager.Instance.Minutes == 0)
            {
                minsUp.BackgroundImage = Resources.arrowUp;
                minsDown.BackgroundImage = Resources.arrowDownBlank;
            }
            else
            {
                minsUp.BackgroundImage = Resources.arrowUp;
                minsDown.BackgroundImage = Resources.arrowDown;
            }

        }

        // Hours Hovers
        private void Hours5Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl5H.ForeColor = Color.Gray;
            lbl5HTxt.ForeColor = Color.Gray;
        }

        private void Hours5Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl5H.ForeColor = Color.White;
            lbl5HTxt.ForeColor = Color.White;
        }

        private void Hours10Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl10H.ForeColor = Color.Gray;
            lbl10HTxt.ForeColor = Color.Gray;
        }

        private void Hours10Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl10H.ForeColor = Color.White;
            lbl10HTxt.ForeColor = Color.White;
        }

        private void Hours20Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl20H.ForeColor = Color.Gray;
            lbl20HTxt.ForeColor = Color.Gray;
        }

        private void Hours20Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl20H.ForeColor = Color.White;
            lbl20HTxt.ForeColor = Color.White;

        }

        // Minutes Labels
        private void Min5Lbl_Click(object sender, EventArgs e)
        {
            SetMinutes(5);
        }

        private void Min10Lbl_Click(object sender, EventArgs e)
        {
            SetMinutes(10);
        }

        private void Min15Lbl_Click(object sender, EventArgs e)
        {
            SetMinutes(15);
        }

        private void Min30Lbl_Click(object sender, EventArgs e)
        {
            SetMinutes(30);
        }
        private void Min45Lbl_Click(object sender, EventArgs e)
        {
            SetMinutes(45);
        }

        // Minutes Hovers
        private void Min5Lbl_MouseEnter(object sender, EventArgs e)
        {
            min5Lbl.ForeColor = Color.Gray;
            lbl5M.ForeColor = Color.Gray;
        }

        private void Min5Lbl_MouseLeave(object sender, EventArgs e)
        {
            min5Lbl.ForeColor = Color.White;
            lbl5M.ForeColor = Color.White;
        }

        private void Min15Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl15M.ForeColor = Color.Gray;
            min15Lbl.ForeColor = Color.Gray;
        }

        private void Min15Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl15M.ForeColor = Color.White;

            min15Lbl.ForeColor = Color.White;
        }

        private void Min10Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl10M.ForeColor = Color.Gray;

            min10Lbl.ForeColor = Color.Gray;
        }

        private void Min10Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl10M.ForeColor = Color.White;

            min10Lbl.ForeColor = Color.White;
        }

        private void Min30Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl30M.ForeColor = Color.Gray;
            min30Lbl.ForeColor = Color.Gray;
        }

        private void Min30Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl30M.ForeColor = Color.White;
            min30Lbl.ForeColor = Color.White;

        }

        private void Min45Lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl45M.ForeColor = Color.Gray;
            min45Lbl.ForeColor = Color.Gray;
        }

        private void Min45Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl45M.ForeColor = Color.White;
            min45Lbl.ForeColor = Color.White;
        }


        // Hours Buttons

        private void HoursUp_MouseDown(object sender, MouseEventArgs e)
        {
            hoursUp.BackgroundImage = Resources.arrowUpClicked;
        }

        private void HoursUp_MouseUp(object sender, MouseEventArgs e)
        {
            hoursUp.BackgroundImage = Resources.arrowUpHover;
            IncreaseHours(1);
        }

        private void HoursUp_MouseEnter(object sender, EventArgs e)
        {
            mouseOverHours = true;

            hoursUp.BackgroundImage = Resources.arrowUpHover;
        }

        private void HoursUp_MouseLeave(object sender, EventArgs e)
        {
            hoursUp.BackgroundImage = Resources.arrowUp;

            mouseOverHours = false;

        }


        private void HoursDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (Manager.Instance.Hours > 0)
            {
                hoursDown.BackgroundImage = Resources.arrowDownClicked;
            }
            else
            {
                hoursDown.BackgroundImage = Resources.arrowDownBlankClicked;
            }
        }
        private void HoursDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (Manager.Instance.Hours == 0)
            {
                hoursDown.BackgroundImage = Resources.arrowDownBlank;
                return;
            }

            hoursDown.BackgroundImage = Resources.arrowDownHover;
            IncreaseHours(-1);

        }
        private void HoursDown_MouseEnter(object sender, EventArgs e)
        {
            mouseOverHours = true;

            if (Manager.Instance.Hours == 0)
            {
                return;
            }

            hoursDown.BackgroundImage = Resources.arrowDownHover;
        }

        private void HoursDown_MouseLeave(object sender, EventArgs e)
        {
            mouseOverHours = false;

            if (Manager.Instance.Hours == 0)
            {
                return;
            }

            hoursDown.BackgroundImage = Resources.arrowDown;
        }


        // Minutes Buttons
        private void MinsUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (Manager.Instance.Minutes == 59)
            {
                minsUp.BackgroundImage = Resources.arrowUpBlankClicked;
            }
            else
            {
                minsUp.BackgroundImage = Resources.arrowUpClicked;
            }
        }

        private void MinsUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (Manager.Instance.Minutes== 59)
            {
                minsUp.BackgroundImage = Resources.arrowUpBlank;
                return;
            }


            minsUp.BackgroundImage = Resources.arrowUpHover;
            IncreaseMinutes(1);
        }

        private void MinsUp_MouseEnter(object sender, EventArgs e)
        {
            mouseOverMinutes = true;

            if (Manager.Instance.Minutes == 59)
            {
                minsUp.BackgroundImage = Resources.arrowUpBlank;
            }
            else
            {
                minsUp.BackgroundImage = Resources.arrowUpHover;
            }
        }

        private void MinsUp_MouseLeave(object sender, EventArgs e)
        {
            if (Manager.Instance.Minutes == 59)
            {
                minsUp.BackgroundImage = Resources.arrowUpBlank;
            }
            else
            {
                minsUp.BackgroundImage = Resources.arrowUp;
            }

            mouseOverMinutes = false;
        }

        private void MinsDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (Manager.Instance.Minutes > 0)
            {
                minsDown.BackgroundImage = Resources.arrowDownClicked;
            }
            else
            {
                minsDown.BackgroundImage = Resources.arrowDownBlankClicked;
            }
        }

        private void MinsDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (Manager.Instance.Minutes == 0)
            {
                minsDown.BackgroundImage = Resources.arrowDownBlank;
                return;
            }

            minsDown.BackgroundImage = Resources.arrowDownHover;
            IncreaseMinutes(-1);
        }

        private void MinsDown_MouseEnter(object sender, EventArgs e)
        {
            mouseOverMinutes = true;

            if (Manager.Instance.Minutes == 0)
            {
                return;
            }

            minsDown.BackgroundImage = Resources.arrowDownHover;
        }

        private void MinsDown_MouseLeave(object sender, EventArgs e)
        {
            mouseOverMinutes = false;

            if (Manager.Instance.Minutes == 0)
            {
                return;
            }
            minsDown.BackgroundImage = Resources.arrowDown;
        }

        private void UpdateCommands(Commands command, Point lblLocation)
        {
            Manager.Instance.SetCommand(command);
            commandSetLbl.Location = lblLocation;
        }

        private void ShutDownLbl_Click(object sender, EventArgs e)
        {
            UpdateCommands(Commands.Shutdown, new Point(36, 258));
        }

        private void RestartLbl_Click(object sender, EventArgs e)
        {
            UpdateCommands(Commands.Restart, new Point(36, 285));
        }

        private void SleepLbl_Click(object sender, EventArgs e)
        {
            UpdateCommands(Commands.Sleep, new Point(36, 312));
        }

        private void ShutDownLbl_MouseEnter(object sender, EventArgs e)
        {
            shutDownLbl.ForeColor = Color.Gray;
        }

        private void ShutDownLbl_MouseLeave(object sender, EventArgs e)
        {
            shutDownLbl.ForeColor = Color.White;
        }

        private void RestartLbl_MouseEnter(object sender, EventArgs e)
        {
            restartLbl.ForeColor = Color.Gray;
        }

        private void RestartLbl_MouseLeave(object sender, EventArgs e)
        {
            restartLbl.ForeColor = Color.White;
        }

        private void SleepLbl_MouseEnter(object sender, EventArgs e)
        {
            sleepLbl.ForeColor = Color.Gray;
        }

        private void SleepLbl_MouseLeave(object sender, EventArgs e)
        {
            sleepLbl.ForeColor = Color.White;
        }

        private void StartProcessBtn_MouseEnter(object sender, EventArgs e)
        {
            startProcessBtn.ForeColor = Color.Black;
        }

        private void StartProcessBtn_MouseLeave(object sender, EventArgs e)
        {
            startProcessBtn.ForeColor = Color.White;
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }

        private void CancelCountdownBtn_Click(object sender, EventArgs e)
        {
            CancelCountdown();
            StopTimer();
            Manager.Instance.StopMusic();

            cancelCountdownBtn.Visible = false;
            startProcessBtn.Visible = true;

            mainPanel.Visible = true;
            userPreferencesPanel.Visible = true;
            cancelPanel.Visible = false;


        }

        private void CancelCountdown()
        {
            Manager.Instance.CancelCountdown();
        }

        private void CancelCountdownBtn_MouseEnter(object sender, EventArgs e)
        {
            cancelCountdownBtn.ForeColor = Color.Black;
        }

        private void CancelCountdownBtn_MouseLeave(object sender, EventArgs e)
        {
            cancelCountdownBtn.ForeColor = Color.White;

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                Manager.Instance.GoFullScreen();
            }
        }

        private void FullScreenLbl_Click(object sender, EventArgs e)
        {
            Manager.Instance.GoFullScreen();
        }

        private void MusicLbl_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleMusic();
        }

        private void ToggleMusic()
        {
            Manager.Instance.SetPlayMusic(!Manager.Instance.PlayMusic);

            if (Manager.Instance.PlayMusic)
            {
                musicCheckboxImage.BackgroundImage = Properties.Resources.checkedBox;
            }
            else
            {
                musicCheckboxImage.BackgroundImage = Properties.Resources.check_box_empty;
            }
        }

        private void MusicCheckbox_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleMusic();
        }

        private void FullscreenCheckboxImage_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleFullscreen();
        }

        private void ToggleFullscreen()
        {
            Manager.Instance.SetFullscreen(!Manager.Instance.Fullscreen);

            if (Manager.Instance.Fullscreen)
            {
                fullscreenCheckboxImage.BackgroundImage = Properties.Resources.checkedBox;
            }
            else
            {
                fullscreenCheckboxImage.BackgroundImage = Properties.Resources.check_box_empty;
            }
        }

        private void FullScrenCheckBoxLbl_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleFullscreen();
        }

        private void MusicCheckboxImage_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleMusic();
        }

        private void MusicLbl_MouseUp_1(object sender, MouseEventArgs e)
        {
            ToggleMusic();
        }

        private void StartTimer()
        {
            hoursLeft = Manager.Instance.Hours;
            minutesLeft = Manager.Instance.Minutes;
            secondsLeft = Manager.Instance.Seconds;

            countdownTimer = new Timer();
            countdownTimer.Tick += new EventHandler(countdownTimer_Tick);
            countdownTimer.Interval = 1000;
            countdownTimer.Start();
            Manager.Instance.SetCountdown(true);
            UpdateCountdownTimer();
        }

        private void UpdateCountdownTimer()
        {
            string hoursLeftTxt = "";
            if (hoursLeft > 9)
            {
                hoursLeftTxt = hoursLeft.ToString();
            }
            else
            {
                hoursLeftTxt = "0" + hoursLeft.ToString();
            }

            string minutesLeftTxt = "";
            if (minutesLeft > 9)
            {
                minutesLeftTxt = minutesLeft.ToString();
            }
            else
            {
                minutesLeftTxt = "0" + minutesLeft.ToString();
            }

            string secondsLeftTxt = "";
            if (secondsLeft > 9)
            {
                secondsLeftTxt = secondsLeft.ToString();
            }
            else
            {
                secondsLeftTxt = "0" + secondsLeft.ToString();
            }

            counterLbl.Text = hoursLeftTxt + ":" + minutesLeftTxt + ":" + secondsLeftTxt;
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (hoursLeft == 0 && minutesLeft == 0 && secondsLeft == 0)
            {
                Manager.Instance.FinishCountdown();
            }
            else if(secondsLeft == 0 && minutesLeft == 0)
            {
                hoursLeft--;
                minutesLeft = 59;
                secondsLeft = 59;

            }
            else if (secondsLeft == 0)
            {
                minutesLeft--;
                secondsLeft = 59;
            }
            else
            {
                secondsLeft--;
            }

            if (!Manager.Instance.CountdownFinished)
            {
                UpdateCountdownTimer();
            }
            else
            {
                StopTimer();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void StopTimer()
        {
            if (countdownTimer != null)
            {
                Manager.Instance.SetCountdown(false);
                countdownTimer.Stop();
                countdownTimer.Dispose();
            }
        }

        private void MuteSound()
        {
            Manager.Instance.MuteSound();
            toggleSoundBtn.BackgroundImage = Properties.Resources.speaker__1_;
        }

        private void UnMuteSound()
        {
            Manager.Instance.UnMuteSound();
            toggleSoundBtn.BackgroundImage = Properties.Resources.speaker;
        }

        private void ToggleSoundBtn_MouseUp(object sender, MouseEventArgs e)
        {
            ToggleSound();
        }

        private void ToggleSound()
        {
            if (Manager.Instance.SoundMuted)
            {
                UnMuteSound();
            }
            else
            {
                MuteSound();
            }
        }

        private void Lbl5HTxt_Click(object sender, EventArgs e)
        {
            SetHours(5);
        }

        private void Lbl5H_Click(object sender, EventArgs e)
        {
            SetHours(5);
        }

        private void Lbl10H_Click(object sender, EventArgs e)
        {
            SetHours(10);
        }

        private void Lbl10HTxt_Click(object sender, EventArgs e)
        {
            SetHours(10);
        }

        private void Lbl20H_Click(object sender, EventArgs e)
        {
            SetHours(20);
        }

        private void Lbl20HTxt_Click(object sender, EventArgs e)
        {
            SetHours(20);
        }

        private void Lbl5M_Click(object sender, EventArgs e)
        {
            SetMinutes(5);
        }

        private void Lbl10M_Click(object sender, EventArgs e)
        {
            SetMinutes(10);
        }

        private void Min10Lbl_Click_1(object sender, EventArgs e)
        {
            SetMinutes(10);
        }

        private void Min15Lbl_Click_1(object sender, EventArgs e)
        {
            SetMinutes(15);
        }

        private void Lbl15M_Click(object sender, EventArgs e)
        {
            SetMinutes(15);
        }

        private void Min30Lbl_Click_1(object sender, EventArgs e)
        {
            SetMinutes(30);
        }

        private void Lbl30M_Click(object sender, EventArgs e)
        {
            SetMinutes(30);
        }

        private void Lbl45M_Click(object sender, EventArgs e)
        {
            SetMinutes(45);
        }

        private void Min45Lbl_Click_1(object sender, EventArgs e)
        {
            SetMinutes(45);
        }

        private void FullScreenLbl_MouseEnter(object sender, EventArgs e)
        {
            fullScreenLbl.ForeColor = Color.Gray;
        }

        private void FullScreenLbl_MouseLeave(object sender, EventArgs e)
        {
            fullScreenLbl.ForeColor = Color.White;
        }

        private void CheckForScroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && mouseOverMinutes)
            {
                IncreaseMinutes(1);
            }
            else if (e.Delta > 0 && mouseOverHours)
            {
                IncreaseHours(1);
            }
            else if (e.Delta < 0 && mouseOverMinutes)
            {
                IncreaseMinutes(-1);
            }
            else if (e.Delta < 0 && mouseOverHours)
            {
                IncreaseHours(-1);
            }
        }

    }
}
