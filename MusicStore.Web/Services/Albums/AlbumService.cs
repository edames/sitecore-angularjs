using System;
using System.Collections.Generic;
using MusicStore.Web.Models;

namespace MusicStore.Web.Services.Albums
{
    public class AlbumService : IAlbumService
    {
        public IEnumerable<IAlbum> GetReleasedAlbumsBetweenDates(DateTime startDate, DateTime endDate)
        {
            yield return new Album()
            {
                Title = "A Head Full of Dreams",
                Artist = "Coldplay",
                ReleaseDate = DateTime.Parse("12/04/15")
            };
            
            yield return new Album()
            {
                Title = "Rivers In The Wasteland",
                Artist = "NeedToBreathe",
                ReleaseDate = DateTime.Parse("04/15/15")  
            };
        }        
    }
}