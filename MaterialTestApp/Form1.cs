using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialTestApp
{
    public partial class Form1 : xMaterialForms.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            this.charm1.Icon = xMaterialIcons.Navigation.arrow_back_black_48dp;
        }
    }
}
