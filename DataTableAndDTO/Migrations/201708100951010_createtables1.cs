namespace DataTableAndDTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students1", "Address", c => c.String());
            AddColumn("dbo.Students1", "MotherName", c => c.String());
            AddColumn("dbo.Students1", "FatherName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students1", "FatherName");
            DropColumn("dbo.Students1", "MotherName");
            DropColumn("dbo.Students1", "Address");
        }
    }
}
