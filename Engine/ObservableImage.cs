using System.Drawing;
using System.Windows.Forms;

namespace UnilightRaytracer
{
    /*
     *  Wraps a Bitmap we draw onto
     */
    public class ObservableImage
    {
        private System.Drawing.Bitmap mBitmap;

        private class ChangeableSubject /*: Observable*/
        {
            public ChangeableSubject()
            {
            }

            public void changeAndNotifyObservers()
            {
                /*setChanged();
                notifyObservers();*/
            }
        }

        private ChangeableSubject subject = new ChangeableSubject();

        public ObservableImage(int width, int height)
        {
            mBitmap = new Bitmap(width, height, 
                System.Drawing.Imaging.PixelFormat.Format32bppRgb);
        }

        /*public Observable getSubject() {

            return subject;
        }*/

        public void changeAndNotify()
        {
            subject.changeAndNotifyObservers();
        }

        public System.Drawing.Color ColorToSystemColor (Color c)
        {
            return System.Drawing.Color.FromArgb((int)(c.r * 255), (int)(c.g * 255), (int)(c.b * 255));
        }

        public void SetRGB(int x, int y, Color c)
        {
            if (mBitmap != null)
            {
                mBitmap.SetPixel(x, y, ColorToSystemColor(c));
            }
        }

        public Bitmap GetBitmap() { return mBitmap; }

        public int Width { get { return mBitmap != null ? mBitmap.Width : 0; } }

        public int Height { get { return mBitmap != null ? mBitmap.Height : 0; } }

        public void Clear(Color color = null)
        {
            System.Drawing.Color clearCol;

            if (color == null)
            {
                clearCol = System.Drawing.Color.Black;
            }
            else
            {
                clearCol = 
                    System.Drawing.Color.FromArgb(
                        (int) color.r * 255, 
                        (int) color.g * 255, 
                        (int) color.b * 255
                    );                
            }

            if (mBitmap != null)
            {
                int w = mBitmap.Width;
                int h = mBitmap.Height;
                //int rgb = clearCol.getRGB();
                for (int i = 0; i < w; ++i)
                {
                    for (int j = 0; j < h; ++j)
                    {
                        mBitmap.SetPixel(i, j, clearCol);                        
                    }
                }
            }
        }

    }
}