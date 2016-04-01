using System;
using System.Web.Http;
using MusicStore.Web.Services.Albums;
using MusicStore.Web.Models;
using MusicStore.Web.Models.DTO;
using MusicStore.Web.Utilities;

namespace MusicStore.Web.Api
{
    public class MusicController : ApiController
    {
        [HttpPost]
        [Route("api/music/albums")]
        public AlbumResults Albums([FromBody]DateRangeDTO range)
        {
            IAlbumService albumService = new AlbumService();
            
            DateTime startDate = range.StartDate.ConvertToDateTime();
            DateTime endDate = range.EndDate.ConvertToDateTime();
            
            return new AlbumResults() {
                TotalCount = 2,
                Results = albumService.GetReleasedAlbumsBetweenDates(DateTime.Now, DateTime.Now)
            };
        }
    }
}