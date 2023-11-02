namespace ExcerciseMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDOB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birth_Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birth_Date");
        }
    }
}
