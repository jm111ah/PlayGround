namespace Gecko_Care.Model
{
    public class Payment
    {
        public int MemberSeq { get; set; }
        public int TransactionType { get; set; }
        public DateTime PaymentTime { get; set; }
        public int Price { get; set; }
    }
}
