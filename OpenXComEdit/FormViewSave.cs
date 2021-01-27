using System;
using System.Windows.Forms;
using OpenXComEdit.Lib;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace OpenXComEdit
{
    public partial class FormViewSave : Form
    {
        public FormViewSave()
        {
            InitializeComponent();
        }

        private void FormViewSave_Load(object sender, EventArgs e)
        {
            rtbOutput.Clear();

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .DisableAliases()
                .Build();

            var yaml = serializer.Serialize(State.SaveFile);

            rtbOutput.Text = yaml.Replace("difficulty", "---\r\ndifficulty");
        }

        private void btnReadYAML_Click(object sender, EventArgs e)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

            var save = deserializer.Deserialize<Save>(rtbOutput.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbOutput.Text);
        }
    }
}
