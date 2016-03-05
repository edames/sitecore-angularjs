using System;
using System.Collections.Generic;
using MusicStore.Web.Models;

namespace MusicStore.Web.Services.Albums
{
    public interface IAlbumService  
    {
        IEnumerable<IAlbum> GetReleasedAlbumsBetweenDates(DateTime startDate, DateTime endDate);
    }
}