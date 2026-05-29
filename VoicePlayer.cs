using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace cyber_security_bottttt
{
    class VoicePlayer
    {
        public void PlayVoice()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\cyber security bottttt\\cyber security bottttt\\WhatsApp-Audio-2026-05-28-at-14.57.17-Copy-_2_ (1).wav");

                player.Play();
            }
            catch
            {
                MessageBox.Show("Voice file not found.");
            }
        }

    }
}
