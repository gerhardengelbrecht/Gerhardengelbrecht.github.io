namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieDetails : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = '1902-12-05', DateAdded = '1903-03-03', NumberInStock = 5 WHERE id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '1906-12-05', DateAdded = '1906-03-03', NumberInStock = 5 WHERE id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
