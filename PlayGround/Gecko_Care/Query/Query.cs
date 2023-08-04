namespace Gecko_Care.Query
{
    internal struct Query
    {
        internal const string InsertMember = @"insert into member(Name,Gender,BirthDay,Morph,Memo,MotherSeq,FatherSeq,CreateTime) values(@Name,@Gender,@BirthDay,@Morph,@Memo,@MotherSeq,@FatherSeq,GETDATE())";
    }
}
