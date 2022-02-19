namespace OleevMvcApp.Models
{
    public class SectionFour:Base
    {
        public string SubHeader { get; set; }
        public string Header { get; set; } = null!;
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        public string CategoryHeader1 { get; set; }
        public int CategoryDescription1 { get; set; }
        public string CategoryIcon1 { get; set; }
        public string CategoryHeader2 { get; set; }
        public int CategoryDescription2 { get; set; }
        public string CategoryIcon2 { get; set; }
    }
}
