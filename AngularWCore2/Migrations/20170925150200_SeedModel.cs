using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularWCore2.Migrations
{
    public partial class SeedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Departmanlar (Adi) values ('Mutfak')");
            migrationBuilder.Sql("insert into Departmanlar (Adi) values ('Oda Servisi')");
            migrationBuilder.Sql("insert into Departmanlar (Adi) values ('Restaurant')");



            migrationBuilder.Sql("insert into Personeller (Adi, DepartmanId, Email, Soyadi, TCKN, Telefon) values ('Emir','1','emir@emir.com','Hazir', '12345', '5555455353')");

            migrationBuilder.Sql("insert into Personeller (Adi, DepartmanId, Email, Soyadi, TCKN, Telefon) values ('Can','2','can@can.com','Hazir', '123456', '5555455355')");

            migrationBuilder.Sql("insert into Personeller (Adi, DepartmanId, Email, Soyadi, TCKN, Telefon) values ('Aziz','3','aziz@aziz.com','Hazir', '1234567', '5555455354')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
