using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xMaterialControls
{
    public partial class Charm : UserControl
    {
        private Image icon = null;
        private string icon_name = null;
        private Rectangle rect = new Rectangle(0, 0, 48, 48);

        [CategoryAttribute("Material")]
        public Image Icon
        {
            get
            {
                return this.icon;
            }
            set
            {
                this.icon = value;
                if (this.icon != null)
                {
                    this.Size = this.icon.Size;
                    this.rect = new Rectangle(new Point(0, 0), this.Size);
                    this.Invalidate();
                }
            }
        }

        public Charm()
        {
            InitializeComponent();
        }
        public Charm(Image ic)
            : base()
        {
            Icon = ic;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.icon != null)
            {
                e.Graphics.DrawImage(this.icon, this.rect);
            }
        }
    }
}
