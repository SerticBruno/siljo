using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Shutter
{
    public enum MonitorState
    {
        MonitorStateOn = -1,
        MonitorStateOff = 2,
        MonitorStateStandBy = 1
    }

    public class Manager
    {
        public static Manager Instance;
        public static MediaPlayer player;

        public Manager()
        {
            if (Instance == null)
            {
                Instance = this;
            }

        }

        private Commands command;
        public Commands Command { get { return command; } private set { command = value; } }

        private bool countdownStarted;
        public bool CountdownStarted { get { return countdownStarted; } private set { countdownStarted = value; } }

        private bool countdownFinished;
        public bool CountdownFinished { get { return countdownFinished; } private set { countdownFinished = value; } }

        private bool playMusic;
        public bool PlayMusic { get { return playMusic; } private set { playMusic = value; } }

        private bool soundMuted;
        public bool SoundMuted { get { return soundMuted; } private set { soundMuted = value; } }

        private bool fullscreen;
        public bool Fullscreen { get { return fullscreen; } private set { fullscreen = value; } }

        private int hours;
        public int Hours { get { return hours; } private set { hours = value; } }

        private int minutes;
        public int Minutes { get { return minutes; } private set { minutes = value; } }

        private int seconds;
        public int Seconds { get { return seconds; } private set { seconds = value; } }

        public void SetCommand(Commands commandToSet)
        {
            command = commandToSet;
        }

        public void StartCountdown()
        {
            int totalTime = hours * 60 * 60;
            totalTime += minutes * 60;

            string commandText = "";
            string commandTime = "";

            switch (command)
            {
                case Commands.Shutdown:
                    commandTime = "/s /t " + totalTime.ToString();
                    commandText = "shutdown";
                    break;
                case Commands.Restart:
                    commandTime = "/r /t " + totalTime.ToString();
                    commandText = "restart";
                    break;
                case Commands.Sleep:
                    commandTime = "/h /t " + totalTime.ToString();
                    commandText = "hibernate";
                    break;
                default:
                    break;
            }

            Process.Start("shutdown", commandTime);
            countdownStarted = true;

            if (playMusic)
            {
                StartMusic();
            }

            if (fullscreen)
            {
                GoFullScreen();
            }

        }

        private void StartMusic()
        {
            player = new MediaPlayer();
            // make option to put custom file
            var uri = new Uri(@"D:\USB\ShutterSprites/Rain.wav");
            player.Open(uri);
            player.Play();  
        }

        public void StopMusic()
        {
            if (player != null)
            {
                player.Stop();
                player.Close();
            }
        }

        public void CancelCountdown()
        {
            countdownStarted = false;
            Process.Start("shutdown", "-a");
        }

        public void SetHours(int amount)
        {
            hours = amount;
        }

        public void IncreaseHours(int amount)
        {
            hours += amount;
        }

        public void SetMinutes(int amount)
        {
            minutes = amount;
        }

        public void IncreaseMinutes(int amount)
        {
            minutes += amount;
        }
        public void SetSeconds(int amount)
        {
            seconds = amount;
        }

        public void IncreaseSeconds(int amount)
        {
            seconds += amount;
        }

        public void GoFullScreen()
        {
            BlackScreenForm blackScreenForm = new BlackScreenForm();
            blackScreenForm.WindowState = FormWindowState.Maximized;
            blackScreenForm.FormBorderStyle = FormBorderStyle.None;
            Cursor.Hide();
            blackScreenForm.ShowDialog();
            blackScreenForm.Activate();
        }

        public void SetPlayMusic(bool value)
        {
            playMusic = value;
        }

        public void SetFullscreen(bool value)
        {
            fullscreen = value;
        }

        public void SetCountdown(bool value)
        {
            if (value)
            {
                countdownFinished = false;
                countdownStarted = true;
            }
            else
            {
                countdownFinished = true;
                countdownStarted = false;
            }
        }

        public void FinishCountdown()
        {
            countdownFinished = true;
        }

        public void MuteSound()
        {
            if (player != null)
            {
                player.Volume = 0;
                soundMuted = true;
            }
        }
        public void UnMuteSound()
        {
            if (player != null)
            {
                player.Volume = 100;
                soundMuted = false;
            }
        }
    }
}
