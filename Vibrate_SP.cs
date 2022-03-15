using System;

using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RTDMes.Forms
{
    class Vibrate_SP
    {
        // Fields
        private static bool m_bSupport = false;

        // Methods
        private Vibrate_SP()
        {
        }

        public static bool Play()
        {
            int num = -1;
            if (m_bSupport)
            {
                num = VibratePlay(0, IntPtr.Zero, uint.MaxValue, uint.MaxValue);
            }
            else
            {
                if (VibrateGetDeviceCaps(VibrationCapabilities.Amplitude) <= 0)
                {
                    return false;
                }
                m_bSupport = true;
                num = VibratePlay(0, IntPtr.Zero, uint.MaxValue, uint.MaxValue);
            }
            return (num == 0);
        }

        public static bool Stop()
        {
            if (VibrateStop() != 0)
            {
                return false;
            }
            return true;
        }

        [DllImport("aygshell.dll", SetLastError = true)]
        private static extern int VibrateGetDeviceCaps(VibrationCapabilities caps);
        [DllImport("aygshell.dll", EntryPoint = "Vibrate", SetLastError = true)]
        private static extern int VibratePlay(int cvn, IntPtr rgvn, uint fRepeat, uint dwTimeout);
        [DllImport("aygshell.dll", SetLastError = true)]
        private static extern int VibrateStop();

        // Nested Types
        public enum VibrationCapabilities
        {
            Amplitude,
            Frequency,
            last
        }

    }
}
