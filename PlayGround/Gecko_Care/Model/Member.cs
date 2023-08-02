namespace Gecko_Care.Model
{
    public class Member
    {
        public Member()
        {
            Name = string.Empty;
            BirthDay = string.Empty;
            Morph = string.Empty;
            Memo = string.Empty;
        }

        public int MemberSeq { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public string BirthDay { get; set; }
        public string Morph { get; set; }
        public string Memo { get; set; }
        public  int MotherSeq { get; set; }
        public int FaterSeq { get; set; }
        public DateTime CreateTime { get; set; }



    }
}
