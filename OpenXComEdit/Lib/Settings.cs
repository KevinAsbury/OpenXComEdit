namespace OpenXComEdit.Lib
{
    public class Settings
    {
        public string OpenXcomPath { get; set; }
        public string SavePath { get; set; }

        public Settings(string openXcomPath, string savePath)
        {
            OpenXcomPath = openXcomPath;
            SavePath = savePath;
        }

        public Settings()
        {
            OpenXcomPath = "";
            SavePath = "";
        }
    }
}