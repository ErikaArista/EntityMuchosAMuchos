namespace PracticaE2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Erika : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApellidoM = c.String(),
                        ApellidoP = c.String(),
                        Promedio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AlumnoGrupoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AlumnoID = c.Int(nullable: false),
                        GrupoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Alumnoes", t => t.AlumnoID, cascadeDelete: true)
                .ForeignKey("dbo.Grupoes", t => t.GrupoID, cascadeDelete: true)
                .Index(t => t.AlumnoID)
                .Index(t => t.GrupoID);
            
            CreateTable(
                "dbo.Grupoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Aula = c.String(),
                        Carrera = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlumnoGrupoes", "GrupoID", "dbo.Grupoes");
            DropForeignKey("dbo.AlumnoGrupoes", "AlumnoID", "dbo.Alumnoes");
            DropIndex("dbo.AlumnoGrupoes", new[] { "GrupoID" });
            DropIndex("dbo.AlumnoGrupoes", new[] { "AlumnoID" });
            DropTable("dbo.Grupoes");
            DropTable("dbo.AlumnoGrupoes");
            DropTable("dbo.Alumnoes");
        }
    }
}
