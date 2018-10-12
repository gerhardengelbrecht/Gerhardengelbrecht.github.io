namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name) VALUES('Shrek 1')");
            Sql("INSERT INTO Movies(Name) VALUES('Shrek 2')");
        }
        
        public override void Down()
        {
        }
    }
}
