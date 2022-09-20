namespace nzeal.api.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Lenght { get; set; }
        public Guid RegionID { get; set; }
        public Guid WalkDifficultID { get; set; }

        //Navigation properties
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }


    }
}
