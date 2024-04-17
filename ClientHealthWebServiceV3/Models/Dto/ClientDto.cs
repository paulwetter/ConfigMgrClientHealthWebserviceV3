using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientHealthWebserviceV3.Models
{
    public class ClientDto
    {
        [Key]
        [MaxLength(36)]
        public string ClientHealthId { get; set; } = (new Guid()).ToString();
        public string Hostname { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        [MaxLength(10)]
        public string Architecture { get; set; } = string.Empty;
        public string Build { get; set; } = string.Empty;
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? InstallDate { get; set; }
        public string? OSUpdates { get; set; }
        public string? LastLoggedOnUser { get; set; }
        public string? ClientVersion { get; set; }
        public double? PSVersion { get; set; }
        public int? PSBuild { get; set; }
        [MaxLength(3)]
        public string? Sitecode { get; set; }
        public string? Domain { get; set; }
        public int? MaxLogSize { get; set; }
        public int? MaxLogHistory { get; set; }
        public int? CacheSize { get; set; }
        public string? ClientCertificate { get; set; }
        public string? ProvisioningMode { get; set; }
        public string? DNS { get; set; }
        public string? Drivers { get; set; }
        public string? Updates { get; set; }
        public string? PendingReboot { get; set; }
        public string? LastBootTime { get; set; }
        public double? OSDiskFreeSpace { get; set; }
        public string? Services { get; set; }
        public string? AdminShare { get; set; }
        public string? StateMessages { get; set; }
        public string? WUAHandler { get; set; }
        public string? WMI { get; set; }
        public string? RefreshComplianceState { get; set; }
        public string? ClientInstalled { get; set; }
        [MaxLength(10)]
        public string? Version { get; set; }
        public string? Timestamp { get; set; }
        public string? HWInventory { get; set; }
        public string? SWMetering { get; set; }
        public string? BITS { get; set; }
        public int? PatchLevel { get; set; }
        public string? ClientInstalledReason { get; set; }
        public string? Extension_000 { get; set; }
        public string? Extension_001 { get; set; }
        public string? Extension_002 { get; set; }
        public string? Extension_003 { get; set; }
        public string? Extension_004 { get; set; }
        public string? Extension_005 { get; set; }
        public string? Extension_006 { get; set; }
        public string? Extension_007 { get; set; }
        public string? Extension_008 { get; set; }
        public string? Extension_009 { get; set; }
        public string? Extension_010 { get; set; }
        public string? Extension_011 { get; set; }
        public string? Extension_012 { get; set; }
        public string? Extension_013 { get; set; }
        public string? Extension_014 { get; set; }
        public string? Extension_015 { get; set; }
        public string? Extension_016 { get; set; }
        public string? Extension_017 { get; set; }
        public string? Extension_018 { get; set; }
        public string? Extension_019 { get; set; }

        public Client ConvertClientDtoToClient()
        {
            return new Client
            {
                ClientHealthId = ClientHealthId,
                Hostname = Hostname,
                OperatingSystem = OperatingSystem,
                Architecture = Architecture,
                Build = Build,
                Manufacturer = Manufacturer,
                Model = Model,
                InstallDate = ParseNullableDateTime(InstallDate),
                OSUpdates = ParseNullableDateTime(OSUpdates),
                LastLoggedOnUser = LastLoggedOnUser,
                ClientVersion = ClientVersion,
                PSVersion = PSVersion,
                PSBuild = PSBuild,
                Sitecode = Sitecode,
                Domain = Domain,
                MaxLogSize = MaxLogSize,
                MaxLogHistory = MaxLogHistory,
                CacheSize = CacheSize,
                ClientCertificate = ClientCertificate,
                ProvisioningMode = ProvisioningMode,
                DNS = DNS,
                Drivers = Drivers,
                Updates = Updates,
                PendingReboot = PendingReboot,
                LastBootTime = ParseNullableDateTime(LastBootTime),
                OSDiskFreeSpace = OSDiskFreeSpace,
                Services = Services,
                AdminShare = AdminShare,
                StateMessages = StateMessages,
                WUAHandler = WUAHandler,
                WMI = WMI,
                RefreshComplianceState = ParseNullableDateTime(RefreshComplianceState),
                ClientInstalled = ParseNullableDateTime(ClientInstalled),
                Version = Version,
                Timestamp = ParseNullableDateTime(Timestamp),
                HWInventory = ParseNullableDateTime(HWInventory),
                SWMetering = SWMetering,
                BITS = BITS,
                PatchLevel = PatchLevel,
                ClientInstalledReason = ClientInstalledReason,
                Extension_000 = Extension_000,
                Extension_001 = Extension_001,
                Extension_002 = Extension_002,
                Extension_003 = Extension_003,
                Extension_004 = Extension_004,
                Extension_005 = Extension_005,
                Extension_006 = Extension_006,
                Extension_007 = Extension_007,
                Extension_008 = Extension_008,
                Extension_009 = Extension_009,
                Extension_010 = Extension_010,
                Extension_011 = Extension_011,
                Extension_012 = Extension_012,
                Extension_013 = Extension_013,
                Extension_014 = Extension_014,
                Extension_015 = Extension_015,
                Extension_016 = Extension_016,
                Extension_017 = Extension_017,
                Extension_018 = Extension_018,
                Extension_019 = Extension_019
            };
        }

        private static DateTime? ParseNullableDateTime(string? dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, out DateTime result))
            {
                return result;
            }
            return null;
        }
    }
}
