using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenXComEdit.Lib;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace OpenXComEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteYAML_Click(object sender, EventArgs e)
        {
            var xcBase = new Base("NA", 4.5738924040249991, -0.86385638583468516);
            var xcSave = new Save("WTFBBQ");
            xcSave.Bases.Add(xcBase);

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .DisableAliases()
                .Build();
            var yaml = serializer.Serialize(xcSave);
            rtbOutput.Text = yaml
                .Replace("\'", "\"")
                .Replace("difficulty", "---\r\ndifficulty")
                .Replace("\r\n      ~: ", " ~");
        }
    }
}
