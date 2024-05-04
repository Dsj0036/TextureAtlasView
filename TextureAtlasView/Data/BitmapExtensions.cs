using System.Drawing;

public static class BitmapExtensions
{
    public static Bitmap Crop(this Bitmap source, Rectangle r)
    {
        return source.Clone(r, source.PixelFormat);
    }

    public static Bitmap Upscale(this Bitmap source)
    {
        Bitmap resizedImage = new Bitmap(source.Width * 2, source.Height * 2);

        using (Graphics g = Graphics.FromImage(resizedImage))
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(source, 0, 0, resizedImage.Width, resizedImage.Height);
        }
        return resizedImage;
    }

    // Upscale a 16*16 to 64*64
    public static Bitmap Upscale16(this Bitmap source)
    {
        return Upscale(Upscale(Upscale(source)));
    }
}