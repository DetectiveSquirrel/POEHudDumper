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
            a = new EmptyNode();
            b = new EmptyNode();
            c = new EmptyNode();
            d = new EmptyNode();
            e = new EmptyNode();
            f = new EmptyNode();
            g = new EmptyNode();
            i = new EmptyNode();
            j = new EmptyNode();
            m = new EmptyNode();
            o = new EmptyNode();
            p = new EmptyNode();
            r = new EmptyNode();
            s = new EmptyNode();
            t = new EmptyNode();
            u = new EmptyNode();
            x = new EmptyNode();

            act = true;
            ais = true;
            amd = true;
            ao = true;
            aoc = true;
            arm = true;
            ast = true;
            atlas = true;
            bank = true;
            bat = true;
            cfg = true;
            cht = true;
            clt = true;
            dat = true;
            dct = true;
            dds = true;
            ddt = true;
            dgr = true;
            dlp = true;
            ecf = true;
            env = true;
            epk = true;
            et = true;
            ffx = true;
            fmt = true;
            fx = true;
            gft = true;
            gt = true;
            idl = true;
            idt = true;
            jpeg = true;
            jpg = true;
            mat = true;
            mb = true;
            mel = true;
            mtd = true;
            mtp = true;
            ogg = true;
            ogg2d = true;
            oggsg = true;
            ot = true;
            otc = true;
            pet = true;
            pjd = true;
            png = true;
            properties = true;
            psg = true;
            red = true;
            rs = true;
            rtf = true;
            slt = true;
            sm = true;
            smd = true;
            tdt = true;
            tgm = true;
            tgr = true;
            tgt = true;
            tmd = true;
            trl = true;
            tsi = true;
            tst = true;
            ttf = true;
            txt = true;
            ui = true;
            xls = true;
            xml = true;
        }

        [Menu("Dump Preload Data", 11)]
        public ToggleNode DumpPreloadData { get; set; }


        [Menu("File Extensions", 12)]
        public EmptyNode FileExtensions { get; set; }
        [Menu("A => J", 412, 12)]
        public EmptyNode FileExtensionsPart1 { get; set; }
        [Menu("M => X", 413, 12)]
        public EmptyNode FileExtensionsPart2 { get; set; }

        [Menu("A", 21, 412)]
        public EmptyNode a { get; set; }
        [Menu("B", 22, 412)]
        public EmptyNode b { get; set; }
        [Menu("C", 23, 412)]
        public EmptyNode c { get; set; }
        [Menu("D", 24, 412)]
        public EmptyNode d { get; set; }
        [Menu("E", 25, 412)]
        public EmptyNode e { get; set; }
        [Menu("F", 26, 412)]
        public EmptyNode f { get; set; }
        [Menu("G", 27, 412)]
        public EmptyNode g { get; set; }
        [Menu("I", 28, 412)]
        public EmptyNode i { get; set; }
        [Menu("J", 29, 412)]
        public EmptyNode j { get; set; }

        [Menu("M", 210, 413)]
        public EmptyNode m { get; set; }
        [Menu("O", 211, 413)]
        public EmptyNode o { get; set; }
        [Menu("P", 212, 413)]
        public EmptyNode p { get; set; }
        [Menu("R", 213, 413)]
        public EmptyNode r { get; set; }
        [Menu("S", 214, 413)]
        public EmptyNode s { get; set; }
        [Menu("T", 215, 413)]
        public EmptyNode t { get; set; }
        [Menu("U", 216, 413)]
        public EmptyNode u { get; set; }
        [Menu("X", 217, 413)]
        public EmptyNode x { get; set; }

        [Menu(".act", 3211, 21)]
        public ToggleNode act { get; set; }
        [Menu(".ais", 3212, 21)]
        public ToggleNode ais { get; set; }
        [Menu(".amd", 3213, 21)]
        public ToggleNode amd { get; set; }
        [Menu(".ao", 3214, 21)]
        public ToggleNode ao { get; set; }
        [Menu(".aoc", 3215, 21)]
        public ToggleNode aoc { get; set; }
        [Menu(".arm", 3216, 21)]
        public ToggleNode arm { get; set; }
        [Menu(".ast", 3217, 21)]
        public ToggleNode ast { get; set; }
        [Menu(".atlas", 3218, 21)]
        public ToggleNode atlas { get; set; }

        [Menu(".bank", 3221, 22)]
        public ToggleNode bank { get; set; }
        [Menu(".bat", 3222, 22)]
        public ToggleNode bat { get; set; }

        [Menu(".cfg", 3231, 23)]
        public ToggleNode cfg { get; set; }
        [Menu(".cht", 3232, 23)]
        public ToggleNode cht { get; set; }
        [Menu(".clt", 3233, 23)]
        public ToggleNode clt { get; set; }

        [Menu(".dat", 3241, 24)]
        public ToggleNode dat { get; set; }
        [Menu(".dct", 3242, 24)]
        public ToggleNode dct { get; set; }
        [Menu(".dds", 3243, 24)]
        public ToggleNode dds { get; set; }
        [Menu(".ddt", 3244, 24)]
        public ToggleNode ddt { get; set; }
        [Menu(".dgr", 3245, 24)]
        public ToggleNode dgr { get; set; }
        [Menu(".dlp", 3246, 24)]
        public ToggleNode dlp { get; set; }

        [Menu(".ecf", 3251, 25)]
        public ToggleNode ecf { get; set; }
        [Menu(".env", 3252, 25)]
        public ToggleNode env { get; set; }
        [Menu(".epk", 3253, 25)]
        public ToggleNode epk { get; set; }
        [Menu(".et", 3254, 25)]
        public ToggleNode et { get; set; }

        [Menu(".ffx", 3261, 26)]
        public ToggleNode ffx { get; set; }
        [Menu(".fmt", 3262, 26)]
        public ToggleNode fmt { get; set; }
        [Menu(".fx", 3263, 26)]
        public ToggleNode fx { get; set; }

        [Menu(".gft", 3271, 27)]
        public ToggleNode gft { get; set; }
        [Menu(".gt", 3272, 27)]
        public ToggleNode gt { get; set; }

        [Menu(".idl", 3281, 28)]
        public ToggleNode idl { get; set; }
        [Menu(".idt", 3282, 28)]
        public ToggleNode idt { get; set; }

        [Menu(".jpeg", 3291, 29)]
        public ToggleNode jpeg { get; set; }
        [Menu(".jpg", 3292, 29)]
        public ToggleNode jpg { get; set; }

        [Menu(".mat", 32101, 210)]
        public ToggleNode mat { get; set; }
        [Menu(".mb", 32102, 210)]
        public ToggleNode mb { get; set; }
        [Menu(".mel", 32103, 210)]
        public ToggleNode mel { get; set; }
        [Menu(".mtd", 32104, 210)]
        public ToggleNode mtd { get; set; }
        [Menu(".mtp", 32105, 210)]
        public ToggleNode mtp { get; set; }

        [Menu(".ogg", 32111, 211)]
        public ToggleNode ogg { get; set; }
        [Menu(".ogg2d", 32112, 211)]
        public ToggleNode ogg2d { get; set; }
        [Menu(".oggsg", 32113, 211)]
        public ToggleNode oggsg { get; set; }
        [Menu(".ot", 32114, 211)]
        public ToggleNode ot { get; set; }
        [Menu(".otc", 32115, 211)]
        public ToggleNode otc { get; set; }

        [Menu(".pet", 32121, 212)]
        public ToggleNode pet { get; set; }
        [Menu(".pjd", 32122, 212)]
        public ToggleNode pjd { get; set; }
        [Menu(".png", 32123, 212)]
        public ToggleNode png { get; set; }
        [Menu(".properties", 32124, 212)]
        public ToggleNode properties { get; set; }
        [Menu(".psg", 32125, 212)]
        public ToggleNode psg { get; set; }

        [Menu(".red", 32131, 213)]
        public ToggleNode red { get; set; }
        [Menu(".rs", 32132, 213)]
        public ToggleNode rs { get; set; }
        [Menu(".rtf", 32133, 213)]
        public ToggleNode rtf { get; set; }

        [Menu(".slt", 32141, 214)]
        public ToggleNode slt { get; set; }
        [Menu(".sm", 32142, 214)]
        public ToggleNode sm { get; set; }
        [Menu(".smd", 32143, 214)]
        public ToggleNode smd { get; set; }

        [Menu(".tdt", 32151, 215)]
        public ToggleNode tdt { get; set; }
        [Menu(".tgm", 32152, 215)]
        public ToggleNode tgm { get; set; }
        [Menu(".tgr", 32153, 215)]
        public ToggleNode tgr { get; set; }
        [Menu(".tgt", 32154, 215)]
        public ToggleNode tgt { get; set; }
        [Menu(".tmd", 32155, 215)]
        public ToggleNode tmd { get; set; }
        [Menu(".trl", 32156, 215)]
        public ToggleNode trl { get; set; }
        [Menu(".tsi", 32157, 215)]
        public ToggleNode tsi { get; set; }
        [Menu(".tst", 32158, 215)]
        public ToggleNode tst { get; set; }
        [Menu(".ttf", 32159, 215)]
        public ToggleNode ttf { get; set; }
        [Menu(".txt", 321510, 215)]
        public ToggleNode txt { get; set; }

        [Menu(".ui", 32161, 216)]
        public ToggleNode ui { get; set; }

        [Menu(".xls", 32171, 217)]
        public ToggleNode xls { get; set; }
        [Menu(".xml", 32172, 217)]
        public ToggleNode xml { get; set; }

    }
}
