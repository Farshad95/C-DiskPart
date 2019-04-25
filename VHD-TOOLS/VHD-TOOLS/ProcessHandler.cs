using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace VHD_TOOLS
{
    class ProcessHandler
    {
        private static Process _pro = new Process();
        static bool Ready = false;
        public static bool OutputIsReady { get; set; } = false;
        public static string _Filename { get; set; }
        public static void Prepare(string FileName,bool RedirectStandardInput,bool RedirectStandardOutput,bool UseShellExecute)
        {
            _pro.StartInfo.FileName = FileName;
            _pro.StartInfo.RedirectStandardInput = RedirectStandardInput;
            _pro.StartInfo.RedirectStandardOutput = RedirectStandardOutput;
            _pro.StartInfo.UseShellExecute = UseShellExecute;
            _pro.StartInfo.CreateNoWindow = true;
            Ready = true;
        }
        public static bool Start()
        {
            if (Ready)
            {
                _pro.Start();
                return true;
            }
            else
                return false;
        }
        public static void WriteLine(string text,bool CloseIt)
        {
            OutputIsReady = false;
            _pro.StandardInput.WriteLine(text);
           if (CloseIt)
            {
                _pro.StandardInput.Flush();
                _pro.StandardInput.Close();
                Thread.Sleep(1500);
                OutputIsReady = true;
            }
            
        }
        public static string ReadLine()
        {
            return _pro.StandardOutput.ReadLine();
        }
        public static string ReadToEnd()
        {
            return _pro.StandardOutput.ReadToEnd();
        }
        public static void Stop()
        {
            _pro.Close();
        }
    }
}
