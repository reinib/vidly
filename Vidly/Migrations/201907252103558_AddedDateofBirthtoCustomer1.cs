namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateofBirthtoCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate=CAST('1989-06-01' AS DATETIME) WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
