ElectronicComponentInventorySystem.UI > labais peles taustiņš >  ņemam "Manage User Secrets"

Tur iekopējam lejā redzamo ConnectionStrings risinājumu, (local) - aizstājot ar savējo servera nosaukumu

{
"ConnectionStrings": {
    "ComponetsDatabase": "Server=(local);Database=ElectronicComponentInvSystDB;Trusted_Connection=True;"
  }
  }

ElectronicComponentInventorySyst.BLL > mape Migrations - lai izveidotu datubāzi un tās struktūru (kolonnas utt)

Lai izveidotu SQL datubāzi > Package Manager Console ievadam - Update-Database
Pēc šīs komandas SQL Server Managament Studio tiks izveidota:
• ElectronicComponentInvSystDB datubāze un 2 tabulas: 
• dbo.ElectronicComponents ar ElectronicComponents klases properties
• dbo.EFMigrationsHistory informācija par migrāciju veikšanām

