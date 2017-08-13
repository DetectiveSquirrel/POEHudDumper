using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEHudDumper
{
    public class DumperPlugin : BaseSettingsPlugin<DumperSettings>
    {
        public override void Initialise()
        {
            GameController.Area.OnAreaChange += OnAreaChange;
        }

        private void OnAreaChange(AreaController area)
        {
            if (Settings.DumpPreloadData)
                Parse();
        }

        private void Parse()
        {
            Memory memory = GameController.Memory;
            long pFileRoot = memory.AddressOfProcess + memory.offsets.FileRoot;
            int count = memory.ReadInt(pFileRoot + 0x10); // check how many files are loaded

            int areaChangeCount = GameController.Game.AreaChangeCount;
            long listIterator = memory.ReadLong(pFileRoot + 0x8, 0x0);

            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string Time = DateTime.Now.ToString("h-mm-ss tt");
            string Area = GameController.Area.CurrentArea.DisplayName.ToString();
            string FileLocation = "Preload Dumps / " + Date + " / " + Area;
            string TxtFile = FileLocation + "/" + Time + " - Collected Preloads.txt";
            Directory.CreateDirectory(FileLocation);
            File.Create(TxtFile);
            StringBuilder PreloadDump = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                listIterator = memory.ReadLong(listIterator);
                if (listIterator == 0)
                {
                    //MessageBox.Show("address is null, something has gone wrong, start over");
                    // address is null, something has gone wrong, start over
                    return;
                }
                if (memory.ReadLong(listIterator + 0x10) == 0 || memory.ReadInt(listIterator + 0x18, 0x50) != areaChangeCount)
                {
                    continue;
                }
                
                string text = memory.ReadStringU(memory.ReadLong(listIterator + 0x10), 512);

                PreloadDump.Append(text);
                PreloadDump.Append(Environment.NewLine);

            }

            List<string> items = new List<string>(PreloadDump.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            items.Sort();
            PreloadDump = new StringBuilder(string.Join("\r\n", items.ToArray()));

            File.WriteAllText(TxtFile, PreloadDump.ToString());
        }
    }
}
