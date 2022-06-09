using System.Drawing;
using System.Windows.Forms;
using static Zoo.TigerEnclosure.App.Constants;

namespace Zoo.TigerEnclosure.App.Components
{
    public class ButtonComponent
    {
        internal static Button SetSize(Button button)
        {
            button.Height = FeedButton.Height;
            button.Width = FeedButton.Width;
            return button;
        }

        internal static Button SetPosition(Button button, Size clientSize)
        {
            button.Top = clientSize.Height / 2 - button.Height / 2;
            button.Left = clientSize.Width / 2 - button.Width / 2;
            return button;
        }
    }
}
