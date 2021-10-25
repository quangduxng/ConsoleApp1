using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace BasicWinformm.Entities
{
    public class SoundManager
    {
        WindowsMediaPlayer sound;

        public SoundManager(String file)
        {
            sound = new WindowsMediaPlayer();
            sound.URL = file;
        }

        public void Play()
        {
            sound.controls.play();
        }

        public void Stop()
        {
            sound.controls.stop();
        }
    }
}
