using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xMaterialControls.Material;

namespace xMaterialControls
{
    public partial class ThemedControl : UserControl
    {
        private Material.Theme theme = Material.Themes.Default;
        private bool brightText = false;
        private Color foreColorOverride = Color.White;
        private bool overrideForeColor = false;
        private TextColorType textColorType = TextColorType.Text;

        [CategoryAttribute("Material")]
        public Material.Theme Theme
        {
            get
            {
                if (this.theme == null)
                    this.theme = Material.Themes.Default;

                return this.theme;
            }
            set
            {
                if (value != null)
                {
                    this.theme = value;
                    this.Invalidate();
                }
            }
        }

        [CategoryAttribute("Material")]
        public bool WhiteText
        {
            get
            {
                return this.brightText;
            }
            set
            {
                this.brightText = value;
                this.Invalidate();
            }
        }


        [CategoryAttribute("Material")]
        public TextColorType TextType
        {
            get
            {
                return this.textColorType;
            }
            set
            {
                this.textColorType = value;
                this.Invalidate();
            }
        }

        public ThemedControl()
        {
            InitializeComponent();
        }

        public override Color BackColor
        {
            get
            {
                return Theme.Background;
            }
            set
            {
                Theme.Background = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                if (this.overrideForeColor)
                {
                    return this.foreColorOverride;
                }
                else
                {
                    if (this.brightText)
                    {
                        switch (this.textColorType)
                        {
                            case TextColorType.Secondary:
                                return this.Theme.LightSecondary;
                            case TextColorType.Hint:
                                return this.Theme.LightHint;
                            case TextColorType.Full:
                                return this.Theme.LightBase;
                            case TextColorType.Divider:
                                return this.Theme.LightDivider;
                            default:
                            case TextColorType.Text:
                                return this.Theme.LightText;
                        }
                    }
                    else
                    {
                        switch (this.textColorType)
                        {
                            case TextColorType.Secondary:
                                return this.Theme.DarkSecondary;
                            case TextColorType.Hint:
                                return this.Theme.DarkHint;
                            case TextColorType.Full:
                                return this.Theme.DarkBase;
                            case TextColorType.Divider:
                                return this.Theme.DarkDivider;
                            default:
                            case TextColorType.Text:
                                return this.Theme.DarkText;
                        }
                    }
                }
            }
            set
            {
                base.ForeColor = value;
            }
        }
    }
}
