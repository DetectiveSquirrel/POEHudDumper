using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace POEHudDumper
{

    public sealed class DumperSettings : SettingsBase
    {
        public DumperSettings()
        {
            DumpPreloadData = false;
            FileExtensions = new EmptyNode();
            FileExtensionsPart1 = new EmptyNode();
            FileExtensionsPart2 = new EmptyNode();
            A = new EmptyNode();
            B = new EmptyNode();
            C = new EmptyNode();
            D = new EmptyNode();
            E = new EmptyNode();
            F = new EmptyNode();
            G = new EmptyNode();
            I = new EmptyNode();
            J = new EmptyNode();
            M = new EmptyNode();
            O = new EmptyNode();
            P = new EmptyNode();
            R = new EmptyNode();
            S = new EmptyNode();
            T = new EmptyNode();
            U = new EmptyNode();
            X = new EmptyNode();

            Act = true;
            Ais = true;
            Amd = true;
            Ao = true;
            Aoc = true;
            Arm = true;
            Ast = true;
            Atlas = true;
            Bank = true;
            Bat = true;
            Cfg = true;
            Cht = true;
            Clt = true;
            Dat = true;
            Dct = true;
            Dds = true;
            Ddt = true;
            Dgr = true;
            Dlp = true;
            Ecf = true;
            Env = true;
            Epk = true;
            Et = true;
            Ffx = true;
            Fmt = true;
            Fx = true;
            Gft = true;
            Gt = true;
            Idl = true;
            Idt = true;
            Jpeg = true;
            Jpg = true;
            Mat = true;
            Mb = true;
            Mel = true;
            Mtd = true;
            Mtp = true;
            Ogg = true;
            Ogg2D = true;
            Oggsg = true;
            Ot = true;
            Otc = true;
            Pet = true;
            Pjd = true;
            Png = true;
            Properties = true;
            Psg = true;
            Red = true;
            Rs = true;
            Rtf = true;
            Slt = true;
            Sm = true;
            Smd = true;
            Tdt = true;
            Tgm = true;
            Tgr = true;
            Tgt = true;
            Tmd = true;
            Trl = true;
            Tsi = true;
            Tst = true;
            Ttf = true;
            Txt = true;
            Ui = true;
            Xls = true;
            Xml = true;
        }

        [Menu("Dump Preload Data", 11)]
        public ToggleNode DumpPreloadData { get; set; }


        public EmptyNode FileExtensions { get; set; }
        [Menu("File Extensions [A - J]", 12)]
        public EmptyNode FileExtensionsPart1 { get; set; }
        [Menu("File Extensions [M - X]", 13)]
        public EmptyNode FileExtensionsPart2 { get; set; }

        [Menu("A", 21, 12)]
        public EmptyNode A { get; set; }
        [Menu("B", 22, 12)]
        public EmptyNode B { get; set; }
        [Menu("C", 23, 12)]
        public EmptyNode C { get; set; }
        [Menu("D", 24, 12)]
        public EmptyNode D { get; set; }
        [Menu("E", 25, 12)]
        public EmptyNode E { get; set; }
        [Menu("F", 26, 12)]
        public EmptyNode F { get; set; }
        [Menu("G", 27, 12)]
        public EmptyNode G { get; set; }
        [Menu("I", 28, 12)]
        public EmptyNode I { get; set; }
        [Menu("J", 29, 12)]
        public EmptyNode J { get; set; }

        [Menu("M", 210, 13)]
        public EmptyNode M { get; set; }
        [Menu("O", 211, 13)]
        public EmptyNode O { get; set; }
        [Menu("P", 212, 13)]
        public EmptyNode P { get; set; }
        [Menu("R", 213, 13)]
        public EmptyNode R { get; set; }
        [Menu("S", 214, 13)]
        public EmptyNode S { get; set; }
        [Menu("T", 215, 13)]
        public EmptyNode T { get; set; }
        [Menu("U", 216, 13)]
        public EmptyNode U { get; set; }
        [Menu("X", 217, 13)]
        public EmptyNode X { get; set; }

        [Menu(".act", 3211, 21)]
        public ToggleNode Act { get; set; }
        [Menu(".ais", 3212, 21)]
        public ToggleNode Ais { get; set; }
        [Menu(".amd", 3213, 21)]
        public ToggleNode Amd { get; set; }
        [Menu(".ao", 3214, 21)]
        public ToggleNode Ao { get; set; }
        [Menu(".aoc", 3215, 21)]
        public ToggleNode Aoc { get; set; }
        [Menu(".arm", 3216, 21)]
        public ToggleNode Arm { get; set; }
        [Menu(".ast", 3217, 21)]
        public ToggleNode Ast { get; set; }
        [Menu(".atlas", 3218, 21)]
        public ToggleNode Atlas { get; set; }

        [Menu(".bank", 3221, 22)]
        public ToggleNode Bank { get; set; }
        [Menu(".bat", 3222, 22)]
        public ToggleNode Bat { get; set; }

        [Menu(".cfg", 3231, 23)]
        public ToggleNode Cfg { get; set; }
        [Menu(".cht", 3232, 23)]
        public ToggleNode Cht { get; set; }
        [Menu(".clt", 3233, 23)]
        public ToggleNode Clt { get; set; }

        [Menu(".dat", 3241, 24)]
        public ToggleNode Dat { get; set; }
        [Menu(".dct", 3242, 24)]
        public ToggleNode Dct { get; set; }
        [Menu(".dds", 3243, 24)]
        public ToggleNode Dds { get; set; }
        [Menu(".ddt", 3244, 24)]
        public ToggleNode Ddt { get; set; }
        [Menu(".dgr", 3245, 24)]
        public ToggleNode Dgr { get; set; }
        [Menu(".dlp", 3246, 24)]
        public ToggleNode Dlp { get; set; }

        [Menu(".ecf", 3251, 25)]
        public ToggleNode Ecf { get; set; }
        [Menu(".env", 3252, 25)]
        public ToggleNode Env { get; set; }
        [Menu(".epk", 3253, 25)]
        public ToggleNode Epk { get; set; }
        [Menu(".et", 3254, 25)]
        public ToggleNode Et { get; set; }

        [Menu(".ffx", 3261, 26)]
        public ToggleNode Ffx { get; set; }
        [Menu(".fmt", 3262, 26)]
        public ToggleNode Fmt { get; set; }
        [Menu(".fx", 3263, 26)]
        public ToggleNode Fx { get; set; }

        [Menu(".gft", 3271, 27)]
        public ToggleNode Gft { get; set; }
        [Menu(".gt", 3272, 27)]
        public ToggleNode Gt { get; set; }

        [Menu(".idl", 3281, 28)]
        public ToggleNode Idl { get; set; }
        [Menu(".idt", 3282, 28)]
        public ToggleNode Idt { get; set; }

        [Menu(".jpeg", 3291, 29)]
        public ToggleNode Jpeg { get; set; }
        [Menu(".jpg", 3292, 29)]
        public ToggleNode Jpg { get; set; }

        [Menu(".mat", 32101, 210)]
        public ToggleNode Mat { get; set; }
        [Menu(".mb", 32102, 210)]
        public ToggleNode Mb { get; set; }
        [Menu(".mel", 32103, 210)]
        public ToggleNode Mel { get; set; }
        [Menu(".mtd", 32104, 210)]
        public ToggleNode Mtd { get; set; }
        [Menu(".mtp", 32105, 210)]
        public ToggleNode Mtp { get; set; }

        [Menu(".ogg", 32111, 211)]
        public ToggleNode Ogg { get; set; }
        [Menu(".ogg2d", 32112, 211)]
        public ToggleNode Ogg2D { get; set; }
        [Menu(".oggsg", 32113, 211)]
        public ToggleNode Oggsg { get; set; }
        [Menu(".ot", 32114, 211)]
        public ToggleNode Ot { get; set; }
        [Menu(".otc", 32115, 211)]
        public ToggleNode Otc { get; set; }

        [Menu(".pet", 32121, 212)]
        public ToggleNode Pet { get; set; }
        [Menu(".pjd", 32122, 212)]
        public ToggleNode Pjd { get; set; }
        [Menu(".png", 32123, 212)]
        public ToggleNode Png { get; set; }
        [Menu(".properties", 32124, 212)]
        public ToggleNode Properties { get; set; }
        [Menu(".psg", 32125, 212)]
        public ToggleNode Psg { get; set; }

        [Menu(".red", 32131, 213)]
        public ToggleNode Red { get; set; }
        [Menu(".rs", 32132, 213)]
        public ToggleNode Rs { get; set; }
        [Menu(".rtf", 32133, 213)]
        public ToggleNode Rtf { get; set; }

        [Menu(".slt", 32141, 214)]
        public ToggleNode Slt { get; set; }
        [Menu(".sm", 32142, 214)]
        public ToggleNode Sm { get; set; }
        [Menu(".smd", 32143, 214)]
        public ToggleNode Smd { get; set; }

        [Menu(".tdt", 32151, 215)]
        public ToggleNode Tdt { get; set; }
        [Menu(".tgm", 32152, 215)]
        public ToggleNode Tgm { get; set; }
        [Menu(".tgr", 32153, 215)]
        public ToggleNode Tgr { get; set; }
        [Menu(".tgt", 32154, 215)]
        public ToggleNode Tgt { get; set; }
        [Menu(".tmd", 32155, 215)]
        public ToggleNode Tmd { get; set; }
        [Menu(".trl", 32156, 215)]
        public ToggleNode Trl { get; set; }
        [Menu(".tsi", 32157, 215)]
        public ToggleNode Tsi { get; set; }
        [Menu(".tst", 32158, 215)]
        public ToggleNode Tst { get; set; }
        [Menu(".ttf", 32159, 215)]
        public ToggleNode Ttf { get; set; }
        [Menu(".txt", 321510, 215)]
        public ToggleNode Txt { get; set; }

        [Menu(".ui", 32161, 216)]
        public ToggleNode Ui { get; set; }

        [Menu(".xls", 32171, 217)]
        public ToggleNode Xls { get; set; }
        [Menu(".xml", 32172, 217)]
        public ToggleNode Xml { get; set; }

    }
}
