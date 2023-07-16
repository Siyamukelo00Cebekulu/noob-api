namespace WebApi.Domain.Model
{
    public class Walks
    {
        public Guid Id { get; set;}
        public string Name { get; set;}

        public string Description { get; set; }

        public string LengthInkm { get; set; }

        public string? WalkImageUrl { get; set; }

        public Guid RegionID { get; set; }

        public Guid Difficulty { get; set; }

        // Navigation property
        public Difficulty difficulty{ get; set; }

        public Region region { get; set; }
    }
}