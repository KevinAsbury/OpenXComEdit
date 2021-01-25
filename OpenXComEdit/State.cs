using OpenXComEdit.Lib;

namespace OpenXComEdit
{
    public static class State
    {
        internal static Settings Settings { get; set; }
        internal static Save SaveFile { get; set; }
        internal static bool LoadedSave { get; set; }
    }
}