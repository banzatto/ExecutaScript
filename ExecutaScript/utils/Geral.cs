using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutaScript.utils
{
    public class Geral
    {
        public static String getAssemblyVersion()
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            return version.ToString();
        }


    }
}
