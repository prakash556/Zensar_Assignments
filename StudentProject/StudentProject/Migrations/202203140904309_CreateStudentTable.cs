namespace StudentProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentTables",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Branch = c.String(),
                        Percentage = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentTables");
        }
    }
}
