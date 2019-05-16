
namespace Panacea.Modularity.Media.Channels
{
    public class PlaylistMedia : Media
    {
        public int Index { get; set; }
        public PlaylistMedia(params Media[] channels)
        {
            _channels = channels;
        }

        Media[] _channels;

        public bool Next()
        {
            if (Index == _channels.Length - 1) return false;
            Index++;
            return true;
        }

        public bool Previous()
        {
            if (Index == 0) return false;
            Index++;
            return true;
        }

        public string URL { get; set; }

        public override string GetMRL()
        {
            return _channels[Index].GetMRL();
        }

        public override string GetExtras()
        {
            return _channels[Index].GetExtras();
        }
    }
}
