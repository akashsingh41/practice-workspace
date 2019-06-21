using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_CodeFirst
{
    public class TrackLibrary
    {
        public List<Album> getAllAlbums()
        {
            TracksDBContext tracksDBContext = new TracksDBContext();
            return tracksDBContext.Albums.Include("Tracks").ToList();
        }
    }
}