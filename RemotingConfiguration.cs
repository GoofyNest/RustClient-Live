public static class RemotingConfiguration // TypeDefIndex: 1137
{	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static string _errorMode; // 0x20
	private static Hashtable wellKnownClientEntries; // 0x28
	private static Hashtable activatedClientEntries; // 0x30
	private static Hashtable wellKnownServiceEntries; // 0x38
	private static Hashtable activatedServiceEntries; // 0x40
	private static Hashtable channelTemplates; // 0x48
	private static Hashtable clientProviderTemplates; // 0x50
	private static Hashtable serverProviderTemplates; // 0x58

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x1481090 Offset: 0x1480490 VA: 0x181481090
	public static string get_ApplicationName() { }

	// RVA: 0x14811E0 Offset: 0x14805E0 VA: 0x1814811E0
	public static void set_ApplicationName(string value) { }

	// RVA: 0x14810F0 Offset: 0x14804F0 VA: 0x1814810F0
	public static string get_ProcessId() { }

	// RVA: 0x147F3D0 Offset: 0x147E7D0 VA: 0x18147F3D0
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x147F090 Offset: 0x147E490 VA: 0x18147F090
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x147F230 Offset: 0x147E630 VA: 0x18147F230
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x147F680 Offset: 0x147EA80 VA: 0x18147F680
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x147F920 Offset: 0x147ED20 VA: 0x18147F920
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x14808F0 Offset: 0x147FCF0 VA: 0x1814808F0
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1480B90 Offset: 0x147FF90 VA: 0x181480B90
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x147FA80 Offset: 0x147EE80 VA: 0x18147FA80
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x14803A0 Offset: 0x147F7A0 VA: 0x1814803A0
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x1480430 Offset: 0x147F830 VA: 0x181480430
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x147FB10 Offset: 0x147EF10 VA: 0x18147FB10
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x14804C0 Offset: 0x147F8C0 VA: 0x1814804C0
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x147EFC0 Offset: 0x147E3C0 VA: 0x18147EFC0
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x1480D30 Offset: 0x1480130 VA: 0x181480D30
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x1480E70 Offset: 0x1480270 VA: 0x181480E70
	private static void .cctor() { }

}

