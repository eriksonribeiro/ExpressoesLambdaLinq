using System;
using System.Threading;

public class VideoEncoder
{
    /// <summary>
    /// 1 - Define a delegate
    /// You can create a new EventHandler, example below
    /// public delegate void VideoEncodedEventHnadler(object source, VideoEventArgs args);
    /// or use the EventHnadler Clas
    /// </summary>

    public event EventHandler<VideoEventArgs> VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Enconding Video ...");
        Thread.Sleep(3000);

        OnVideoEncoded(video);
    }

    #region Event Definition
     // 2 - Define an event based on that delegate
    #endregion
    public virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            VideoEncoded(this, new VideoEventArgs() { video = video });
    }

}
