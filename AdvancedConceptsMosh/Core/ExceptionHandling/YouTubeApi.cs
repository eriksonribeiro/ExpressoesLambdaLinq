using System;
using System.Collections.Generic;

namespace AdvancedConceptsMosh
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Basic exception!");
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos from YouTube.",ex);
            }

            return new List<Video>();
        }
    }
}
