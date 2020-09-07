using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetAdvSampleCS.Core
{
    static class AspectRatioSetup
    {
        public static List<AspectRatioConfig> itemsSource;

        public static List<AspectRatioConfig> bootstrap()
        {

            itemsSource = new List<AspectRatioConfig>
            {
                new AspectRatioConfig
                {
                    Name = "Custom",
                    AspectRatio = null
                },
                new AspectRatioConfig
                {
                    Name = "Square",
                    AspectRatio = 1
                },
                new AspectRatioConfig
                {
                    Name = "Landscape(16:9)",
                    AspectRatio = 16d / 9d
                },
                new AspectRatioConfig
                {
                    Name = "Portrait(9:16)",
                    AspectRatio = 9d / 16d
                },
                new AspectRatioConfig
                {
                    Name = "4:3",
                    AspectRatio = 4d / 3d
                },
                new AspectRatioConfig
                {
                    Name = "3:2",
                    AspectRatio = 3d / 2d
                }
            };

            return itemsSource;
        }


    }

}
