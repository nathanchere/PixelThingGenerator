using System.Drawing;

namespace PixelThingGenerator
{
    public static class ColorUtils
    {
        public static Color HSVtoRGB(float hue, float saturation, float value)
        {
            while (hue > 1f) { hue -= 1f; }
            while (hue < 0f) { hue += 1f; }
            while (saturation > 1f) { saturation -= 1f; }
            while (saturation < 0f) { saturation += 1f; }
            while (value > 1f) { value -= 1f; }
            while (value < 0f) { value += 1f; }
            if (hue > 0.999f) { hue = 0.999f; }
            if (hue < 0.001f) { hue = 0.001f; }
            if (saturation > 0.999f) { saturation = 0.999f; }
            if (saturation < 0.001f) { var val = (byte)(value * 255); return Color.FromArgb(val,val,val); }
            if (value > 0.999f) { value = 0.999f; }
            if (value < 0.001f) { value = 0.001f; }

            float h6 = hue * 6f;
            if (h6 == 6f) { h6 = 0f; }
            int ihue = (int)(h6);
            float p = value * (1f - saturation);
            float q = value * (1f - (saturation * (h6 - (float)ihue)));
            float t = value * (1f - (saturation * (1f - (h6 - (float)ihue))));
            byte r, g, b;
            switch (ihue)
            {
                case 0:
                    r = (byte)(value*255);
                    g = (byte)(t*255);
                    b = (byte)(p*255);
                    break;
                case 1:
                    r = (byte)(q*255);
                    g = (byte)(value*255);
                    b = (byte)(p*255);
                    break;
                case 2:
                    r = (byte)(p*255);
                    g = (byte)(value*255);
                    b = (byte)(t*255);
                    break;
                case 3:
                    r = (byte)(p*255);
                    g = (byte)(q*255);
                    b = (byte)(value*255);
                    break;
                case 4:
                    r = (byte)(t*255);
                    g = (byte)(p*255);
                    b = (byte)(value*255);
                    break;
                default:
                    r = (byte)(value*255);
                    g = (byte)(p*255);
                    b = (byte)(q*255);
                    break;
            }
            return Color.FromArgb(r,g,b);
        }
    }
}