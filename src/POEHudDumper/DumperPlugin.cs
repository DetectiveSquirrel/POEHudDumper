using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            string Time = DateTime.Now.ToString("hh.mm.ss tt");
            string Area = GameController.Area.CurrentArea.DisplayName;
            string FileLocation = "Preload Dumps / " + Date + " / " + Area;
            string TxtFile = FileLocation + "/" + Time + " " + Area + ".txt";
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

                if (text.Contains('@')) { text = text.Split('@')[0]; }

                if (CheckExtension(text))
                {
                    PreloadDump.Append(text);
                    PreloadDump.Append(Environment.NewLine);
                }

            }

            List<string> items = new List<string>(PreloadDump.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            items.Sort();
            PreloadDump = new StringBuilder(string.Join("\r\n", items.ToArray()));

            File.WriteAllText(TxtFile, PreloadDump.ToString());
        }

        private bool CheckExtension(string text)
        {
            if (text.Contains(".amd") && !Settings.amd) { return false; }
            if (text.Contains(".ao") && !Settings.ao) { return false; }
            if (text.Contains(".arm") && !Settings.arm) { return false; }
            if (text.Contains(".ast") && !Settings.ast) { return false; }
            if (text.Contains(".bank") && !Settings.bank) { return false; }
            if (text.Contains(".dat") && !Settings.dat) { return false; }
            if (text.Contains(".dds") && !Settings.dds) { return false; }
            if (text.Contains(".ddt") && !Settings.ddt) { return false; }
            if (text.Contains(".dgr") && !Settings.dgr) { return false; }
            if (text.Contains(".dlp") && !Settings.dlp) { return false; }
            if (text.Contains(".ecf") && !Settings.ecf) { return false; }
            if (text.Contains(".env") && !Settings.env) { return false; }
            if (text.Contains(".epk") && !Settings.epk) { return false; }
            if (text.Contains(".et") && !Settings.et) { return false; }
            if (text.Contains(".fmt") && !Settings.fmt) { return false; }
            if (text.Contains(".gft") && !Settings.gft) { return false; }
            if (text.Contains(".gt") && !Settings.gt) { return false; }
            if (text.Contains(".mat") && !Settings.mat) { return false; }
            if (text.Contains(".mtd") && !Settings.mtd) { return false; }
            if (text.Contains(".mtp") && !Settings.mtp) { return false; }
            if (text.Contains(".ogg") && !Settings.ogg) { return false; }
            if (text.Contains(".ogg2d") && !Settings.ogg2d) { return false; }
            if (text.Contains(".oggsg") && !Settings.oggsg) { return false; }
            if (text.Contains(".pet") && !Settings.pet) { return false; }
            if (text.Contains(".pjd") && !Settings.pjd) { return false; }
            if (text.Contains(".psg") && !Settings.psg) { return false; }
            if (text.Contains(".rs") && !Settings.rs) { return false; }
            if (text.Contains(".sm") && !Settings.sm) { return false; }
            if (text.Contains(".smd") && !Settings.smd) { return false; }
            if (text.Contains(".tdt") && !Settings.tdt) { return false; }
            if (text.Contains(".tgm") && !Settings.tgm) { return false; }
            if (text.Contains(".tgt") && !Settings.tgt) { return false; }
            if (text.Contains(".tmd") && !Settings.tmd) { return false; }
            if (text.Contains(".trl") && !Settings.trl) { return false; }
            if (text.Contains(".tsi") && !Settings.tsi) { return false; }
            if (text.Contains(".tst") && !Settings.tst) { return false; }
            if (text.Contains(".ttf") && !Settings.ttf) { return false; }
            if (text.Contains(".txt") && !Settings.txt) { return false; }

            return true;
        }
    }
}
