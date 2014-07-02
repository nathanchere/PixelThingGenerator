using System;
using System.Drawing;

namespace PixelThingGenerator
{
    public class SpaceshipGenerator : Generator
    {
        private int xy(int x, int y)
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

        public override Bitmap Generate()
        {
            var v = (new Random()).Next(4 * 1024 * 1024);
            var result = new Bitmap(Width, Height);
            var canvas = Graphics.FromImage(result);
            canvas.Clear(Color.GreenYellow);


            var solid = new[] { xy(5, 2), xy(5, 3), xy(5, 4), xy(5, 5), xy(5, 9) };
            var body = new[]
            {
                xy(4, 1), xy(5, 1), xy(4, 2), xy(3, 3), xy(4, 3), xy(3, 4), xy(4, 4), xy(2, 5),
                xy(3, 5), xy(4, 5), xy(1, 6), xy(2, 6), xy(3, 6), xy(1, 7), xy(2, 7), xy(3, 7),
                xy(1, 8), xy(2, 8), xy(3, 8), xy(1, 9), xy(2, 9), xy(3, 9), xy(4, 9), xy(3, 10),
                xy(4, 10), xy(5, 10)
            };
            var cockpit = new[] { xy(4, 6), xy(5, 6), xy(4, 7), xy(5, 7), xy(4, 8), xy(5, 8) };
            var ship = new ComponentEnum[Width * Height];

            for (var y = 0; y < Height; ++y)
            {
                for (var x = 0; x < Width; ++x)
                {
                    result.SetPixel(x, y, Color.White);
                }
            }

            // Initialise cells
            for (var i = 0; i < Width * Height; ++i) ship[i] = ComponentEnum.Empty;
            for (var i = 0; i < solid.Length; ++i) ship[solid[i]] = ComponentEnum.Solid;
            for (var i = 0; i < body.Length; ++i)
                ship[body[i]] = (v & (1 << i)) == 0 ? ComponentEnum.Body : ComponentEnum.Empty;



            // Render
            for (var y = 0; y < Height; ++y)
            {
                for (var x = 0; x < Width / 2; ++x)
                {
                    Color color = Color.Black;
                    switch (ship[xy(x, y)])
                    {
                        case ComponentEnum.Empty:
                            break;
                        case ComponentEnum.Solid:
                            color = Color.Gray;
                            break;
                        case ComponentEnum.Body:
                            color = Color.Pink; //; colorBody(x, y);
                            break;
                        case ComponentEnum.Cockpit:
                            color = Color.LemonChiffon; //; colorCockpit(x, y);
                            break;
                    }

                    result.SetPixel(x, y, color);
                    result.SetPixel(Width - x - 1, y, color);
                }
            }

            return result;
        }







    }
}