namespace BudgetManagementApp.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBalanceSheet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BalanceSheet", "AccountingMovementId", "dbo.AccountingMovement");
            DropForeignKey("dbo.BalanceSheet", "ProjectId", "dbo.Project");
            DropIndex("dbo.BalanceSheet", new[] { "ProjectId" });
            DropIndex("dbo.BalanceSheet", new[] { "AccountingMovementId" });
            AddColumn("dbo.AccountingMovement", "ProjectId", c => c.Int());
            AlterColumn("dbo.AccountingMovement", "Comment", c => c.String(maxLength: 500));
            CreateIndex("dbo.AccountingMovement", "ProjectId");
            AddForeignKey("dbo.AccountingMovement", "ProjectId", "dbo.Project", "ProjectId");
            DropTable("dbo.BalanceSheet");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BalanceSheet",
                c => new
                    {
                        BalanceSheetId = c.Int(nullable: false, identity: true),
                        DeletedOn = c.DateTime(),
                        ProjectId = c.Int(nullable: false),
                        AccountingMovementId = c.Int(),
                    })
                .PrimaryKey(t => t.BalanceSheetId);
            
            DropForeignKey("dbo.AccountingMovement", "ProjectId", "dbo.Project");
            DropIndex("dbo.AccountingMovement", new[] { "ProjectId" });
            AlterColumn("dbo.AccountingMovement", "Comment", c => c.String());
            DropColumn("dbo.AccountingMovement", "ProjectId");
            CreateIndex("dbo.BalanceSheet", "AccountingMovementId");
            CreateIndex("dbo.BalanceSheet", "ProjectId");
            AddForeignKey("dbo.BalanceSheet", "ProjectId", "dbo.Project", "ProjectId", cascadeDelete: true);
            AddForeignKey("dbo.BalanceSheet", "AccountingMovementId", "dbo.AccountingMovement", "AccountingMovementId");
        }
    }
}
