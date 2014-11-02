using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xMaterialControls.Material
{
    public sealed class Palettes
    {
        public static Palette Indigo = new Palette()
        {
            c50 = ColorTranslator.FromHtml("#e8eaf6"),
            c100 = ColorTranslator.FromHtml("#c5cae9"),
            c200 = ColorTranslator.FromHtml("#9fa8da"),
            c300 = ColorTranslator.FromHtml("#7986cb"),
            c400 = ColorTranslator.FromHtml("#5c6bc0"),
            c500 = ColorTranslator.FromHtml("#3f51b5"),
            c600 = ColorTranslator.FromHtml("#3949ab"),
            c700 = ColorTranslator.FromHtml("#303f9f"),
            c800 = ColorTranslator.FromHtml("#283593"),
            c900 = ColorTranslator.FromHtml("#1a237e"),

            A100 = ColorTranslator.FromHtml("#8c9eff"),
            A200 = ColorTranslator.FromHtml("#536dfe"),
            A400 = ColorTranslator.FromHtml("#3d5afe"),
            A700 = ColorTranslator.FromHtml("#304ffe")
        };

        public static Palette Pink = new Palette()
        {
            c50 = ColorTranslator.FromHtml("#fce4ec"),
            c100 = ColorTranslator.FromHtml("#f8bbd0"),
            c200 = ColorTranslator.FromHtml("#f48fb1"),
            c300 = ColorTranslator.FromHtml("#f06292"),
            c400 = ColorTranslator.FromHtml("#ec407a"),
            c500 = ColorTranslator.FromHtml("#e91e63"),
            c600 = ColorTranslator.FromHtml("#d81b60"),
            c700 = ColorTranslator.FromHtml("#c2185b"),
            c800 = ColorTranslator.FromHtml("#ad1457"),
            c900 = ColorTranslator.FromHtml("#880e4f"),

            A100 = ColorTranslator.FromHtml("#ff80ab"),
            A200 = ColorTranslator.FromHtml("#ff4081"),
            A400 = ColorTranslator.FromHtml("#f50057"),
            A700 = ColorTranslator.FromHtml("#c51162")
        };
    }
}
