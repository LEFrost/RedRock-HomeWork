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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace HomeWork
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        public void myAdd(Button x)
        {
            Input.Text = (Input.Text + x.Content).ToString();
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            myAdd(one);
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Count() != 0 && Input.Text!=0.ToString())
                Input.Text = Input.Text.Remove(Input.Text.Count() - 1);
            else
                Input.Text = 0.ToString();
        }
    }
}
