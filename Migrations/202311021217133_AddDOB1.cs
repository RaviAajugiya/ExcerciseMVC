namespace ExcerciseMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDOB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birth_Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birth_Date", c => c.DateTime(nullable: false));
        }
    }
}
