using System.Collections.Generic;
using System.ComponentModel.Design;

namespace OpenXComEdit.Lib
{
    public class BattleGame
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public string MissionType { get; set; }
        public int Globalshade { get; set; }
        public int Turn { get; set; }
        public int SelectedUnit { get; set; }
        public List<string> Mapdatasets { get; set; }
        public string TileIndexSize { get; set; }
        public int TileTotalBytesPer { get; set; }
        public string TileFireSize { get; set; }
        public string TileSmokeSize { get; set; }
        public string TileIDSize { get; set; }
        public string TileSetIDSize { get; set; }
        public string TileBoolFieldsSize { get; set; }
        public int TotalTiles { get; set; }
        public string BinTiles { get; set; }
        public List<Node> Nodes { get; set; }
        public List<Unit> Units { get; set; }
        public List<Item> Items { get; set; }
        public int TuReserved { get; set; }
        public bool KneelReserved { get; set; }
        public int Depth { get; set; }
        public int Ambience { get; set; }
        public double AmbientVolume { get; set; }
        public string Music { get; set; }
        public int TurnLimit { get; set; }
        public int ChronoTrigger { get; set; }
        public int CheatTurn { get; set; }

        public BattleGame(int width, int length, int height, string missionType, int globalshade, int turn, int selectedUnit, List<string> mapdatasets, string tileIndexSize, int tileTotalBytesPer, string tileFireSize, string tileSmokeSize, string tileIdSize, string tileSetIdSize, string tileBoolFieldsSize, int totalTiles, string binTiles, List<Node> nodes, List<Unit> units, List<Item> items, int tuReserved, bool kneelReserved, int depth, int ambience, double ambientVolume, string music, int turnLimit, int chronoTrigger, int cheatTurn)
        {
            Width = width;
            Length = length;
            Height = height;
            MissionType = missionType;
            Globalshade = globalshade;
            Turn = turn;
            SelectedUnit = selectedUnit;
            Mapdatasets = mapdatasets;
            TileIndexSize = tileIndexSize;
            TileTotalBytesPer = tileTotalBytesPer;
            TileFireSize = tileFireSize;
            TileSmokeSize = tileSmokeSize;
            TileIDSize = tileIdSize;
            TileSetIDSize = tileSetIdSize;
            TileBoolFieldsSize = tileBoolFieldsSize;
            TotalTiles = totalTiles;
            BinTiles = binTiles;
            Nodes = nodes;
            Units = units;
            Items = items;
            TuReserved = tuReserved;
            KneelReserved = kneelReserved;
            Depth = depth;
            Ambience = ambience;
            AmbientVolume = ambientVolume;
            Music = music;
            TurnLimit = turnLimit;
            ChronoTrigger = chronoTrigger;
            CheatTurn = cheatTurn;
        }

        public BattleGame()
        {
            
        }
    }
}