﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;


namespace WidgetAdvSampleCS.Core
{
    public interface IXamlRenderListener
    {
        void OnXamlRendered(FrameworkElement control);
    }
}
