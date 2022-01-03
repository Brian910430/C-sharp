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
    }
}
