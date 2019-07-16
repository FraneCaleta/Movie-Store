namespace PMF_Movie_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4e7b56de-fa4d-46ff-a90a-dbfdbcfeec87', N'guest@yahoo.com', 0, N'AMQoXGR4SF6LOl9SPvGtz5pUIWajyz9np5uefNy6rtZM0wwFECU+Y2BXkHk2yDDhSg==', N'408e77dc-f001-4291-9c4b-090ee83cc080', NULL, 0, 0, NULL, 1, 0, N'guest@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cd26e56e-8388-43fe-8c5d-706c1d17c01a', N'frane.caleta@yahoo.com', 0, N'AOtTO6Ox+aDAcwZsm+0chPlSPl9Nhp1tGNpLOzgbkyVFlcsChjIg0jH37ThVbEz+Mw==', N'047111b0-edf8-4a5b-9d8b-164a7e9dd471', NULL, 0, 0, NULL, 1, 0, N'frane.caleta@yahoo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bd7788fd-5d52-4975-8749-9e41ce00428d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cd26e56e-8388-43fe-8c5d-706c1d17c01a', N'bd7788fd-5d52-4975-8749-9e41ce00428d')
");
        }
        
        public override void Down()
        {
        }
    }
}
