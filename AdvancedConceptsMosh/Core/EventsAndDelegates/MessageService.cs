using System;

namespace AdvancedConceptsMosh
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending a message about video {e.video.Title}");
        }
    }
}
