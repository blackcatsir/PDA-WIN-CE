using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.WindowsCE.Forms;

namespace RTDMes.Forms
{
    class Vibrate
    {
        // Fields
        public int interval;

        // Methods
        public static void Play(int microSeconds)
        {
            //if (SystemSettings.get_Platform == 1)
            //{
               
            //    Vibrate_PPC.Play();
            //    Thread.Sleep(microSeconds);
            //    Vibrate_PPC.Stop();
            //}
            //else if (SystemSettings.get_Platform() == 2)
            //{
            //    Vibrate_SP.Play();
            //    Thread.Sleep(microSeconds);
            //    Vibrate_SP.Stop();
            //}
        }

        public void PlayThreadRun()
        {
            //if (SystemSettings.get_Platform() == 1)
            //{
            //    Vibrate_PPC.Play();
            //    Thread.Sleep(this.interval);
            //    Vibrate_PPC.Stop();
            //}
            //else if (SystemSettings.get_Platform() == 2)
            //{
            //    Vibrate_SP.Play();
            //    Thread.Sleep(this.interval);
            //    Vibrate_SP.Stop();
            //}
        }

    }
}
