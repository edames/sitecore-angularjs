using System;
using System.Collections.Generic;

namespace MusicStore.Web.Models
{
    public class AlbumResults
    {
        public int TotalCount { get; set; }
        public IEnumerable<IAlbum> Results { get; set; }
    }
}