using System;
using System.Drawing;
using System.Drawing.Text;

namespace PixelThingGenerator
{
    public class SpaceshipGenerator : Generator
    {
        private static int xy(int x, int y)
        {
            return (y * Width) + x;
        }

        private enum ComponentEnum
        {
            Empty = 0,
            Solid = 1,
            Body = 2,
            Cockpit = 3,
        }

        private const int Width = 12;
        private const int Height = 12;

        private readonly byte[] _sats = { 40, 60, 80, 100, 80, 60, 80, 100, 120, 100, 80, 60 };
        private readonly byte[] _bris = { 40, 70, 100, 130, 160, 190, 220, 220, 190, 160, 130, 100, 70, 40 };

        private readonly int[] _solid = { xy(5, 2), xy(5, 3), xy(5, 4), xy(5, 5), xy(5, 9) };
        private readonly int[] _body = { xy(4, 1), xy(5, 1), xy(4, 2), xy(3, 3), xy(4, 3), xy(3, 4), xy(4, 4), xy(2, 5), xy(3, 5), xy(4, 5), xy(1, 6), xy(2, 6), xy(3, 6), xy(1, 7), xy(2, 7), xy(3, 7), xy(1, 8), xy(2, 8), xy(3, 8), xy(1, 9), xy(2, 9), xy(3, 9), xy(4, 9), xy(3, 10), xy(4, 10), xy(5, 10) };
        private readonly int[] _cockpit = new[] { xy(4, 6), xy(5, 6), xy(4, 7), xy(5, 7), xy(4, 8), xy(5, 8) };            

        public override Bitmap Generate()
        {
            var seed = Seed > 0 ? Seed : _random.Next(int.MaxValue);

            var ship = new ComponentEnum[Width*Height];

            // Initialise cells
            for (var i = 0; i < Width * Height; ++i) ship[i] = ComponentEnum.Empty;
            for (var i = 0; i < _solid.Length; ++i) ship[_solid[i]] = ComponentEnum.Solid;
            for (var i = 0; i < _body.Length; ++i) ship[_body[i]] = (seed & (1 << i)) == 0 ? ComponentEnum.Body : ComponentEnum.Empty;
            for (var i = 0; i < _cockpit.Length; ++i) ship[_cockpit[i]] = (seed & (1 << (_body.Length + i))) == 0 ? ComponentEnum.Solid : ComponentEnum.Cockpit;

            // Body border
            for (var y = 0; y < Height; ++y)
            {
                for (var x = 0; x < Width/2; ++x)
                {
                    if (ship[xy(x, y)] == ComponentEnum.Body)
                    {
                        if (y > 0 && ship[xy(x, y - 1)] == ComponentEnum.Empty) ship[xy(x, y - 1)] = ComponentEnum.Solid;
                        if (x > 0 && ship[xy(x - 1, y)] == ComponentEnum.Empty) ship[xy(x - 1, y)] = ComponentEnum.Solid;
                        if (x < Width/2 - 1 && ship[xy(x + 1, y)] == ComponentEnum.Empty) ship[xy(x + 1, y)] = ComponentEnum.Solid;
                        if (y < Height - 1 && ship[xy(x, y + 1)] == ComponentEnum.Empty) ship[xy(x, y + 1)] = ComponentEnum.Solid;
                    }
                }
            }

            // Render

            var result = new Bitmap(Width*Scale, Height*Scale);
            var canvas = Graphics.FromImage(result);
            canvas.Clear(Color.Transparent);            

            for (var y = 0; y < Height; ++y)
            {
                for (var x = 0; x < Width/2; ++x)
                {
                    Color color = Color.Transparent;
                    switch (ship[xy(x, y)])
                    {
                        case ComponentEnum.Empty:
                            break;
                        case ComponentEnum.Solid:
                            color = Color.Black;
                            break;
                        case ComponentEnum.Body:
                            color = GetBodyColor(x,y);
                            break;
                        case ComponentEnum.Cockpit:
                            color = GetCockpitColor(x, y);
                            break;
                    }

                    for (int i = 0; i < Scale; ++i)
                        for (int j = 0; j < Scale; ++j)
                    {
                        result.SetPixel((x * Scale) + i, y * Scale + j, color);
                        result.SetPixel(Width * Scale - (x + 1) * Scale + i, y * Scale + j, color);
                    }                    
                }
            }

            return result;
        }     

        private Color GetBodyColor(int x, int y) {
          var s = _sats[y]/255.0f;
          var b = _bris[x]/255.0f;
          int h;

          if(y < 6)
            h = (Seed>>8) & 0xFF;
          else if(y < 9)
            h = (Seed>>16) & 0xFF;
          else
            h = (Seed>>24) & 0xFF;
          return ColorUtils.HSVtoRGB(360*h/256f, s, b);
        }

        private Color GetCockpitColor(int x, int y) {
          var s = _sats[y]/255.0f;
          var b = (_bris[x]+40)/255.0f;
          var h = Seed & 0xFF;
          return ColorUtils.HSVtoRGB(360*h/256f, s, b);
        }
    }
}