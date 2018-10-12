namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'90d6ccfc-0f09-44ab-bc87-d7770a88639e', N'admin@vidly.com', 0, N'ACvBJwrxQ/ifOSVuYpV0B/Loy3C0fIvz0HcoMcB7w2ML6RXC/wnQzeSeN/8Y7LbAQQ==', N'a928d288-da3a-4f02-ba60-25fde5c01aa5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b8a7e87-a37b-4109-af4e-9cc164a196ad', N'guest@vidly.com', 0, N'AHMap/xMTTY9EgQo3vITaZ7+5r14ILltiHFwTGXCWYouBTZv5PnzYugFEXWAGbzyKQ==', N'b4aee026-69ce-43e2-95ab-a0b3196f0829', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'41f01f86-dad4-449e-ae71-2d138c2f9906', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90d6ccfc-0f09-44ab-bc87-d7770a88639e', N'41f01f86-dad4-449e-ae71-2d138c2f9906')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
