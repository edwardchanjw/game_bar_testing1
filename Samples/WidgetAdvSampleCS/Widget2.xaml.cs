using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics;
using Windows.Graphics.Capture;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WidgetAdvSampleCS.Core;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WidgetAdvSampleCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Widget2 : Page
    {
        private CanvasDevice _device;
        
        private SpriteVisual _visual;

        public Widget2()
        {
            this.InitializeComponent();
            _device = new CanvasDevice();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.Graphics.Capture.GraphicsCapturePicker graphicsCapturePicker = new Windows.Graphics.Capture.GraphicsCapturePicker();
            Windows.Graphics.Capture.GraphicsCaptureItem graphicsCaptureItem = await graphicsCapturePicker.PickSingleItemAsync();

            if (graphicsCaptureItem == null)
                return;


        }

    }
}
