using System.Drawing;
using System.Windows.Forms;
using static Zoo.TigerEnclosure.App.Constants;

namespace Zoo.TigerEnclosure.App.Components
{
    public class PictureBoxComponent
    {
        PictureBox pictureBox;

        public PictureBoxComponent(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        internal static PictureBox SetSize(PictureBox pictureBox)
        {
            pictureBox.Height = TigerPictureBox.Height;
            pictureBox.Width = TigerPictureBox.Width;
            return pictureBox;
        }

        internal static PictureBox SetPosition(PictureBox pictureBox, Size clientSize)
        {
            pictureBox.Top = clientSize.Height / 2 - pictureBox.Height / 2;
            pictureBox.Left = clientSize.Width * 2 / 3 - pictureBox.Width / 3;
            return pictureBox;
        }

        internal static PictureBox AdjustSize(PictureBox pictureBox)
        {
            pictureBox.Height = (int)(pictureBox.Height * GrowRate.Height);
            pictureBox.Width = (int)(pictureBox.Width * GrowRate.Width);
            return pictureBox;
        }

        internal bool FitInside(Size clientSize)
        {
            if (pictureBox.Top + pictureBox.Height >= clientSize.Height)
                return false;
            if (pictureBox.Left + pictureBox.Width >= clientSize.Width)
                return false;
            return true;
        }
    }
}
