﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.Media
{
    public interface IMediaPlayerPlugin : IPlugin
    {
        

        IMediaPlayer GetMediaPlayer();

    }
}
