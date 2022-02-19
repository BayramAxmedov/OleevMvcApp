namespace OleevMvcApp.Models
{
    public class SectionTwo:Base
    {
        public string SubHeader { get; set; }
        public string Header { get; set; } = null!;
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
