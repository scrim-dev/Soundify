using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.App
{
    internal class SaveLogs
    {
        public static void Save()
        {
            try
            {
                File.WriteAllText(AppDirs.LogsFolder + 
                    $"\\Logs-{DateTime.Now.ToString("d_HH_ss_mm").Replace("/", "_")}", 
                    FormConsole.RTB.Text);
            }
            catch { }
        }
    }
}
