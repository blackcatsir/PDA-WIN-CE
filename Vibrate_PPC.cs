using System;

using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RTDMes.Forms
{
    class Vibrate_PPC
    {
        // Fields
        private static uint m_availableNo = uint.MaxValue;
        private const int NLED_COUNT_INFO_ID = 0;
        private const int NLED_SETTINGS_INFO_ID = 2;

        // Methods
        private Vibrate_PPC()
        {
        }

        [DllImport("coredll.dll", EntryPoint = "NLedGetDeviceInfo")]
        private static extern bool NLedGetDeviceCount(short nID, ref NLED_COUNT_INFO pOutput);
        [DllImport("coredll.dll", EntryPoint = "NLedGetDeviceInfo")]
        private static extern bool NLedGetDeviceSupports(short nID, ref NLED_SUPPORTS_INFO pOutput);
        [DllImport("coredll.dll")]
        private static extern bool NLedSetDevice(short nID, ref NLED_SETTINGS_INFO pOutput);
        public static bool Play()
        {
            bool flag = false;
            NLED_SETTINGS_INFO pOutput = new NLED_SETTINGS_INFO();
            pOutput.OffOnBlink = 1;
            if (m_availableNo == uint.MaxValue)
            {
                NLED_COUNT_INFO nled_count_info = new NLED_COUNT_INFO();
                if (!NLedGetDeviceCount(0, ref nled_count_info))
                {
                    return false;
                }
                m_availableNo = nled_count_info.cLeds - 1;
                pOutput.LedNum = m_availableNo;
                flag = NLedSetDevice(2, ref pOutput);
            }
            else
            {
                pOutput.LedNum = m_availableNo;
                flag = NLedSetDevice(2, ref pOutput);
            }
            return flag;
        }

        public static bool Stop()
        {
            if (m_availableNo != uint.MaxValue)
            {
                NLED_SETTINGS_INFO pOutput = new NLED_SETTINGS_INFO();
                pOutput.LedNum = m_availableNo;
                pOutput.OffOnBlink = 0;
                return NLedSetDevice(2, ref pOutput);
            }
            return false;
        }

        // Nested Types
        public enum LedState
        {
            Off,
            On,
            Blink
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NLED_COUNT_INFO
        {
            public uint cLeds;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NLED_SETTINGS_INFO
        {
            public uint LedNum;
            public int OffOnBlink;
            public int TotalCycleTime;
            public int OnTime;
            public int OffTime;
            public int MetaCycleOn;
            public int MetaCycleOff;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NLED_SUPPORTS_INFO
        {
            public uint LedNum;
            public int lCycleAdjust;
            public bool fAdjustTotalCycleTime;
            public bool fAdjustOnTime;
            public bool fAdjustOffTime;
            public bool fMetaCycleOn;
            public bool fMetaCycleOff;
        }

    }
}
