using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyLightDisplay.Services.Controllers
{
    public class MusicLogsController : ApiController
    {
        private Lights db = new Lights();

        [HttpGet]
        [Route("MusicLogs/LastTenSongs")]
        [ResponseType(typeof(List<MusicLog>))]
        public async Task<IHttpActionResult> LastTenSongs()
        {
            var musicLogs = await db.MusicLogs.OrderByDescending(o => o.DateStarted).Take(10).ToListAsync();
            if (musicLogs == null)
                return NotFound();
            return Ok(musicLogs);
        }

        [HttpGet]
        [Route("MusicLogs/CurrentlyPlaying")]
        [ResponseType(typeof(MusicLog))]
        public async Task<IHttpActionResult> CurrentlyPlaying()
        {
            var musicLog = await db.MusicLogs.OrderByDescending(o => o.DateStarted).FirstOrDefaultAsync();
            if (musicLog == null)
                return NotFound();
            return Ok(musicLog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}