namespace Resume.Models
{
    public class Experience
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public List<string> Periods { get; set; } = new List<string>();
        public string Description { get; set; }
    }
}
