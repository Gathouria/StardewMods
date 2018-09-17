using Newtonsoft.Json;

namespace Entoarox.AdvancedLocationLoader.Configs
{
    internal class Warp : TileInfo
    {
        /*********
        ** Accessors
        *********/
        [JsonIgnore] public new bool Optional;

        public string TargetName;
        public int TargetX;
        public int TargetY;


        /*********
        ** Public methods
        *********/
        public override string ToString()
        {
            return $"Warp({this.MapName}@[{this.TileX}{','}{this.TileY}] => {this.TargetName}@[{this.TargetX}{','}{this.TargetY}])";
        }
    }
}
