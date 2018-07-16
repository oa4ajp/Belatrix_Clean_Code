using System.Drawing;

namespace CleanCode.Names
{
    public class Graphic
    {
        public Bitmap DrawBitmap(string fileName)
        {
            var bitmap= new Bitmap(fileName);
            var graphic = Graphics.FromImage(bitmap);
            graphic.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            graphic.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            graphic.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmap;
        }
    }
}
