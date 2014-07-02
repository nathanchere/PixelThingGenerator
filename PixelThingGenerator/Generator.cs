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
        protected Random _random;                
        public int Seed { get; set; }
        public int Scale { get; set; }

        protected Generator()
        {
            _random = new Random(Guid.NewGuid().GetHashCode());
        }

        public abstract Bitmap Generate();
    }
}
