using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace MediaPlayer
{
    public partial class mediaWin : Form
    {
        public const int MM_MCINOTIFY = 0x3B9; // MCI播放完向系统发送的指令
        private int menuChoice;
        private string nowMusic;
        private MusicPlay musicPlay;
        private bool isPlaying;
        private bool isStopping;
        private listForm list;
        private Thread timer;

        public mediaWin()
        {
            InitializeComponent();
            menuChoice = 0;
            this.Icon = Properties.Resources.ico_music;
            list = new listForm();
            musicPlay = new MusicPlay();
            this.loadConfig();
            isPlaying = false;
            isStopping = true;
            nowMusic = list.getCurrentMusic();
            if(nowMusic != "")
            {
                this.musicName.Text = getName(nowMusic);
            }
            else
            {
                this.musicName.Text = "暂无播放";
            }
            updatePlayMode();
            this.Size = new Size(400, 200);
            int desktopW = Screen.PrimaryScreen.Bounds.Width;
            int desktopH = Screen.PrimaryScreen.Bounds.Height;
            int globalX = desktopW / 2;
            int globalY = desktopH / 4;
            this.Location = new Point(globalX - 200, globalY - 100);
            this.StartPosition = FormStartPosition.Manual;

            timer = new Thread(new ThreadStart(threadStart));
        }

        private void updatePlayMode()
        {
            switch (list.playChoice)
            {
                case 0:
                    this.picMode.Image = Properties.Resources.icon_sequence;
                    break;
                case 1:
                    this.picMode.Image = Properties.Resources.icon_single;
                    break;
                case 2:
                    this.picMode.Image = Properties.Resources.icon_random;
                    break;
            }
        }

        private string getName(string path)
        {
            if(path == "")
            {
                return "暂无播放";
            }
            string temp = path.Replace("\\"+"\\", "\\");
            string[] ret = temp.Split('\\');
            return ret[ret.Length-1];
        }

        private void musicMenu_Click(object sender, EventArgs e)
        {
            if(menuChoice != 0)
            {
                menuChoice = 0;
                this.Size = new Size(400, 200);
            }
        }

        private void ctrlBar_ValueChanged(object sender, EventArgs e)
        {
            int msPos = this.ctrlBar.Value * 1000;
            musicPlay.seekToPosition(msPos);
            this.progressBar.Value = ctrlBar.Value;
            this.labelBegin.Text = intTimeToString(this.ctrlBar.Value);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height);
            list.StartPosition = FormStartPosition.Manual;
            if (list.ShowDialog() != DialogResult.Cancel)
            {
                nowMusic = list.getCurrentMusic();
                if (nowMusic != "")
                {
                    this.musicName.Text = getName(nowMusic);
                    int duration = list.getCurrentTime();
                    this.labelEnd.Text = this.intTimeToString(duration);
                    this.progressBar.Maximum = duration;
                    this.ctrlBar.Maximum = duration;
                    this.progressBar.Value = 0;
                    this.ctrlBar.Value = 0;
                    this.labelBegin.Text = this.intTimeToString(0);
                }
                else
                {
                    this.musicName.Text = "暂无播放";
                    return;
                }
                musicPlay.PlayMusic(nowMusic);
                musicPlay.setVolume(this.volBar.Value);
                if(timer.IsAlive == false)
                {
                    timer.Start();
                }
                //Console.WriteLine(nowMusic);
                this.picPlay.Image = Properties.Resources.icon_pause;
                this.isPlaying = true;
                this.isStopping = false;
            }
            else
            {
                //nowMusic = list.getCurrentMusic();
                //if (nowMusic != "")
                //{
                //    this.musicName.Text = getName(nowMusic);
                //}
                //else
                //{
                //    this.musicName.Text = "暂无播放";
                //}
            }
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            if(this.isPlaying == false && this.nowMusic != "")
            {
                if(this.isStopping == true)
                {
                    this.isStopping = false;
                    musicPlay.PlayMusic(nowMusic);
                    musicPlay.setVolume(volBar.Value);
                    musicPlay.seekToPosition(progressBar.Value * 1000);
                }
                else
                {
                    musicPlay.resumeMusic();
                }
                if(timer.IsAlive == false)
                {
                    timer.Start();
                }
                //Console.WriteLine(timer.ThreadState);
                if (timer.ThreadState == ThreadState.Suspended)
                {
                    timer.Resume();
                }
                this.isPlaying = true;
                this.picPlay.Image = Properties.Resources.icon_pause;
            }
            else
            {
                this.isPlaying = false;
                this.picPlay.Image = Properties.Resources.icon_play;
                musicPlay.pauseMusic();
                if(timer.ThreadState == ThreadState.WaitSleepJoin)
                {
                    timer.Suspend();
                }
            }
        }

        private void picMode_Click(object sender, EventArgs e)
        {
            list.playChoice = ++list.playChoice%3;
            updatePlayMode();
        }

        private void picLast_Click(object sender, EventArgs e)
        {
            this.isStopping = true;
            this.isPlaying = false;
            this.musicPlay.pauseMusic();
            this.picPlay.Image = Properties.Resources.icon_play;
            if(timer.ThreadState == ThreadState.WaitSleepJoin)
            {
                timer.Suspend();
            }
            nowMusic = list.getLastMusic();
            if (nowMusic != "")
            {
                this.musicName.Text = getName(nowMusic);
                this.progressBar.Maximum = list.getCurrentTime();
                this.ctrlBar.Maximum = list.getCurrentTime();
                this.progressBar.Value = 0;
                this.ctrlBar.Value = 0;
                this.labelEnd.Text = this.intTimeToString(this.ctrlBar.Maximum);
                this.labelBegin.Text = this.intTimeToString(0);
            }
            else
            {
                this.musicName.Text = "暂无播放";
                this.labelBegin.Text = intTimeToString(0);
                this.labelEnd.Text = intTimeToString(0);
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            this.isStopping = true;
            this.isPlaying = false;
            this.musicPlay.pauseMusic();
            this.picPlay.Image = Properties.Resources.icon_play;
            //Console.WriteLine(timer.ThreadState);
            if (timer.ThreadState == ThreadState.WaitSleepJoin)
            {
                timer.Suspend();
            }
            nowMusic = list.getNextMusic();
            if (nowMusic != "")
            {
                this.musicName.Text = getName(nowMusic);
                this.progressBar.Maximum = list.getCurrentTime();
                this.ctrlBar.Maximum = list.getCurrentTime();
                this.progressBar.Value = 0;
                this.ctrlBar.Value = 0;
                this.labelEnd.Text = this.intTimeToString(this.ctrlBar.Maximum);
                this.labelBegin.Text = this.intTimeToString(0);
            }
            else
            {
                this.musicName.Text = "暂无播放";
                this.labelBegin.Text = intTimeToString(0);
                this.labelEnd.Text = intTimeToString(0);
            }
        }

        private void mvMenu_Click(object sender, EventArgs e)
        {
            if(this.menuChoice != 1)
            {
                this.menuChoice = 1;
                this.Size = new Size(800, 600);
            }
        }

        private void mediaWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 此处保存 退出时配置
            if(timer.IsAlive == true && timer.ThreadState == ThreadState.WaitSleepJoin)
            {
                timer.Abort();
                timer.Join();
            }
            FileStream fs = new FileStream("./config.ini", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine("nowMusic=" + nowMusic);
            sw.WriteLine("list.index="+list.index.ToString());
            sw.WriteLine("list.playChoice="+list.playChoice.ToString());
            sw.WriteLine("progressBar.Value=" + progressBar.Value.ToString());
            sw.WriteLine("volBar.Value=" + volBar.Value.ToString());
            sw.Close();
            fs.Close();
        }

        private void loadConfig()
        {
            FileStream fs;
            try
            {
                fs = new FileStream("./config.ini", FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string line;
            line = sr.ReadLine();
            int progress = 0;
            while(line != null)
            {
                string[] ret = line.Split('=');
                if(ret[0]== "nowMusic")
                {
                    nowMusic = ret[1];
                }
                else if(ret[0] == "list.index")
                {
                    list.index = int.Parse(ret[1]);
                }
                else if(ret[0] == "list.playChoice")
                {
                    list.playChoice = int.Parse(ret[1]);
                }
                else if(ret[0] == "progressBar.Value")
                {
                    progress = int.Parse(ret[1]);
                }
                else if (ret[0] == "volBar.Value")
                {
                    this.volBar.Value = int.Parse(ret[1]);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

            this.updatePlayMode();
            if(nowMusic != list.getCurrentMusic())
            {
                nowMusic = "";
                list.index = -1;
            }
            this.musicName.Text = getName(nowMusic);
            int duration = list.getCurrentTime();
            this.progressBar.Maximum = duration;
            this.ctrlBar.Maximum = duration;
            try
            {
                this.progressBar.Value = progress;
                this.ctrlBar.Value = progress;
                this.labelBegin.Text = intTimeToString(progress);
            }
            catch (Exception ex)
            {
                this.progressBar.Value = 0;
                this.ctrlBar.Value = 0;
                this.labelBegin.Text = intTimeToString(0);
            }
            this.labelEnd.Text = intTimeToString(duration);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == MM_MCINOTIFY) //判断指令是不是MM_MCINOTIFY

            //当歌曲播完 mciSendString（）向系统发送的MM_MCINOTIFY指令
            {
                this.isPlaying = false;
                this.isStopping = true;
                this.picPlay.Image = Properties.Resources.icon_play;
                this.picNext_Click(this.picNext, new EventArgs());
                this.picPlay_Click(this.picPlay, new EventArgs());
            }
        }

        public string intTimeToString(int time)
        {
            string str;
            int m = time / 60;
            int s = time % 60;
            // MessageBox.Show("m="+m.ToString() + "s=" + s.ToString());
            str = string.Format("{0:D2}:", m) + string.Format("{0:D2}", s);
            return str;
        }

        public void updatelabelBegin()
        {
            if(this.progressBar.Value < this.progressBar.Maximum)
            {
                this.progressBar.Value++;
                this.ctrlBar.Value++;
                this.labelBegin.Text = this.intTimeToString(this.progressBar.Value);
            }
            else
            {
                this.picNext_Click(this.picNext, new EventArgs());
                this.picPlay_Click(this.picPlay, new EventArgs());
            }
        }

        public void threadStart()
        {
            try
            {
                while (true)
                {
                    this.BeginInvoke(new Change(this.updatelabelBegin));
                    // Thread.Sleep(1000);
                    for(int i=0;i<100;i++)
                    {
                        Thread.Sleep(10);
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        delegate void Change();

        private void volBar_ValueChanged(object sender, EventArgs e)
        {
            musicPlay.setVolume(this.volBar.Value);
        }
    }
}
