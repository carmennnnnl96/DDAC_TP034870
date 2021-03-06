namespace Maersk_TP034870.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {

            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a7d2b3b-be66-4232-b359-184b3934a781', N'guest@a.com', 0, N'AA2GNCRqSxW65/qccaadFOyj+K7T+qD28n8ytR8189BRRaj9+ulm+/cqSW4NJos1jQ==', N'a91f1619-4fa1-4d5a-b18d-9b4166d56378', NULL, 0, 0, NULL, 1, 0, N'guest@a.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a85c581-d6b7-4cc8-83f5-b5554d607cbf', N'aa@aa.com', 0, N'AGpAK+N6oXQ+pGIwRjkQV4hdYPiXmvdTGO3iRvwbrjZoAeUvEImpOODakish7Ufs2Q==', N'313fc145-49e1-49ad-a1d1-87a6d8ea74c2', NULL, 0, 0, NULL, 1, 0, N'aa@aa.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50baf417-d509-4bd4-b98f-0346d6fbaa55', N'admin@a.com', 0, N'AEyrJRwC13eIq6CXFeTV5B63UEg/ONLtGI1Q+hpg7DE8eJXlLpRr0xTTwuJxqOul1g==', N'c059c494-1a82-49ce-a55f-8f067dd12039', NULL, 0, 0, NULL, 1, 0, N'admin@a.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9584572f-54fa-470b-a756-7b8161c37e18', N'Admin')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'50baf417-d509-4bd4-b98f-0346d6fbaa55', N'9584572f-54fa-470b-a756-7b8161c37e18')



");

        }
        
        public override void Down()
        {
        }
    }
}
