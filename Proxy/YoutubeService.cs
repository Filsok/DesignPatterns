namespace Proxy
{
    public class YoutubeService : IYoutubeService
    {
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"Youtube service downloading video id: {videoId}");
            return new byte[videoId];
        }
    }
}