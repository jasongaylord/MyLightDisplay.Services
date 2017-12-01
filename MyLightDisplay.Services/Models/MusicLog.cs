using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLightDisplay.Services
{
    [Table("mylightdisplay.MusicLog")]
    public partial class MusicLog
    {
        [Key]
        public long LogId { get; set; }
        public string Song { get; set; }
        public string Artists { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public string Length { get; set; }
        public DateTime DateStarted { get; set; }
        public int SequenceType { get; set; }
    }
}
