namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1993-02-01' WHERE Id = 4");
            Sql("UPDATE Customers SET BirthDate = '1995-06-09' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
