namespace Ticari_Otomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class düzenleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "UrunAd", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "UrunAd", c => c.String(maxLength: 30, unicode: false));
        }
    }
}
