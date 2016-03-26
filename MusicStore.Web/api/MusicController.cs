using System;
using System.Web.Http;
using System.Web.Http.Results;
using MusicStore.Web.Services.Albums;
using MusicStore.Web.Models.DTO;
using MusicStore.Web.Utilities;

namespace MusicStore.Web.Api
{
    public class MusicController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Albums(DateRangeDTO range)
        {
            IAlbumService albumService = new AlbumService();
            
            DateTime startDate = range.StartDate.ConvertToDateTime();
            DateTime endDate = range.EndDate.ConvertToDateTime();
            
            return Ok();
        }
    }
}