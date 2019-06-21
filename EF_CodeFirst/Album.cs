using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst
{
    [Table("Albums")]
    public class Album
    {
        [Key]
        public int album_id { get; set; }
        public string title { get; set; }
        public DateTime release_year { get; set; }
        public string imdb_rating { get; set; }
        public List<Track> Tracks { get; set; }
    }
}