namespace PersonDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTelephoneNumberRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telephones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            DropColumn("dbo.People", "telNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "telNumber", c => c.Int(nullable: false));
            DropForeignKey("dbo.Telephones", "PersonId", "dbo.People");
            DropIndex("dbo.Telephones", new[] { "PersonId" });
            DropTable("dbo.Telephones");
        }
    }
}
