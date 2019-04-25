using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;
namespace VHD_TOOLS
{
    /// <summary>
    /// Interaction logic for NewDiskWiz.xaml
    /// </summary>
    public partial class NewDiskWiz : Window
    {
        public NewDiskWiz()
        {
            InitializeComponent();
        }

        private void Savebtt_Click(object sender, RoutedEventArgs e)
        {
            ProcessHandler._Filename = Input_txtbx.Text;
            Savebtt.IsEnabled = false;
            Savebtt.Cursor = Cursors.Wait;
            string tmp = "create vdisk file=\"" + Input_txtbx.Text + "\" maximum=" + Convert.ToInt32(ImageSize.Text)+"\"";
            if (ExpandableSize.IsChecked == true)
                tmp += " type=EXPANDABLE";
            if (FixedSize.IsChecked == true)
                tmp += " type=FIXED";
            ProcessHandler.Prepare("diskpart", true, true, false);
            ProcessHandler.Start();
            ProcessHandler.WriteLine(tmp,true);


            


            if (FormatChkBox.IsChecked == true)
            {
                Thread.Sleep(5000);
                ProcessHandler.Prepare("diskpart", true, true, false);
                ProcessHandler.Start();
                tmp = "select vdisk file=\"" + Input_txtbx.Text + "\"";
                ProcessHandler.WriteLine(tmp,false);
                tmp = "attach vdisk";
                ProcessHandler.WriteLine(tmp, false);
                tmp = "convert mbr";
                ProcessHandler.WriteLine(tmp,false);
                tmp = "create partition primary";
                ProcessHandler.WriteLine(tmp, false);
                tmp = "format fs="+Format_type()+" label=VHD_Disk quick";
                ProcessHandler.WriteLine(tmp,false);
                tmp = "assign letter=z";
                ProcessHandler.WriteLine(tmp, true);
            }
            

            Savebtt.IsEnabled = true;
            Savebtt.Cursor = Cursors.Arrow;

            ProcessHandler.Stop();
            this.Close();
        }

        private void Browsebtt_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "VHD Files|*.vhd";
            if (file.ShowDialog() == true)
            {
                Input_txtbx.Text = file.FileName;
            }
            if (isComplete())
                Savebtt.IsEnabled = true;
            else
                Savebtt.IsEnabled = false;
        }

        private void FormatChkBox_Click(object sender, RoutedEventArgs e)
        {
            if (FormatChkBox.IsChecked == true)
                FormatGrid.IsEnabled = true;
            else if (FormatChkBox.IsChecked == false)
                FormatGrid.IsEnabled = false;
        }
        
        private bool isComplete()
        {
            bool tmp=false;
            if (Input_txtbx.Text != "" && ImageSize.Text != "")
            {
                if (ExpandableSize.IsChecked == true || FixedSize.IsChecked == true)
                    tmp = true;
            }
            if (tmp)
                return true;
            else
                return false;
            
        }

        private void ExpandableSize_Checked(object sender, RoutedEventArgs e)
        {
            if (isComplete())
                Savebtt.IsEnabled = true;
            else
                Savebtt.IsEnabled = false;
        }

        private void FixedSize_Checked(object sender, RoutedEventArgs e)
        {
            if (isComplete())
                Savebtt.IsEnabled = true;
            else
                Savebtt.IsEnabled = false;
        }

        private void ImageSize_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9+]").IsMatch(e.Text);
        }

        private void ImageSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isComplete())
                Savebtt.IsEnabled = true;
            else
                Savebtt.IsEnabled = false;
        }
        string Format_type()
        {
            if (ntfs.IsChecked == true)
                return "ntfs";
            else if (fat32.IsChecked == true)
                return "fat32";
            else if (exfat.IsChecked == true)
                return "exfat";
            else
                return null;
        }
    }
}
