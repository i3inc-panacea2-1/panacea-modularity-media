using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.Media
{
    public interface IMediaPlayer
    {
        bool IsSeekable { get; }

        event EventHandler<bool> IsSeekableChanged;

        float Position { get; set; }

        event EventHandler<float> PositionChanged;

        bool IsPlaying { get; }

        bool HasNext { get; }

        event EventHandler<bool> HasNextChanged;

        bool HasPrevious { get; }

        event EventHandler<bool> HasPreviousChanged;

        bool IsPausable { get; }

        event EventHandler IsPausableChanged;

        void Next();

        void Previous();

        void Play();

        void Stop();

        void Pause();

        event EventHandler Opening;
        event EventHandler Playing;
        event EventHandler<string> NowPlaying;
        event EventHandler Stopped;
        event EventHandler Paused;
        event EventHandler Ended;
        event EventHandler<Exception> Error;

        void SetSubtitles(bool on);

        bool HasSubtitles { get; }
        event EventHandler<bool> HasSubtitlesChanged;

        

        TimeSpan Duration { get; }

        event EventHandler<TimeSpan> DurationChanged;

    }
}
