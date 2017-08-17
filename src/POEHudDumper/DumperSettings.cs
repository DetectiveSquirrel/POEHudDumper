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
            a = new EmptyNode();
            b = new EmptyNode();
            d = new EmptyNode();
            e = new EmptyNode();
            f = new EmptyNode();
            g = new EmptyNode();
            m = new EmptyNode();
            o = new EmptyNode();
            p = new EmptyNode();
            r = new EmptyNode();
            s = new EmptyNode();
            t = new EmptyNode();

            amd = true;
            ao = true;
            arm = true;
            ast = true;
            bank = true;
            dat = true;
            dds = true;
            ddt = true;
            dgr = true;
            dlp = true;
            ecf = true;
            env = true;
            epk = true;
            et = true;
            fmt = true;
            gft = true;
            gt = true;
            mat = true;
            mtd = true;
            mtp = true;
            ogg = true;
            ogg2d = true;
            oggsg = true;
            pet = true;
            pjd = true;
            psg = true;
            rs = true;
            sm = true;
            smd = true;
            tdt = true;
            tgm = true;
            tgt = true;
            tmd = true;
            trl = true;
            tsi = true;
            tst = true;
            ttf = true;
            txt = true;
        }

        [Menu("Dump Preload Data", 11)]
        public ToggleNode DumpPreloadData { get; set; }


        [Menu("File Extensions", 12)]
        public EmptyNode FileExtensions { get; set; }

        [Menu("A", 21, 12)]
        public EmptyNode a { get; set; }
        [Menu("B", 22, 12)]
        public EmptyNode b { get; set; }
        [Menu("D", 23, 12)]
        public EmptyNode d { get; set; }
        [Menu("E", 24, 12)]
        public EmptyNode e { get; set; }
        [Menu("F", 25, 12)]
        public EmptyNode f { get; set; }
        [Menu("G", 26, 12)]
        public EmptyNode g { get; set; }
        [Menu("M", 27, 12)]
        public EmptyNode m { get; set; }
        [Menu("O", 28, 12)]
        public EmptyNode o { get; set; }
        [Menu("P", 29, 12)]
        public EmptyNode p { get; set; }
        [Menu("R", 210, 12)]
        public EmptyNode r { get; set; }
        [Menu("S", 211, 12)]
        public EmptyNode s { get; set; }
        [Menu("T", 212, 12)]
        public EmptyNode t { get; set; }

        [Menu(".amd", 3211, 21)]
        public ToggleNode amd { get; set; }
        [Menu(".ao", 3212, 21)]
        public ToggleNode ao { get; set; }
        [Menu(".arm", 3213, 21)]
        public ToggleNode arm { get; set; }
        [Menu(".ast", 3214, 21)]
        public ToggleNode ast { get; set; }

        [Menu(".bank", 3221, 22)]
        public ToggleNode bank { get; set; }

        [Menu(".dat", 3231, 23)]
        public ToggleNode dat { get; set; }
        [Menu(".dds", 3232, 23)]
        public ToggleNode dds { get; set; }
        [Menu(".ddt", 3234, 23)]
        public ToggleNode ddt { get; set; }
        [Menu(".dgr", 3235, 23)]
        public ToggleNode dgr { get; set; }
        [Menu(".dlp", 3236, 23)]
        public ToggleNode dlp { get; set; }

        [Menu(".ecf", 3241, 24)]
        public ToggleNode ecf { get; set; }
        [Menu(".env", 3242, 24)]
        public ToggleNode env { get; set; }
        [Menu(".epk", 3243, 24)]
        public ToggleNode epk { get; set; }
        [Menu(".et", 3244, 24)]
        public ToggleNode et { get; set; }

        [Menu(".fmt", 3251, 25)]
        public ToggleNode fmt { get; set; }

        [Menu(".gft", 3261, 26)]
        public ToggleNode gft { get; set; }
        [Menu(".gt", 3262, 26)]
        public ToggleNode gt { get; set; }

        [Menu(".mat", 3271, 27)]
        public ToggleNode mat { get; set; }
        [Menu(".mtd", 3272, 27)]
        public ToggleNode mtd { get; set; }
        [Menu(".mtp", 3273, 27)]
        public ToggleNode mtp { get; set; }

        [Menu(".ogg", 3281, 28)]
        public ToggleNode ogg { get; set; }
        [Menu(".ogg2d", 3282, 28)]
        public ToggleNode ogg2d { get; set; }
        [Menu(".oggsg", 3283, 28)]
        public ToggleNode oggsg { get; set; }

        [Menu(".pet", 3291, 29)]
        public ToggleNode pet { get; set; }
        [Menu(".pjd", 3292, 29)]
        public ToggleNode pjd { get; set; }
        [Menu(".psg", 923, 29)]
        public ToggleNode psg { get; set; }

        [Menu(".rs", 32101, 210)]
        public ToggleNode rs { get; set; }

        [Menu(".sm", 32111, 211)]
        public ToggleNode sm { get; set; }
        [Menu(".smd", 32112, 211)]
        public ToggleNode smd { get; set; }

        [Menu(".tdt", 32121, 212)]
        public ToggleNode tdt { get; set; }
        [Menu(".tgm", 32122, 212)]
        public ToggleNode tgm { get; set; }
        [Menu(".tgt", 32123, 212)]
        public ToggleNode tgt { get; set; }
        [Menu(".tmd", 32124, 212)]
        public ToggleNode tmd { get; set; }
        [Menu(".trl", 32125, 212)]
        public ToggleNode trl { get; set; }
        [Menu(".tsi", 32126, 212)]
        public ToggleNode tsi { get; set; }
        [Menu(".tst", 32127, 212)]
        public ToggleNode tst { get; set; }
        [Menu(".ttf", 32128, 212)]
        public ToggleNode ttf { get; set; }
        [Menu(".txt", 32129, 212)]
        public ToggleNode txt { get; set; }

    }
}
