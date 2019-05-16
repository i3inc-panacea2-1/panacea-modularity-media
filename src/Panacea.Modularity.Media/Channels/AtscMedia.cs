
namespace Panacea.Modularity.Media.Channels
{
    public class AtscMedia : MediaItem
    {
        public int Physical { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }

        public override string GetMRL()
        {
            return "";
        }

        public override string GetExtras()
        {
            return "";
        }
    }
}
