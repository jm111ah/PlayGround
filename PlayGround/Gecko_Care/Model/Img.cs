namespace Gecko_Care.Model
{
    public class Img
    {
		public Img()
		{
			TopImg = string.Empty;
			LeftImg = string.Empty;
			RightImg = string.Empty;
			BackImg = string.Empty;
			FaceImg = string.Empty;
			AfarTopImg = string.Empty;
			AfarLeftImg = string.Empty;
			AfarRightImg = string.Empty;
			AfarBackImg = string.Empty;
			AfarFaceImg = string.Empty;
		}
        public int MemberSeq { get; set; }
        public string TopImg { get; set; }
		public string LeftImg { get; set; }
		public string RightImg { get; set; }
		public string BackImg { get; set; }
		public string FaceImg { get; set; }
		public string AfarTopImg { get; set; }
		public string AfarLeftImg { get; set; }
		public string AfarRightImg { get; set; }
		public string AfarBackImg { get; set; }
		public string AfarFaceImg { get; set; }
		public DateTime ImgTime { get; set; }
	}
}
