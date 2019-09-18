using RestSharp;
using System.Windows;

namespace TestEml
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string host = "http://localhost:8080/";
        private string path = "Loks/1";
        private Pack pack = new Pack();

        public MainWindow()
        {
            InitializeComponent();
            pack.Token = "qwe";
            pack.LockStatus = true;
            pack.PowerStatus = false;
            pack.NetStatus = true;
            Update();
        }

        private void Button_Click_Lock(object sender, RoutedEventArgs e)
        {
            pack.LockStatus = !pack.LockStatus;
            Update();
        }

        private void Button_Click_Power(object sender, RoutedEventArgs e)
        {
            pack.PowerStatus = !pack.PowerStatus;
            Update();
        }

        private void Button_Click_Net(object sender, RoutedEventArgs e)
        {
            pack.NetStatus = !pack.NetStatus;
            Update();
        }

        private void Button_Click_Request(object sender, RoutedEventArgs e)
        {
            var client = new RestClient(host);
            var request = new RestRequest(path, Method.POST);
            request.AddJsonBody(pack);
            var ans = client.Execute(request);
            textBlockReq.Text = ans.ToString();
            Update();
        }

        private void Update() {
            textBlockLock.Text = pack.LockStatus.ToString();
            textBlockPower.Text = pack.PowerStatus.ToString();
            textBlockNet.Text = pack.NetStatus.ToString();
        }
    }
}
