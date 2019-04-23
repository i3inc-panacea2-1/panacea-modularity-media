using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Media
{
    public abstract class Channel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsPressed { get; set; }

        public abstract string GetMRL();

        public abstract string GetExtras();
    }
}
