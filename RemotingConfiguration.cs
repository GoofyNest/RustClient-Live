public static class RemotingConfiguration // TypeDefIndex: 1137
{
	private static string applicationID;
	private static string applicationName;
	private static string processGuid;
	private static bool defaultConfigRead;
	private static bool defaultDelayedConfigRead;
	private static string _errorMode;
	private static Hashtable wellKnownClientEntries;
	private static Hashtable activatedClientEntries;
	private static Hashtable wellKnownServiceEntries;
	private static Hashtable activatedServiceEntries;
	private static Hashtable channelTemplates;
	private static Hashtable clientProviderTemplates;
	private static Hashtable serverProviderTemplates;

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

