using System;
using System.Collections.Generic;
using MusicStore.Web.Models;

namespace MusicStore.Web.Services.Albums
{
    public class AlbumService : IAlbumService
    {
        public IEnumerable<IAlbum> GetReleasedAlbumsBetweenDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();       
        }        
    }
}