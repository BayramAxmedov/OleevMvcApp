using System.ComponentModel.DataAnnotations;

namespace OleevMvcApp.Models
{
    public class SectionOne:Base
    {
        public string? SubHeader { get; set; }
        [MaxLength(50)]
        public string Header { get; set; } = null!;
        [MaxLength(100)]
        public string? Description { get; set; }
        [MaxLength(100)]
        public string? PhotoUrl { get; set; }
    }
}