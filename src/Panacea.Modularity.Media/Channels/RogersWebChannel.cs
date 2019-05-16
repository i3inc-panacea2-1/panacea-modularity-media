
namespace Panacea.Modularity.Media.Channels
{
    public class RogersWebMedia : MediaItem
    {
        public string URL { get; set; }

        public override string GetMRL()
        {
            return URL;
        }

        public override string GetExtras()
        {
            return "";
        }
    }
}
