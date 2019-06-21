using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst
{
    [Table("Tracks")]
    public class Track
    {
        [Key]
        public int track_id { get; set; }
        public string title { get; set; }
        public string artists { get; set; }
        public int album_id { get; set; }
        [ForeignKey("album_id")] 
        public Album album { get; set; } 
    }
}