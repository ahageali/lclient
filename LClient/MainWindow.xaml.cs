using LClient.Supporting;
using MahApps.Metro.Controls;
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

namespace LClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        com.riotgames.platform.clientfacade.domain.LoginDataPacket LoginData;
        LRtmp RtmpClient;

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(com.riotgames.platform.clientfacade.domain.LoginDataPacket data, LRtmp client)
        {
            InitializeComponent();
            LoginData = data;
            RtmpClient = client;
            btnName.Content = data.allSummonerData.summoner.name;
            Closing += MainWindow_Closing;
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RtmpClient.Disconnect();
        }

        void MainWindow_PlayButton(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
