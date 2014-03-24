using Microsoft.Kinect.Toolkit;
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

public enum KinectStatus
{
    Undefined,
    Disconnected,
    Connected,
    Initializing,
    Error,
    NotPowered,
    NotReady,
    DeviceNotGenuine,
    DeviceNotSupported,
    InsufficientBandwidth,
}

namespace DUI_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private KinectSensorChooser sensorChooser;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }
        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs) 
        { 
            this.sensorChooser = new KinectSensorChooser(); 
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged; 
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser; 
            this.sensorChooser.Start(); 
        }

        private void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args)
        {
            MessageBox.Show(args.NewSensor == null ? "No Kinect" : args.NewSensor.Status.ToString());
        }

        private void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args)
        {
            bool error = false;
            if (args.OldSensor != null)
            {
                try
                {
                    args.OldSensor.DepthStream.Range = Microsoft.Kinect.DepthRange.Default;
                    args.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    args.OldSensor.DepthStream.Disable();
                    args.OldSensor.SkeletonStream.Disable();
                
                }




        }


    }
}
