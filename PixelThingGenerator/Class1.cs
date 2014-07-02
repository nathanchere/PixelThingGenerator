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

    public class SpaceshipGenerator : Generator
    {
        private enum ComponentEnum
        {
            Empty = 0,
            Solid = 1,
            Body = 2,
            Cockpit = 3,
        }

        private const int Width = 12;
        private const int Height = 12;
        
        public override Bitmap Generate()
        {
            var result = new Bitmap(Width, Height);                      
            var canvas = Graphics.FromImage(result);
            canvas.Clear(Color.GreenYellow);
            return result;
        }
                    
    }
}
