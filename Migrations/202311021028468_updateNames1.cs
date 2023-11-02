namespace ExcerciseMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class updateNames1 : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Pay as you go' where id = 0");
            Sql("update MembershipTypes set Name = 'Daily' where id = 1");
            Sql("update MembershipTypes set Name = 'Weekly' where id = 2");
            Sql("update MembershipTypes set Name = 'Monthly' where id = 3");

        }

        public override void Down()
        {
        }
    }
}
