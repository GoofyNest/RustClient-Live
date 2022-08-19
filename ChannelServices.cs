public sealed class ChannelServices // TypeDefIndex: 1187
{	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0xFDB480 Offset: 0xFDA880 VA: 0x180FDB480
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0xFD8FB0 Offset: 0xFD83B0 VA: 0x180FD8FB0
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0xFD8EA0 Offset: 0xFD82A0 VA: 0x180FD8EA0
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xD2550 Offset: 0xD1950 VA: 0x1800D2550
	// RVA: 0xFDABA0 Offset: 0xFD9FA0 VA: 0x180FDABA0
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0xFDAC00 Offset: 0xFDA000 VA: 0x180FDAC00
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0xFD9D70 Offset: 0xFD9170 VA: 0x180FD9D70
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0xFD9720 Offset: 0xFD8B20 VA: 0x180FD9720
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0xFDB1B0 Offset: 0xFDA5B0 VA: 0x180FDB1B0
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0xFD8B90 Offset: 0xFD7F90 VA: 0x180FD8B90
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0xFD8D60 Offset: 0xFD8160 VA: 0x180FD8D60
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0xFD9A60 Offset: 0xFD8E60 VA: 0x180FD9A60
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0xFDB290 Offset: 0xFDA690 VA: 0x180FDB290
	private static void .cctor() { }

}

