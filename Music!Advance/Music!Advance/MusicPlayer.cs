using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Music_
{
    class MusicPlayer : SoundPlayer
    {
        public bool loop = false;
        public string[] playlist;

        public void SelectFiles()
        {
            OpenFileDialog op1 = new OpenFileDialog();
            string filter = "WAV(*.wav)|*.wav";
            op1.Filter = filter;
            op1.Multiselect = true;
            if (op1.ShowDialog() == DialogResult.OK)
            {
                playlist = op1.FileNames;
            }
        }

        public void PlaySong(string song)
        {
            SoundLocation = song;
            Play();
        }

        public void PlayLoop(string song)
        {
            SoundLocation = song;

            PlayLooping();
        }

        public void SaveList()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files(*.txt)| *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fin = new FileInfo(sfd.FileName);
                    StreamWriter sw = fin.CreateText();
                    foreach(string a in playlist)
                    {
                        sw.WriteLine(a);
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("請先建立播放清單", "", MessageBoxButtons.OK);
            }
        }

        public void LoadList()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files(*.txt)| *.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                playlist = sr.ReadToEnd().Split('\n');
            }
        }
    }
}
