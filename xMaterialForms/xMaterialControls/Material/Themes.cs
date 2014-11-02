using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xMaterialControls.Material
{
    public sealed class Themes
    {
        public static Theme Default = new Theme()
        {
            Primary = Palettes.Indigo.c500,
            Secondary = Palettes.Indigo.c700,
            Muted = Palettes.Indigo.c100,
            AccentPrimary = Palettes.Pink.A100,
            AccentSecondary = Palettes.Pink.A400,
            AccentMuted = Palettes.Pink.c50
        };
    }
}
