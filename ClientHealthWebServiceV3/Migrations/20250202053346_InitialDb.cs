using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientHealthWebServiceV3.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientConfiguration",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Configuration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientHealthId = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Architecture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Build = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstallDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OSUpdates = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoggedOnUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSVersion = table.Column<double>(type: "float", nullable: true),
                    PSBuild = table.Column<int>(type: "int", nullable: true),
                    Sitecode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLogSize = table.Column<int>(type: "int", nullable: true),
                    MaxLogHistory = table.Column<int>(type: "int", nullable: true),
                    CacheSize = table.Column<int>(type: "int", nullable: true),
                    ClientCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvisioningMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drivers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PendingReboot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastBootTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OSDiskFreeSpace = table.Column<double>(type: "float", nullable: true),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminShare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateMessages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WUAHandler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshComplianceState = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientInstalled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HWInventory = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SWMetering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BITS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatchLevel = table.Column<int>(type: "int", nullable: true),
                    ClientInstalledReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_001 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_002 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_003 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_004 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_005 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_006 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_007 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_008 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_009 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_010 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_011 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_012 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_013 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_014 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_015 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_016 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_017 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_018 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension_019 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientHealthId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientConfiguration");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
