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
            State.SaveFile = new Save();
            State.LoadedSave = false;
            Application.Run(new MainForm());
        }
        
        static void LoadSettings()
        {
            if (File.Exists("Settings.yaml"))
            {
                var yaml = File.ReadAllText("Settings.yaml");

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .IgnoreUnmatchedProperties()
                    .Build();

                State.Settings = deserializer.Deserialize<Settings>(yaml);
            }
            else
            {
                State.Settings = new Settings();
                var serializer = new SerializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                    .DisableAliases()
                    .Build();
                var yaml = serializer.Serialize(State.Settings);

                File.WriteAllText("Settings.yaml", yaml);
            }
        }
    }
}
