namespace BudgetManagementApp.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNamefromaccountingmovements : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AccountingMovement", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountingMovement", "Name", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
