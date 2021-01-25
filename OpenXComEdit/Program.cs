using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenXComEdit.Lib;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace OpenXComEdit
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadSettings();
            Application.Run(new Form1());
        }

        internal static Settings Settings { get; set; }

        static void LoadSettings()
        {
            if (File.Exists("Settings.yaml"))
            {
                var yaml = File.ReadAllText("Settings.yaml");

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .IgnoreUnmatchedProperties()
                    .Build();

                Settings = deserializer.Deserialize<Settings>(yaml);
            }
            else
            {
                var settings = new Settings();
                var serializer = new SerializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                    .DisableAliases()
                    .Build();
                var yaml = serializer.Serialize(settings);

                File.WriteAllText("Settings.yaml", yaml);
            }
        }
    }
}
