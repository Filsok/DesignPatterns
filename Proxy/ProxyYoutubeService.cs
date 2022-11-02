namespace Proxy
{
    public class ProxyYoutubeService : IYoutubeService
    {
        private YoutubeService _youtubeService;
        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

        public ProxyYoutubeService(YoutubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }

        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"ProxyYoutubeService getting videoId");

            byte[] cashedVideo;
            if (_cache.TryGetValue(videoId, out cashedVideo))
            {
                Console.WriteLine($"Getting form cache {videoId}");
                return cashedVideo;
            }
            else
            {
                var video = _youtubeService.GetVideo(videoId);
                _cache.Add(videoId, video);
                return video;
            }
        }
    }
}