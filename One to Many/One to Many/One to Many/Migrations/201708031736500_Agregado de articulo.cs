namespace One_to_Many.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregadodearticulo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articuloes");
        }
    }
}
