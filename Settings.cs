using System;
using System.Windows.Forms;

namespace AsmHW_SmartRename
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }
        private void LoadSettings()
        {
            FirstNameTB.Text = Properties.Settings.Default.FirstName;
            LastNameTB.Text = Properties.Settings.Default.LastName;
            HWPathTB.Text = Properties.Settings.Default.HWPath;
            FBD.SelectedPath = HWPathTB.Text;
            FoldersPatternTB.Text = Properties.Settings.Default.FoldersPattern;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // assign new settings //
            Properties.Settings.Default.FirstName = FirstNameTB.Text;
            Properties.Settings.Default.LastName = LastNameTB.Text;
            Properties.Settings.Default.HWPath = HWPathTB.Text;
            Properties.Settings.Default.FoldersPattern = FoldersPatternTB.Text;

            Properties.Settings.Default.Save(); // save settings
            Close(); // close form
        }

        private void FBDButton_Click(object sender, EventArgs e)
        {
            FBD.ShowDialog();
            HWPathTB.Text = FBD.SelectedPath;
        }
    }
}
