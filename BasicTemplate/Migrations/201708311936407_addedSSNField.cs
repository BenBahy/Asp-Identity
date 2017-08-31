namespace BasicTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSSNField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SSN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SSN");
        }
    }
}
