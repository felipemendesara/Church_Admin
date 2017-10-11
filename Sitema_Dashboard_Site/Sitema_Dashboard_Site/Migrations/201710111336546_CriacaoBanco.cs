namespace Sitema_Dashboard_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devocionals",
                c => new
                    {
                        IdDevocional = c.Int(nullable: false, identity: true),
                        TituloDevocional = c.String(nullable: false),
                        TextoDevocional = c.String(nullable: false),
                        Autor = c.String(nullable: false),
                        LivroBase = c.String(nullable: false),
                        CapituloBase = c.Int(nullable: false),
                        VersiculoInicioBase = c.String(),
                        VersiculoFinalBase = c.String(),
                    })
                .PrimaryKey(t => t.IdDevocional);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Devocionals");
        }
    }
}
