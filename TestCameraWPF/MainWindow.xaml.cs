using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TestCameraWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CamerasSourceModel CamerasSourceModel { get; set; } = new CamerasSourceModel();


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = CamerasSourceModel;            
            
            this.Show();

            StartWebSocketClient();

            StartSpeedUpdate();
            //StartRPMUpdate();

               
        }

        private void StartSpeedUpdate()
        {
            var speedTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(400)
            };
            speedTimer.Tick += (s, e) =>
            {
                this.CamerasSourceModel.MachineState.Velocity  = (this.CamerasSourceModel.MachineState.Velocity + 1) % 61;
                //this.CamerasSourceModel.IsP1 = true;
            };            
            speedTimer.Start();           
        }

        private void StartRPMUpdate()
        {
            var speedTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(1)
            };
            speedTimer.Tick += (s, e) =>
            {               
                this.CamerasSourceModel.RPM = (this.CamerasSourceModel.RPM + 1) % 3001;
                //this.CamerasSourceModel.IsP1;
            };
            speedTimer.Start();
        }

        private async Task StartWebSocketClient()
        {
            var connectionString = "wss://belaz.dev.internal.k8s.indev.by/api/machine-control/ws/career/machine/{id}?token={token}";
            connectionString = connectionString.Replace("{id}", "1");
            connectionString = connectionString.Replace("{token}", "eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdXRob3JpemVkIjp0cnVlLCJjaGFuZ2VfcGFzcyI6IiIsImV4cCI6MTczNzExNTk4MiwiaWF0IjoxNzM3MDI5NTgyLCJyb2xlcyI6WzEsMiwzLDRdLCJ0eXBlIjoiYWNjZXNzIiwidXNlcl9pZCI6MSwidXNlcl9uYW1lIjoi0JDQtNC80LjQvSDQkNC00LzQuNC9INCQ0LTQvNC40L3QvtCy0LjRhyJ9.J0F9htklD7_IHmlGCI5zcjreP-kmeuEU8D6ek7Crki8bJ1-laM3Rx7dqL19uIeiANAZjVFmJN0xDKcJmrlkN-w");

            WebSocketClient webSocketClient = new WebSocketClient(CamerasSourceModel);
            await webSocketClient.ConnectToServer(connectionString);
        }

        
    }
}