namespace DataTableAndDTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students1", "Address");
            DropColumn("dbo.Students1", "MotherName");
            DropColumn("dbo.Students1", "FatherName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students1", "FatherName", c => c.String());
            AddColumn("dbo.Students1", "MotherName", c => c.String());
            AddColumn("dbo.Students1", "Address", c => c.String());
        }
    }
}
