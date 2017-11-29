using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PoeHUD.Controllers;
using PoeHUD.Plugins;

namespace POEHudDumper
{
    public class DumperPlugin : BaseSettingsPlugin<DumperSettings>
    {
        public bool FileInUse;

        public override void Initialise()
        {
            GameController.Area.OnAreaChange += OnAreaChange;
        }

        private void OnAreaChange(AreaController area)
        {
            if (!Settings.DumpPreloadData) return;
            if (!FileInUse)
                Parse();
        }

        private void Parse()
        {
            FileInUse = true;
            var memory = GameController.Memory;
            var pFileRoot = memory.AddressOfProcess + memory.offsets.FileRoot;
            var count = memory.ReadInt(pFileRoot + 0x10); // check how many files are loaded

            var areaChangeCount = GameController.Game.AreaChangeCount;
            var listIterator = memory.ReadLong(pFileRoot + 0x8, 0x0);

            var date = DateTime.Now.ToString("dd-MM-yyyy");
            var time = DateTime.Now.ToString("hh.mm.ss tt");
            var area = GameController.Area.CurrentArea.DisplayName;
            var fileLocation = "Preload Dumps/" + date + "/" + area;
            var txtFile = fileLocation + "/" + time + " " + area + ".txt";
            Directory.CreateDirectory(fileLocation);
            var preloadDump = new StringBuilder();

            for (var i = 0; i < count; i++)
            {
                listIterator = memory.ReadLong(listIterator);
                if (listIterator == 0)
                    return;
                if (memory.ReadLong(listIterator + 0x10) == 0 ||
                    memory.ReadInt(listIterator + 0x18, 0x50) != areaChangeCount)
                    continue;

                var text = memory.ReadStringU(memory.ReadLong(listIterator + 0x10), 512);

                if (text.Contains('@')) text = text.Split('@')[0];

                if (!CheckExtension(text)) continue;
                preloadDump.Append(text);
                preloadDump.Append(Environment.NewLine);
            }

            var items = new List<string>(preloadDump.ToString()
                .Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries));
            items.Sort();
            preloadDump = new StringBuilder(string.Join("\r\n", items.ToArray()));

            try
            {
                File.WriteAllText(txtFile, preloadDump.ToString());
            }
            catch
            {
                LogError("Preload Dumper: Error writing to file, in use perhaps.", 10);
            }

            FileInUse = false;
        }

        private bool CheckExtension(string text)
        {
            if (text.Contains(".act") && !Settings.Act) return false;
            if (text.Contains(".ais") && !Settings.Ais) return false;
            if (text.Contains(".amd") && !Settings.Amd) return false;
            if (text.Contains(".ao") && !Settings.Ao) return false;
            if (text.Contains(".aoc") && !Settings.Aoc) return false;
            if (text.Contains(".arm") && !Settings.Arm) return false;
            if (text.Contains(".ast") && !Settings.Ast) return false;
            if (text.Contains(".atlas") && !Settings.Atlas) return false;
            if (text.Contains(".bank") && !Settings.Bank) return false;
            if (text.Contains(".bat") && !Settings.Bat) return false;
            if (text.Contains(".cfg") && !Settings.Cfg) return false;
            if (text.Contains(".cht") && !Settings.Cht) return false;
            if (text.Contains(".clt") && !Settings.Clt) return false;
            if (text.Contains(".dat") && !Settings.Dat) return false;
            if (text.Contains(".dct") && !Settings.Dct) return false;
            if (text.Contains(".dds") && !Settings.Dds) return false;
            if (text.Contains(".ddt") && !Settings.Ddt) return false;
            if (text.Contains(".dgr") && !Settings.Dgr) return false;
            if (text.Contains(".dlp") && !Settings.Dlp) return false;
            if (text.Contains(".ecf") && !Settings.Ecf) return false;
            if (text.Contains(".env") && !Settings.Env) return false;
            if (text.Contains(".epk") && !Settings.Epk) return false;
            if (text.Contains(".et") && !Settings.Et) return false;
            if (text.Contains(".ffx") && !Settings.Ffx) return false;
            if (text.Contains(".fmt") && !Settings.Fmt) return false;
            if (text.Contains(".fx") && !Settings.Fx) return false;
            if (text.Contains(".gft") && !Settings.Gft) return false;
            if (text.Contains(".gt") && !Settings.Gt) return false;
            if (text.Contains(".idl") && !Settings.Idl) return false;
            if (text.Contains(".idt") && !Settings.Idt) return false;
            if (text.Contains(".jpeg") && !Settings.Jpeg) return false;
            if (text.Contains(".jpg") && !Settings.Jpg) return false;
            if (text.Contains(".mat") && !Settings.Mat) return false;
            if (text.Contains(".mb") && !Settings.Mb) return false;
            if (text.Contains(".mel") && !Settings.Mel) return false;
            if (text.Contains(".mtd") && !Settings.Mtd) return false;
            if (text.Contains(".mtp") && !Settings.Mtp) return false;
            if (text.Contains(".ogg") && !Settings.Ogg) return false;
            if (text.Contains(".ogg2d") && !Settings.Ogg2D) return false;
            if (text.Contains(".oggsg") && !Settings.Oggsg) return false;
            if (text.Contains(".ot") && !Settings.Ot) return false;
            if (text.Contains(".otc") && !Settings.Otc) return false;
            if (text.Contains(".pet") && !Settings.Pet) return false;
            if (text.Contains(".pjd") && !Settings.Pjd) return false;
            if (text.Contains(".png") && !Settings.Png) return false;
            if (text.Contains(".properties") && !Settings.Properties) return false;
            if (text.Contains(".psg") && !Settings.Psg) return false;
            if (text.Contains(".red") && !Settings.Red) return false;
            if (text.Contains(".rs") && !Settings.Rs) return false;
            if (text.Contains(".rtf") && !Settings.Rtf) return false;
            if (text.Contains(".slt") && !Settings.Slt) return false;
            if (text.Contains(".sm") && !Settings.Sm) return false;
            if (text.Contains(".smd") && !Settings.Smd) return false;
            if (text.Contains(".tdt") && !Settings.Tdt) return false;
            if (text.Contains(".tgm") && !Settings.Tgm) return false;
            if (text.Contains(".tgr") && !Settings.Tgr) return false;
            if (text.Contains(".tgt") && !Settings.Tgt) return false;
            if (text.Contains(".tmd") && !Settings.Tmd) return false;
            if (text.Contains(".trl") && !Settings.Trl) return false;
            if (text.Contains(".tsi") && !Settings.Tsi) return false;
            if (text.Contains(".tst") && !Settings.Tst) return false;
            if (text.Contains(".ttf") && !Settings.Ttf) return false;
            if (text.Contains(".txt") && !Settings.Txt) return false;
            if (text.Contains(".ui") && !Settings.Ui) return false;
            if (text.Contains(".xls") && !Settings.Xls) return false;
            return !text.Contains(".xml") || Settings.Xml;
        }
    }
}