using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace VHD_TOOLS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string fileaddress { get; set; }
        string tmp;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OpenDisk_Click(object sender, RoutedEventArgs e)
        {
            var file = new OpenFileDialog();
            file.Filter = "VHD Files|*.vhd|All files|*.*";
            if (file.ShowDialog() == true)
            {
                fileaddress = file.FileName;
                DiskDesc();
            }
        }
        private void NewDisk_Click(object sender, RoutedEventArgs e)
        {
            var wiz = new NewDiskWiz();
            wiz.Show();
            wiz.Closed += Wiz_Closed;
        }

        private void Wiz_Closed(object sender, EventArgs e)
        {
            fileaddress = ProcessHandler._Filename;
            DiskDesc();
        }

        private void Mount_Click(object sender, RoutedEventArgs e)
        {
            ProcessHandler.Prepare("diskpart", true, true, false);
            ProcessHandler.Start();
            tmp = "select vdisk file=\"" + fileaddress + "\"";
            ProcessHandler.WriteLine(tmp, false);
            tmp = "attach vdisk";
            ProcessHandler.WriteLine(tmp, true);
            ProcessHandler.Stop();
        }
        private void Unmount_Click(object sender, RoutedEventArgs e)
        {
            ProcessHandler.Prepare("diskpart", true, true, false);
            ProcessHandler.Start();
            tmp = "select vdisk file=\"" + fileaddress + "\"";
            ProcessHandler.WriteLine(tmp, false);
            tmp = "detach vdisk";
            ProcessHandler.WriteLine(tmp, true);
            ProcessHandler.Stop();
        }
        private void PartitionWizard_Click(object sender, RoutedEventArgs e)
        {
            //nothing yet
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Format_Click(object sender, RoutedEventArgs e)
        {
            ProcessHandler.Prepare("diskpart", true, true, false);
            ProcessHandler.Start();
            tmp = "format fs=exfat label=VHD_Disk quick";
            ProcessHandler.WriteLine(tmp, true);
            ProcessHandler.Stop();
        }
        void DiskDesc()
        {
            ProcessHandler.Prepare("diskpart", true, true, false);
            ProcessHandler.Start();
            tmp = "select vdisk file=\"" + fileaddress + "\"";
            ProcessHandler.WriteLine(tmp, false);
            tmp = "detail vdisk";
            ProcessHandler.WriteLine(tmp, true);
            tmp = ProcessHandler.ReadToEnd();
            tex.Text = textAnalyser(tmp, "Device type ID", "DISKPART>");

            ProcessHandler.Stop();
        }
        string textAnalyser(string text, string strStart, string strEnd)
        {
            int start, End;
            if (text.Contains(strStart) && text.Contains(strEnd))
            {
                //   start = text.IndexOf(strStart, 0) + strStart.Length;      Exact between of strings
                start = text.IndexOf(strStart, 0);
                End = text.IndexOf(strEnd, start);
                return text.Substring(start, End - start);

            }
            else
            {
                return null;
            }

        }
    }
}
