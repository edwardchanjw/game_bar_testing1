using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetAdvSampleCS.Core
{
    public class SampleCommand : DelegateCommand
    {
        public string Label { get; set; }

        public SampleCommand(string name, Action action) : base(action)
        {
            Label = name;
        }

    }
}
