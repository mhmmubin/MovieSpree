namespace MovieSpree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
        INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'a33f5c53-cee0-4aad-ba4a-82ec346c7dd5', N'admin@moviespree.com', 0, N'ANt1bo10bb5OfWFShIy4mDqftWx9A5hyf/Cbr1o+v7R9VnUJcyIpRDBEU30hsxS8Xg==', N'bd27f174-fc11-45c2-a251-d89c7aa886f5', NULL, 0, 0, NULL, 1, 0, N'admin@moviespree.com')
        INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'ec92e860-f95b-4603-b043-80a075dc0cb1', N'guest@moviespree.com', 0, N'AE2G9vk7WgL0SUCEmtpC5h22Jmp+MkjVUwphLZqyoWQ/IEtJKjF7f55vut6NEdvg6w==', N'c682551a-9bfb-4e40-be31-c7f9122119bd', NULL, 0, 0, NULL, 1, 0, N'guest@moviespree.com')
        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a4f3c926-0297-42dc-a95e-208d2c26bc76', N'CanManageMovies')
        INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a33f5c53-cee0-4aad-ba4a-82ec346c7dd5', N'a4f3c926-0297-42dc-a95e-208d2c26bc76')

");
         }
        
        public override void Down()
        {
        }
    }
}
