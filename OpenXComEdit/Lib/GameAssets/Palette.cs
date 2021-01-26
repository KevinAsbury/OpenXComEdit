using System.Collections.Generic;
using SixLabors.ImageSharp.PixelFormats;
using System.IO;
using System.Windows.Forms;

namespace OpenXComEdit.Lib.GameAssets
{
    // https://www.ufopaedia.org/index.php/PALETTES.DAT
    public class Palette
    {
        private const string palettesFile = "PALETTES.DAT";
        private const string bacPalettesFile = "BACKPALS.DAT";
        private string path { get; set; }
        private Dictionary<int, int> offsets { get; set; }
        private byte[] palBuffer { get; set; }
        private byte[] backBuffer { get; set; }
        private List<byte[]> palBuffers { get; set; }
        public List<Rgba32[]> Palettes { get; set; }

        public Palette(bool ufo = true)
        {
            var Folder = "UFO";
            if (ufo)
            {
                offsets.Add(3 + 3, 774);
                offsets.Add(777 + 3, 1548);
                offsets.Add(1551 + 3, 2322);
                offsets.Add(2325 + 3, 3096);
                offsets.Add(3099 + 3, 3870);
            }
            else
            {
                Folder = "TFTD";
                offsets.Add(3 + 3, 774);
                offsets.Add(777 + 3, 1548);
                offsets.Add(1551 + 3, 2322);
            }

            var sep = Path.DirectorySeparatorChar;
            path = State.Settings.OpenXcomPath +
                   sep + Folder + sep + "GEODATA" + sep;

            bool pathExists = Directory.Exists(path);
            bool fileExists = File.Exists(path + palettesFile);

            if (pathExists && fileExists)
            {
                palBuffer = File.ReadAllBytes(path + palettesFile);
                backBuffer = File.ReadAllBytes(path + bacPalettesFile);
            }
            else
            {
                MessageBox.Show("Error loading palette files.");
                return;
            }

            foreach (var entry in offsets)
            {
                palBuffers.Add(palBuffer[entry.Key..entry.Value]);
            }

            foreach (var pal in palBuffers)
            {
                var colors = new Rgba32[256];
                int index = 0;

                for (int i = 0; i < pal.Length; i += 3)
                {
                    var color = new Rgba32(pal[i], pal[i + 1], pal[i + 2]);
                    colors[index++] = color;
                }

                Palettes.Add(colors);
            }
        }
    }
}