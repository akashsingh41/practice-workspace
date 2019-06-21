using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EF_CodeFirst
{
    public class DatabaseSeeder : DropCreateDatabaseIfModelChanges<TracksDBContext> 
    {
        protected override void Seed(TracksDBContext context)
        {
            Album albumInstance1 = new Album()
            {
                title = "Album X",
                imdb_rating = "7.5",
                Tracks = new List<Track>()
                {
                    new Track() { title="Track Az",artists="Artist 324"},
                    new Track() { title="Track Aa",artists="Artist 314"},
                    new Track() { title="Track Ab",artists="Artist 624"}
                },
                release_year = DateTime.Parse("2017-01-03")
            };

            Album albumInstance2 = new Album()
            {
                title = "Album D",
                imdb_rating = "8.3",
                Tracks = new List<Track>()
                {
                    new Track() { title="Track Lz",artists="Artist 436"},
                    new Track() { title="Track Ds",artists="Artist 986"},
                    new Track() { title="Track Wr",artists="Artist 542"}
                },
                release_year = DateTime.Parse("2014-01-03")
            };

            context.Albums.Add(albumInstance1);
            context.Albums.Add(albumInstance2);
            base.Seed(context);
        }
    }
}