namespace Gecko_Care.Model
{
    public class Growth
    {

        public Growth()
        {
            GrowthInfoJson = string.Empty;
        }
        public int MemberSeq { get; set; }
        public string GrowthInfoJson { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
