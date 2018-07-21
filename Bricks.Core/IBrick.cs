using System;
using System.Collections.Generic;
using System.Text;
using Bricks.Core.Shapes;
//using System.Drawing;
using System.ComponentModel;
using System.Drawing;

namespace Bricks.Core
{
    public interface IBrick : INotifyPropertyChanged
    {
        double X { get; set; }
        double Y { get; set; }
        Color Color { get; set; }
    }
}
