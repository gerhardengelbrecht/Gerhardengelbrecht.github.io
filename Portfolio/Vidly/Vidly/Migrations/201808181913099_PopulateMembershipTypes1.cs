namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, '3 Months', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, '6 Months', 300, 6, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
