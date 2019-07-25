namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateofBirthtoCustomer2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate=CAST('1991-03-24' AS DATETIME) WHERE Id=2");

        }

        public override void Down()
        {
        }
    }
}
