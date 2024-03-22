using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.App
{
    internal class Configs
    {
        public static void Setup()
        {
            if (!Directory.Exists(AppDirs.LocalFolder))
            {
                try
                {
                    Directory.CreateDirectory(AppDirs.LocalFolder);
                }
                catch (Exception ex) { MsgBox.Error($"Failed to create Soundify Folder\n\n{ex}"); }

                if (Directory.Exists(AppDirs.LocalFolder))
                {
                    try
                    {
                        Directory.CreateDirectory(AppDirs.MiscFolder);
                        Directory.CreateDirectory(AppDirs.LogsFolder);
                        Directory.CreateDirectory(AppDirs.ConfigFolder);
                    }
                    catch { MsgBox.Error($"Soundify failed to make folders in AppData directory."); }
                }
            }
        }

        public static void Load()
        {
            string defaultjson =
            @"{
              ""OscName"": ""Soundify"",
              ""OSCInt"": 1500,
              ""DRPC"": true,
              ""CustomURLs"": false,
              ""ReadMe"" : ""This isn't used right now I have to setup later""
            }";

            if (!File.Exists(AppDirs.ConfigFolder + "\\Main.json"))
            {
                File.WriteAllText(AppDirs.ConfigFolder + "\\Main.json", defaultjson);
            }
        }

        public static void Save()
        {
            //To do
        }
    }
}
