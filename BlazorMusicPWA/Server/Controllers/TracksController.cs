using Microsoft.AspNetCore.Mvc;
using mtfbpwa.Server.Data;
using mtfbpwa.Shared;

namespace mtfbpwa.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        private TrackManager trackManager;

        public TracksController(TrackManager _trackManager)
        {
            trackManager = _trackManager;
        }

        [HttpGet]
        public List<Track> Get()
        {
            return trackManager.AllTracks;
        }
    }
}
