namespace PMF_Movie_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
            // it is because we don't have a column for decrease and increase in DB.
            // I mean every time a customer rent a movie it should decrease by one,
            // but the number in stock is the count of the primary.
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
