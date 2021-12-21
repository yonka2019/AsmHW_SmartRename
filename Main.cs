using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AsmHW_SmartRename
{
    public partial class MainForm : Form
    {
        private static readonly Regex hw_number_regex = new Regex(Properties.Settings.Default.FoldersPattern);
        private readonly string lastHW;

        public MainForm()
        {
            InitializeComponent();
            lastHW = GetLastHW;
        }
        private string GetLastHW
        {
            get
            {
                string lasthw = null;
                Match mc;
                string[] _hw_folders = Directory.GetDirectories(Properties.Settings.Default.HWPath);
                List<string> hw_folders = new List<string>();
                hw_folders.AddRange(_hw_folders);

                List<string> sorted = hw_folders
                                .OrderBy(folderPath => GetFolder(ref hw_folders, folderPath)).ToList();

                mc = hw_number_regex.Match(Path.GetFileName(sorted[sorted.Count - 1]));

                if (mc != null)
                    lasthw = mc.Groups[1].Value;

                return lasthw;

            }
        }
        public static string GetFolder(ref List<string> hw_folders, string input)
        {
            MatchCollection mc = hw_number_regex.Matches(Path.GetFileName(input));

            if (mc.Count != 0)
                return mc[0].Value;
            else
            {
                hw_folders.Remove(input);
                return "0";
            }

        }

        private void MainPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Path.GetExtension(file) == ".zip")
                    System.IO.File.Move(file, $"{Path.GetDirectoryName(file)}\\{lastHW}_{Properties.Settings.Default.FirstName}_{Properties.Settings.Default.LastName}.zip");
                else
                    MessageBox.Show("The given file doesn't have .zip extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainPanel_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void SettingsButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
