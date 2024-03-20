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
        public static string[] Directories { get; } =
        [
            $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming","LocalLow")}", //Local
            $"{Environment.GetFolderPath
              (
                Environment.SpecialFolder.ApplicationData
              ).Replace("Roaming","LocalLow")}\\{Info.Name}", //Soundify local
            $"{Directory.GetCurrentDirectory()}"
        ];
    }
}
