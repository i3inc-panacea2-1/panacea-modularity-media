using System;
using System.Linq;

namespace Panacea.Modularity.Media.Channels
{
    public class IptvMedia : MediaItem
    {
        public string URL { get; set; }

        public override string GetMRL()
        {
            return URL.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0];
        }

        public override string GetExtras()
        {
            var spl = URL.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (spl.Count() > 1)
            {
                var list = spl.ToList();
                return string.Join(" ", list);
            }
            return "";
        }
    }
}
