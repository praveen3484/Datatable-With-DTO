namespace DataTableAndDTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students1", "studentdetails_Id", "dbo.Students1Details");
            DropIndex("dbo.Students1", new[] { "studentdetails_Id" });
            DropTable("dbo.Students1Details");
            DropTable("dbo.Students1");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        RollNo = c.Int(nullable: false),
                        Standard = c.String(nullable: false),
                        studentdetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students1Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        MotherName = c.String(),
                        FatherName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Students1", "studentdetails_Id");
            AddForeignKey("dbo.Students1", "studentdetails_Id", "dbo.Students1Details", "Id");
        }
    }
}
