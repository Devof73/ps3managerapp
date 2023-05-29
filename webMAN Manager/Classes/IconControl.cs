using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace webMAN_Manager.Classes
{

    internal class IconControl : Guna2PictureBox
    {
        private IconSize _size;
        public new IconSize Size
        {
            set
            {
                _size = value;
                base.Size = FromEnum(value);
            }
            get
            {
                return _size;
            }
        }
        public IconControl()
        {

            Size = IconSize.small;
        }
        public enum IconSize
        {
            little,
            small,
            medium,
            big,
        }
        public readonly Size[] IconSizes =
        {
            ToSize(16),
            ToSize(32),
            ToSize(48),
            ToSize(64)
        };
        public IconControl(Bitmap image, IconSize size)
        {
            Size = size;
            Image = image;
        }
        private static Size ToSize(int dim) => new Size(dim, dim);
        private Size FromEnum(IconSize sz)
        {
            switch (sz)
            {
                case IconSize.little: return IconSizes[0];
                case IconSize.small: return IconSizes[1];
                case IconSize.medium: return IconSizes[2];
                case IconSize.big: return IconSizes[3];
                default: return IconSizes[1];
            }
        }
    }
}
