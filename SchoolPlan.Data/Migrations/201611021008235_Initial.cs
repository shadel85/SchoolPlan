namespace SchoolPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CreationDate = c.DateTime(),
                        ModificationDate = c.DateTime(),
                        Location_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.Teacher", t => t.Teacher_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuildingNumber = c.Int(nullable: false),
                        RoomNumber = c.Int(nullable: false),
                        CreationDate = c.DateTime(),
                        ModificationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GPA = c.Decimal(precision: 18, scale: 2),
                        CreationDate = c.DateTime(),
                        ModificationDate = c.DateTime(),
                        Class_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Class", t => t.Class_Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Class_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        CreationDate = c.DateTime(),
                        ModificationDate = c.DateTime(),
                        Age = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        CreationDate = c.DateTime(),
                        ModificationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Class", "Teacher_Id", "dbo.Teacher");
            DropForeignKey("dbo.StudentClass", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.StudentClass", "Class_Id", "dbo.Class");
            DropForeignKey("dbo.Class", "Location_Id", "dbo.Location");
            DropIndex("dbo.StudentClass", new[] { "Student_Id" });
            DropIndex("dbo.StudentClass", new[] { "Class_Id" });
            DropIndex("dbo.Class", new[] { "Teacher_Id" });
            DropIndex("dbo.Class", new[] { "Location_Id" });
            DropTable("dbo.Teacher");
            DropTable("dbo.Student");
            DropTable("dbo.StudentClass");
            DropTable("dbo.Location");
            DropTable("dbo.Class");
        }
    }
}
