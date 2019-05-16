using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Media.Channels
{
    public class DvbtMedia : MediaItem
    {
        public int Frequency { get; set; }
        public int Bandwidth { get; set; }

        public int Program { get; set; }

        public override string GetMRL()
        {
            return "dvb-t://frequency=" + Frequency + " :bandwidth=" + Bandwidth;
            //m_media.AddOptions(new List<string>() { ":program="+Program, ":dshow-aspect-ratio=16:9" });
        }

        public override string GetExtras()
        {
            return " :program=" + Program;
        }
    }

}
