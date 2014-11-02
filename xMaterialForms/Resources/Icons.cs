using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace xMaterialForms.Resources
{
    public static class Icons
    {
        private static Assembly thisAssembly = Assembly.GetExecutingAssembly();

        public static Image Get(string name)
        {
            return Image.FromStream(
                        thisAssembly.GetManifestResourceStream(
                            String.Format("{0}.{1}", "xMaterialForms", name)
                            )
                        );
        }
    }
}
