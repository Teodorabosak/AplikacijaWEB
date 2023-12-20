namespace AplikacijaWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name = 'Pay as you go' WHERE id=1");
            Sql("Update MembershipTypes SET Name = 'Monthly' WHERE id=2");
            Sql("Update MembershipTypes SET Name = 'Quartely' WHERE id=3");
            Sql("Update MembershipTypes SET Name = 'Annual' WHERE id=4");
        }
        
        public override void Down()
        {
        }
    }
}
