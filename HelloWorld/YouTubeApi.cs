namespace HelloWorld
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // access youtube web service
                // read the data
                // create a list of video objects
                throw new Exception("opps some low level YT error");
            }
            catch (Exception ex)
            {
                // log
                throw new YouTubeException("could not not fetch the videos from YouTube", ex);
            }
            return new List<Video>();
        }
    }
}
