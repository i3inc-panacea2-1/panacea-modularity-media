using Panacea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Media
{
    public abstract class Channel:ServerItem
    {
        public abstract string GetMRL();

        public abstract string GetExtras();
    }
}
