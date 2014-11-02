using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xMaterialControls.Material
{
    public class Theme
    {
        public Color Background;
        public Color Primary;
        public Color Secondary;
        public Color Muted;

        public Color AccentPrimary;
        public Color AccentSecondary;
        public Color AccentMuted;

        #region Static Text Colors
        public Color DarkBase
        {
            get
            {
                return Color.FromArgb((int)(255 * 1.0), 0, 0, 0);
            }
        }
        public Color DarkDivider
        {
            get
            {
                return Color.FromArgb((int)(255 * .12), 0, 0, 0);
            }
        }
        public Color DarkHint
        {
            get
            {
                return Color.FromArgb((int)(255 * .26), 0, 0, 0);
            }
        }
        public Color DarkSecondary
        {
            get
            {
                return Color.FromArgb((int)(255 * .54), 0, 0, 0);
            }
        }
        public Color DarkText
        {
            get
            {
                return Color.FromArgb((int)(255 * .87), 0, 0, 0);
            }
        }

        public Color LightBase
        {
            get
            {
                return Color.FromArgb((int)(255 * 1.0), 255, 255, 255);
            }
        }
        public Color LightDivider
        {
            get
            {
                return Color.FromArgb((int)(255 * .12), 255, 255, 255);
            }
        }
        public Color LightHint
        {
            get
            {
                return Color.FromArgb((int)(255 * .26), 255, 255, 255);
            }
        }
        public Color LightSecondary
        {
            get
            {
                return Color.FromArgb((int)(255 * .54), 255, 255, 255);
            }
        }
        public Color LightText
        {
            get
            {
                return Color.FromArgb((int)(255 * .87), 255, 255, 255);
            }
        }
        #endregion
    }
}
