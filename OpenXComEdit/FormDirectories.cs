using System;
using System.IO;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace OpenXComEdit
{
    public partial class FormDirectories : Form
    {
        public FormDirectories()
        {
            InitializeComponent();
        }

        private void btnGamePath_Click(object sender, EventArgs e)
        {
            if (fbdGamePath.ShowDialog() == DialogResult.OK)
            {
                txtGamePath.Text = fbdGamePath.SelectedPath;
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            if (fbdSavePath.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = fbdSavePath.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (!string.IsNullOrEmpty(txtSavePath.Text.Trim()) || !string.IsNullOrEmpty(txtGamePath.Text.Trim()))
            {
                if (Directory.Exists(txtSavePath.Text.Trim()))
                {
                    State.Settings.SavePath = txtSavePath.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Invalid save path!");
                    ok = false;
                }

                if (ok && Directory.Exists(txtGamePath.Text.Trim()))
                {
                    State.Settings.OpenXcomPath = txtGamePath.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Invalid game path!");
                    ok = false;
                }
            }
            else
            {
                MessageBox.Show("Path is empty.");
                ok = false;
            }

            if (ok)
            {
                var serializer = new SerializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                    .DisableAliases()
                    .Build();
                var yaml = serializer.Serialize(State.Settings);

                File.WriteAllText("Settings.yaml", yaml);
                Close();
            }
        }

        private void FormDirectories_Load(object sender, EventArgs e)
        {
            txtSavePath.Text = State.Settings.SavePath;
            txtGamePath.Text = State.Settings.OpenXcomPath;
        }
    }
}
