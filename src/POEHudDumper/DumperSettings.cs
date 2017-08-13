using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEHudDumper
{

    public sealed class DumperSettings : SettingsBase
    {
        public DumperSettings()
        {
            DumpPreloadData = false;
        }

        [Menu("Dump Preload Data", 10)]
        public ToggleNode DumpPreloadData { get; set; }

    }
}
