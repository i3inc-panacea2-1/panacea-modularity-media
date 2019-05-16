using Panacea.Models;


namespace Panacea.Modularity.Media
{
    public abstract class MediaItem : ServerItem
    {
        public abstract string GetMRL();

        public abstract string GetExtras();
    }
}
