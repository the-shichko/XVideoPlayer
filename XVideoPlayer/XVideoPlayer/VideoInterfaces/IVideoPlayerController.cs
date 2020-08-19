using System;
using XVideoPlayer.VideoClasses;

namespace XVideoPlayer.VideoInterfaces
{
    public interface IVideoPlayerController
    {
        VideoStatus Status { set; get; }
        TimeSpan Duration { set; get; }
    }
}
