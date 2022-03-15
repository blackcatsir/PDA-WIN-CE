using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.WindowsCE.Forms;
using System.Runtime.InteropServices;
namespace RTDMes.Forms
{
    class ProcessUtil
    {
        [System.Runtime.InteropServices.DllImport("coredll")]
        private static extern IntPtr FindWindow(string strclassName, string strWindowName);
        /// <summary>
        /// 判断该程序是否已有实例运行
        /// </summary>
        /// <param name="fileName">实例文件名</param>
        /// <returns>是否有运行实例</returns>
        public static bool HasRunningInstance(string strclassName, string strWindowName)
        {
            IntPtr hWnd = FindWindow(null, strWindowName);
            if (hWnd != IntPtr.Zero)
            {
                return true;
            }
            return false;
        }
    }
}
