namespace Gecko_Care.Query
{
    internal struct Query
    {
        internal const string InsertMember = @"insert into member(Name,Gender,BirthDay,Morph,Memo,MotherSeq,FatherSeq,CreateTime) values(@Name,@Gender,@BirthDay,@Morph,@Memo,@MotherSeq,@FatherSeq,GETDATE())";

        internal const string SelectMember = @"select MemberSeq,Name,Gender,BirthDay,Morph,Memo,MotherSeq,FatherSeq,CreateTime from Member where Name = @Name";

        internal const string UpdateMember = @"update Member set Name = @Name , Gender = @Gender, BirthDay = @BirthDay, Morph = @Morph, MotherSeq =@MotherSeq, FatherSeq = @FatherSeq  where MemberSeq = @MemberSeq";

        internal const string DeleteMember = @"delete Member where MemberSeq = @MemberSeq";

    }
}
