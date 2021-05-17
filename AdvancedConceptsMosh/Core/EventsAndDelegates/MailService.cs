using System;

namespace AdvancedConceptsMosh
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email about video {e.video.Title}");
        }
    }
}
