public static class RemotingConfiguration // TypeDefIndex: 1137
{	private static string applicationID; // 0x0
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

	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }


	public static string get_ApplicationName() { }

	public static void set_ApplicationName(string value) { }

	public static string get_ProcessId() { }

	internal static void LoadDefaultDelayedChannels() { }

	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	internal static void RegisterChannelTemplate(ChannelData channel) { }

	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	internal static void RegisterTypes(ArrayList types) { }

	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	internal static void SetCustomErrorsMode(string mode) { }

	private static void .cctor() { }

}

