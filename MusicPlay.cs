using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MediaPlayer
{
    public class MusicPlay
    {
        public static uint SND_ASYNC = 0x0001;
        public static uint SND_FILENAME = 0x00020000;
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand, string lpstrReturnString, uint uReturnLength, uint hWndCallback);

        public void PlayNmusinc(string path)
        {
            mciSendString(@"close temp_alias", null, 0, 0);
            mciSendString(@"open """ + path + @""" alias temp_alias", null, 0, 0);
            mciSendString("play temp_alias repeat", null, 0, 0);
        }

        /// <summary>
        /// 播放音乐文件(重复)
        /// </summary>
        /// <param name="p_FileName">音乐文件名称</param>
        public void PlayMusic_Repeat(string p_FileName)
        {
            try
            {
                mciSendString(@"close temp_music", " ", 0, 0);
                mciSendString(@"open " + p_FileName + " alias temp_music", " ", 0, 0);
                mciSendString(@"play temp_music repeat", " ", 0, 0);
            }
            catch
            { }
        }

        /// <summary>
        /// 播放音乐文件
        /// </summary>
        /// <param name="p_FileName">音乐文件名称</param>
        public void PlayMusic(string p_FileName)
        {
            try
            {
                mciSendString(@"close temp_music", " ", 0, 0);
                //mciSendString(@"open " + p_FileName + " alias temp_music", " ", 0, 0);
                mciSendString(@"open """ + p_FileName + @""" alias temp_music", null, 0, 0);
                mciSendString(@"play temp_music", " ", 0, 0);
            }
            catch
            { }
        }

        /// <summary>
        /// 停止当前音乐播放
        /// </summary>
        /// <param name="p_FileName">音乐文件名称</param>
        public void StopMusic(string p_FileName)
        {
            try
            {
                mciSendString(@"close " + p_FileName, " ", 0, 0);
            }
            catch { }
        }

        public void pauseMusic()
        {
            mciSendString(@"pause temp_music", " ", 0, 0);
        }

        public void resumeMusic()
        {
            mciSendString(@"resume temp_music", " ", 0, 0);
        }

        public void seekToPosition(int pos)
        {
            // pos的单位是ms 在主线程中计算传参进
            mciSendString(@"seek temp_music to " + pos.ToString(), null, 0, 0);
            mciSendString(@"play temp_music", " ", 0, 0);
        }

        public void setVolume(int volume)
        {
            mciSendString(@"setaudio temp_music volume to " + volume.ToString(), null, 0, 0);
        }
    }
}
