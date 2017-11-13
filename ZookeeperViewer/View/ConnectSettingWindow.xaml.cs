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
using System.Windows.Shapes;
using ZookeeperViewer.ViewModel;

namespace ZookeeperViewer.View
{
    /// <summary>
    /// ConnectSettingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ConnectSettingWindow : Window
    {
        public ConnectSettingWindow()
        {
            InitializeComponent();
            var data = new ConnectSettingWindowVM();
            data.ConnectionString = System.IO.File.ReadAllText("C:\\Program Files\\zookeeper.txt");
            this.DataContext = data;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            var data = this.DataContext as ConnectSettingWindowVM;
            System.IO.File.WriteAllText("C:\\Program Files\\zookeeper.txt", data.ConnectionString);
            this.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
