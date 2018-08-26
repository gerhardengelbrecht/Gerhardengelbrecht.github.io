namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 1 WHERE Id = 1");
            Sql("UPDATE Movies SET GenreId = 2 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
