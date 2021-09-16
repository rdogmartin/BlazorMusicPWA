using mtfbpwa.Shared;

namespace mtfbpwa.Server.Data
{
    public class TrackManager
    {
        public List<Track> AllTracks { get; set; } = new List<Track>();
        public TrackManager()
        {
            AllTracks.Add(new Track
            {
                Id = 1,
                Title = "After the Gold Rush",
                Description = "Title track from the album",
                FileName = "1.mp3",
                PublishDate = "September 1970"
            });

            AllTracks.Add(new Track
            {
                Id = 2,
                Title = "Southern Man",
                Description = "Neil's answer to southern racism",
                FileName = "2.mp3",
                PublishDate = "September 1970"
            });
        }
    }
}
