namespace Gigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'Blues')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'Rock')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'Hiphop')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'RNB')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,'Techno')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (6,'House')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id in(1,2,3,4,5,6)");
        }
    }
}
