using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AsmHW_SmartRename
{
    public partial class Main : Form
    {
        private const string hw_path = @"D:\Magshimim\Magshimim-Assembly";
        private const string hw_number_pattern = @"^Lesson(\d+)$";
        private static Regex hw_number_regex = new Regex(hw_number_pattern);

        public Main()
        {
            InitializeComponent();
            GetLastHW();
        }
        private void GetLastHW()
        {
            int hw_num;

            string[] _hw_folders = Directory.GetDirectories(hw_path);
            List<string> hw_folders = new List<string>();
            hw_folders.AddRange(_hw_folders);
            string[] sorted = hw_folders
                            .OrderBy(folderPath => hw_number_regex.Matches(Path.GetFileName(folderPath))[0].Value)
                            .ToArray();

        }
        public static string GetFolder(string input)
        {
            MatchCollection mc = hw_number_regex.Matches(input);

            if (mc.Count != 0)
                return mc[0].Value;
            else
                return "Lesson0";

        }

        private void MainPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string file = e.Data.GetData(DataFormats.FileDrop) as string;

            }
        }

        private void MainPanel_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

    }
}
