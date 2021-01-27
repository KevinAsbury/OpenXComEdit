using System;
using System.IO;
using System.Windows.Forms;
using OpenXComEdit.Lib;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace OpenXComEdit
{
    public partial class MainForm : Form
    {
        private FormSaveAs frmSaveAs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            enableMenuItems(false);

            if (string.IsNullOrEmpty(State.Settings.OpenXcomPath) ||
                string.IsNullOrEmpty(State.Settings.SavePath))
            {
                var frmDirectories = new FormDirectories();
                frmDirectories.Show();
                MessageBox.Show("Please select game and save directories.");
            }
        }

        private void enableMenuItems(bool value)
        {
            tsmiBases.Enabled = value;
            tsmiSave.Enabled = value;
            tsmiSoldiers.Enabled = value;
            tsmiViewSave.Enabled = value;
            tsmiSaveAs.Enabled = value;
        }

        private void saveFile(bool saveAs = false)
        {
            if (!State.LoadedSave)
                return;

            if (string.IsNullOrEmpty(State.Settings.OpenXcomPath) ||
                string.IsNullOrEmpty(State.Settings.SavePath))
            {
                MessageBox.Show("Please select game and save directories.");
                return;
            }

            var path = State.Settings.SavePath +
                           Path.DirectorySeparatorChar + "xcom1" +
                           Path.DirectorySeparatorChar +
                           State.SaveFile.Name + ".sav";

            if(!saveAs && File.Exists(path))
                File.Move(path, path + ".bac");

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .DisableAliases()
                .Build();

            var yaml = serializer.Serialize(State.SaveFile);

            File.WriteAllText(path, yaml
                .Replace("difficulty", "---\r\ndifficulty")
                .Replace("aI:", "AI:")
                .Replace("aIMode", "AIMode")
                .Replace("xCOMProperty", "XCOMProperty"));
        }
        
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (ofdSaveFile.ShowDialog() == DialogResult.OK)
            {
                var save = File.ReadAllText(ofdSaveFile.FileName)
                    .Replace("---\r\ndifficulty", "difficulty")
                    .Replace("AI:", "aI:")
                    .Replace("AIMode", "aIMode")
                    .Replace("XCOMProperty", "xCOMProperty");

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    //.IgnoreUnmatchedProperties()
                    .Build();

                try
                {
                    State.SaveFile = deserializer.Deserialize<Save>(save);
                    State.LoadedSave = true;
                    enableMenuItems(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Clipboard.SetText(ex.Message);
                    throw;
                }
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiGameDirectory_Click(object sender, EventArgs e)
        {
            var frmDirectories = new FormDirectories();
            frmDirectories.Show();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        
        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            frmSaveAs = new FormSaveAs();
            frmSaveAs.Closed += new System.EventHandler(frmSaveAs_Closed);
            frmSaveAs.Show();
        }

        private void frmSaveAs_Closed(object sender, EventArgs e)
        {
            saveFile(true);
            frmSaveAs.Closed -= new System.EventHandler(frmSaveAs_Closed);
        }

        private void tsmiBases_Click(object sender, EventArgs e)
        {
            var frmViewBases = new FormViewBase();
            frmViewBases.Show();
        }

        private void tsmiViewSave_Click(object sender, EventArgs e)
        {
            var frmViewSave = new FormViewSave();
            frmViewSave.Show();
        }

        private void tsmiSoldierBases_Click(object sender, EventArgs e)
        {
            var frmViewSoldiers = new FormViewSoldiers();
            frmViewSoldiers.Show();
        }

        private void tsmiSoldierMission_Click(object sender, EventArgs e)
        {
            var frmViewMission = new FormViewMission();
            frmViewMission.Show();
        }
    }
}
