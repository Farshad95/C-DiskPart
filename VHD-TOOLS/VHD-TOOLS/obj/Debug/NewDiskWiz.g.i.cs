﻿#pragma checksum "..\..\NewDiskWiz.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CE1AB2B06C16DDF3EC26FE926A4F463F68433487"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VHD_TOOLS;


namespace VHD_TOOLS {
    
    
    /// <summary>
    /// NewDiskWiz
    /// </summary>
    public partial class NewDiskWiz : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FormatChkBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FormatGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ntfs;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton fat32;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton exfat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FixedSize;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ExpandableSize;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImageSize;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_txtbx;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Browsebtt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\NewDiskWiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Savebtt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VHD-TOOLS;component/newdiskwiz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewDiskWiz.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.groupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.FormatChkBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\NewDiskWiz.xaml"
            this.FormatChkBox.Click += new System.Windows.RoutedEventHandler(this.FormatChkBox_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FormatGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ntfs = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.fat32 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.exfat = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.FixedSize = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\NewDiskWiz.xaml"
            this.FixedSize.Checked += new System.Windows.RoutedEventHandler(this.FixedSize_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ExpandableSize = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\NewDiskWiz.xaml"
            this.ExpandableSize.Checked += new System.Windows.RoutedEventHandler(this.ExpandableSize_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ImageSize = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\NewDiskWiz.xaml"
            this.ImageSize.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ImageSize_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 25 "..\..\NewDiskWiz.xaml"
            this.ImageSize.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ImageSize_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Input_txtbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.Browsebtt = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\NewDiskWiz.xaml"
            this.Browsebtt.Click += new System.Windows.RoutedEventHandler(this.Browsebtt_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Savebtt = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\NewDiskWiz.xaml"
            this.Savebtt.Click += new System.Windows.RoutedEventHandler(this.Savebtt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

