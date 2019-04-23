using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.Media
{
    public interface IMediaPlayerPlugin:IPlugin
    {
        FrameworkElement VideoControl { get; }

        bool IsSeekable { get; }

        float Position { get; set; }

        bool IsPlaying { get; }

        bool HasNext { get; }

        bool HasPrevious { get; }

        ReadOnlyCollection<Type> SupportedChannels { get; }

        bool HasSubtitles { get; }

        TimeSpan Duration { get; }

        bool IsPausable { get; }

        void Next();

        void Previous();

        bool HasMoreChapters();

        void SetSubtitles(string title);

        void NextSubtitle();

        Task Play(Channel channel);

        void Play();

        void Stop();

        void Pause();

        event EventHandler<TimeSpan> DurationChanged;
        event EventHandler<List<string>> SubtitlesChanged;
        event EventHandler<bool> HasSubtitlesChanged;
        event EventHandler Click;
        event EventHandler<bool> NavigatableChanged;
        event EventHandler<int> ChapterChanged;
        event EventHandler<string> NowPlaying;
        event EventHandler<bool> SeekableChanged;
        event EventHandler Started;
        event EventHandler Playing;
        event EventHandler Opening;
        event EventHandler Stopped;
        event EventHandler Paused;
        event EventHandler Ended;
        event EventHandler<Exception> Error;
        event EventHandler<float> PositionChanged;
        
    }
}
