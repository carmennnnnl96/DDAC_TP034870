namespace Maersk_TP034870.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {/*
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a85c581-d6b7-4cc8-83f5-b5554d607cbf', N'aa@aa.com', 0, N'AGpAK+N6oXQ+pGIwRjkQV4hdYPiXmvdTGO3iRvwbrjZoAeUvEImpOODakish7Ufs2Q==', N'313fc145-49e1-49ad-a1d1-87a6d8ea74c2', NULL, 0, 0, NULL, 1, 0, N'aa@aa.com')
    ");*/
        }
        
        public override void Down()
        {
        }
    }
}
