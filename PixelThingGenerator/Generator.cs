using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelThingGenerator
{
    public abstract class Generator
    {
        public abstract Bitmap Generate();
    }
}
