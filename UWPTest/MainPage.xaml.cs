﻿using ClassLibraryforUWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
/// <summary>
/// 使用自定义Nuget包获取时间
/// </summary>
/// <param name="sender">事件发起者</param>
/// <param name="e">携带参数</param>
        private void ButtonGetResult_Click_1(object sender, RoutedEventArgs e)
        {
            var result = Utility.GetResult();
            this.TimeTextbox.Text = result;
        }
    }
}
