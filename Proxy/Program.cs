using Proxy;

YoutubeService youtubeService = new YoutubeService();

youtubeService.GetVideo(10);
youtubeService.GetVideo(10);

Console.WriteLine("\nNow proxy:");
ProxyYoutubeService proxyYoutubeService = new ProxyYoutubeService(youtubeService);
proxyYoutubeService.GetVideo(10);
proxyYoutubeService.GetVideo(10);