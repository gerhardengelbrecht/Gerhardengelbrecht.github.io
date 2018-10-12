namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES('John', 1, 1)");
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES('Andrew', 0, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
