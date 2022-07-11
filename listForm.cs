using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Shell32;

namespace MediaPlayer
{
    public partial class listForm : Form
    {
        private List<string> musicList;
        private ListViewColumnSorter lvwColumnSorter;

        public listForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.ico_music;
            musicList = new List<string>();
            // 创建一个ListView排序类的对象，并设置playList的排序器
            lvwColumnSorter = new ListViewColumnSorter();
            this.playList.ListViewItemSorter = lvwColumnSorter;
            readFile();
            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.icon_mp3);
            this.playList.SmallImageList = imageList;
            this.index = 0;
            this.playChoice = 0;
        }

        public void setUI()
        {
            //this.playList.Columns[1].Width = -2;
            //this.playList.Columns[0].Width = -1;
            //this.playList.Columns[2].Width = -2;
            playList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            int w = 35;
            for(int i=0;i<playList.Columns.Count;i++)
            {
                w += playList.Columns[i].Width;
            }
            if(w<400)
            {
                w = 400;
            }
            this.Size = new Size(w, 500);
        }

        public void readFile()
        {
            FileStream fs = new FileStream("./list.ini", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            line = sr.ReadLine();
            while (line != null)
            {
                string path = "";
                string[] towardsTime = {};
                if(line.Contains("="))
                {
                    towardsTime = line.Split('=');
                    for (int i = 0; i < towardsTime.Length - 1; i++)
                    {
                        path += towardsTime[i];
                    }
                }
                else
                {
                    path = line;
                }
                if (!this.musicList.Contains(path))
                {
                    this.musicList.Add(path);
                    string temp = path.Replace("\\" + "\\", "\\");
                    string[] ret = temp.Split('\\');
                    string duration = "";
                    try
                    {
                        duration = towardsTime[towardsTime.Length - 1];
                    }
                    catch(Exception) { }
                    string name = ret[ret.Length - 1];
                    ListViewItem item = new ListViewItem((this.playList.Items.Count+1).ToString(), 0);
                    item.SubItems.Add(name);
                    item.SubItems.Add(duration);
                    this.playList.Items.Add(item);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void playList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = this.playList.GetItemAt(e.X, e.Y);
                int pos = this.playList.Items.IndexOf(item);
                if (this.playList.FocusedItem == null || pos != this.playList.FocusedItem.Index)
                {
                    this.delTool.Enabled = false;
                }
                else
                {
                    this.delTool.Enabled = true;
                }
                this.contextMenu.Show(this.playList, e.Location);
            }
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "..\\";
            ofd.Multiselect = true;
            ofd.Filter = "音频文件 (*.mp3; *.m4a; *.wav; *.flac) | *.mp3; *.m4a; *.wav; *.flac";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] filePath = ofd.FileNames;
                this.updateList(filePath);
            }
        }

        private void updateList(string[] filePath)
        {
            FileStream fs = new FileStream("./list.ini", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            foreach (string filePathItem in filePath)
            {
                string temp = filePathItem.Replace("\\", "\\" + "\\");
                if (!this.musicList.Contains(temp))
                {
                    string duration = getMusicTime(temp);
                    if(duration != "")
                    {
                        sw.WriteLine(temp + "=" + duration);
                    }
                    else
                    {
                        sw.WriteLine(temp);
                    }
                    this.musicList.Add(temp);
                    string[] ret = filePathItem.Split('\\');
                    string name = ret[ret.Length - 1];
                    //Console.WriteLine(name);
                    ListViewItem item = new ListViewItem((this.playList.Items.Count + 1).ToString(), 0);
                    item.SubItems.Add(name);
                    item.SubItems.Add(duration);
                    this.playList.Items.Add(item);
                }
            }
            setUI();
            sw.Close();
            fs.Close();
        }

        private void playList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.playList.GetItemAt(e.X, e.Y);
            //Console.WriteLine(item.Text);
            this.index = this.playList.Items.IndexOf(item);
            this.DialogResult = DialogResult.OK;
        }

        public string getCurrentMusic()
        {
            try
            {
                return this.musicList[this.index];
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string getLastMusic()
        {
            int total = this.musicList.Count;
            switch (playChoice)
            {
                case 0:
                    index--;
                    break;
                case 1:
                    break;
                case 2:
                    System.Random a = new Random(System.DateTime.Now.Millisecond);
                    index = a.Next(total);
                    break;
            }
            if (index < 0)
            {
                index += this.musicList.Count;
            }
            try
            {
                return this.musicList[index];
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string getNextMusic()
        {
            int total = this.musicList.Count;
            switch (playChoice)
            {
                case 0:
                    index++;
                    break;
                case 1:
                    break;
                case 2:
                    System.Random a = new Random(System.DateTime.Now.Millisecond);
                    index = a.Next(total);
                    break;
            }
            if (index > this.musicList.Count - 1)
            {
                index -= this.musicList.Count;
            }
            try
            {
                return this.musicList[index];
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public int index;
        public int playChoice;

        private void delTool_Click(object sender, EventArgs e)
        {
            int index = this.playList.FocusedItem.Index;
            this.musicList.RemoveAt(index);
            this.playList.Items.RemoveAt(index);
            FileStream fs = new FileStream("./list.ini", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            foreach (string name in this.musicList)
            {
                sw.WriteLine(name);
            }
            sw.Close();
            fs.Close();
        }

        private void clearTool_Click(object sender, EventArgs e)
        {
            this.musicList.Clear();
            this.playList.Items.Clear();
            FileStream fs = new FileStream("./list.ini", FileMode.Create);
            fs.Close();
        }

        private void addDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            string path;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            else
            {
                return;
            }

            DirectoryInfo folder = new DirectoryInfo(path);
            FileStream fs = new FileStream("./list.ini", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            string[] typeList = { "mp3", "m4a", "wav", "flac" };
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                string[] ret = file.FullName.Split('.');
                if(typeList.Contains(ret[ret.Length - 1].ToLower()))
                {
                    string temp = file.FullName.Replace("\\", "\\" + "\\");
                    if (!this.musicList.Contains(temp))
                    {
                        this.musicList.Add(temp); 
                    }
                }
            }
            this.musicList.Sort();
            foreach(string fileName in musicList)
            {
                string duration = getMusicTime(fileName);
                if(duration != "")
                {
                    sw.WriteLine(fileName + "=" + duration);
                }
                else
                {
                    sw.WriteLine(fileName);
                }
                string temp = fileName.Replace("\\" + "\\", "\\");
                string[] ret = temp.Split('\\');
                string name = ret[ret.Length - 1];
                ListViewItem item = new ListViewItem((this.playList.Items.Count + 1).ToString(), 0);
                item.SubItems.Add(name);
                item.SubItems.Add(duration);
                this.playList.Items.Add(item);
                //Console.WriteLine(fileName);
            }
            setUI();
            sw.Close();
            fs.Close();
        }

        public string getMusicTime(string fileName)
        {
            if(fileName == "")
            {
                return "";
            }
            string dirName = Path.GetDirectoryName(fileName);//获取文件夹名称
            string voiceName = Path.GetFileName(fileName);//获取文件名
            FileInfo file = new FileInfo(fileName);
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(dirName);
            FolderItem item = dir.ParseName(voiceName);
            string songTime = dir.GetDetailsOf(item, 27);//win7参数为27
            return songTime;
        }

        public int timeToInt(string time)
        {
            string[] ret = time.Split(':');
            int duration = 0;
            try
            {
                duration += int.Parse(ret[0]) * 3600;
                duration += int.Parse(ret[1]) * 60;
                duration += int.Parse(ret[2]);
            }
            catch (Exception)
            {
                Console.WriteLine(ret);
            }
            return duration;
        }

        public int getCurrentTime()
        {
            string music = getCurrentMusic();
            if(music != "")
            {
                return timeToInt(getMusicTime(music));
            }
            else
            {
                return 0;
            }
        }

        public int findMusic(string str)
        {
            foreach(string name in musicList)
            {
                if(name.Contains(str))
                {
                    return musicList.IndexOf(name);
                }
            }
            return -1;
        }

        private void searchTool_Click(object sender, EventArgs e)
        {
            searchForm searchDlg = new searchForm();
            searchDlg.StartPosition = FormStartPosition.CenterParent;
            string str = "";
            if (searchDlg.ShowDialog() == DialogResult.OK)
            {
                str = searchDlg.textSearch.Text;
            }
            if(str == "")
            {
                return;
            }
            int pos = findMusic(str);
            if(pos != -1)
            {
                this.playList.Items[pos].Selected = true;
                this.playList.EnsureVisible(pos);
            }
            else
            {
                MessageBox.Show("未查找到内容");
            }
        }
    
        public string getMusicAt(int pos)
        {
            try
            {
                return this.musicList[pos];
            }
            catch(Exception)
            {
                return "";
            }
        }
    }
}
