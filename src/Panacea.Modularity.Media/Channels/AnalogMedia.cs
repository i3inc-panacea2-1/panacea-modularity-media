
namespace Panacea.Modularity.Media.Channels
{
    public class AnalogMedia : MediaItem
    {
        public int ChannelNumber { get; set; }
        public string CountryCode { get; set; }
        public string Source { get; set; }
        public string Country { get; set; }
        public override string GetMRL()
        {
            return $"{CountryCode}-{ChannelNumber}-{Source}-{Country}";
        }

        public override string GetExtras()
        {
            return "";
        }
    }
}
