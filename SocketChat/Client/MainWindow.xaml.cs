﻿using System;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChatClient cc;
        public MainWindow()
        {
            InitializeComponent();
            cc = new ChatClient();
            this.DataContext = cc;
        }

        private void bSwitchClientState_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ip_address = ipAddress.Text;
                cc.SwitchClientState(ip_address);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            cc.SendMessageTo(tbTargetUsername.Text, tbMessage.Text);
        }
    }
}
