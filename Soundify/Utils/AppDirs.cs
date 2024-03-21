using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.Utils
{
    internal class AppDirs
    {
        //Directories
        public static string LocalFolder { get; } =
        $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow")}\\{Info.Name}";
        public static string ConfigFolder { get; } = $"{LocalFolder}\\Configs";
        public static string LogsFolder { get; } = $"{LocalFolder}\\Logs";
        public static string MiscFolder { get; } = $"{LocalFolder}\\Misc";
    }
}
