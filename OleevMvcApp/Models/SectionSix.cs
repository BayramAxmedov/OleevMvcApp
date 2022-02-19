namespace OleevMvcApp.Models
{
    public class SectionSix:Base
    {
        public string SubHeader { get; set; }
        public string Header { get; set; } = null!;
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }


        public string CategoryTitle1 { get; set; }
        public string CategoryDescription1 { get; set; }
        public string CategoryIcon1 { get; set; }


        public string CategoryTitle2 { get; set; }
        public string CategoryDescription2 { get; set; }
        public string CategoryIcon2 { get; set; }
    }

}
