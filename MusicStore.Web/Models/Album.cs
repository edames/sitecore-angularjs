using System;

namespace MusicStore.Web.Models
{
    public class Album : IAlbum
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; } 
    }
    
}