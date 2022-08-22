public sealed class ChannelServices // TypeDefIndex: 1187
{	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	internal static CrossContextChannel CrossContextChannel { get; }


	internal static CrossContextChannel get_CrossContextChannel() { }

	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xD2550 Offset: 0xD1950 VA: 0x1800D2550
	public static void RegisterChannel(IChannel chnl) { }

	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	internal static void RegisterChannelConfig(ChannelData channel) { }

	private static object CreateProvider(ProviderData prov) { }

	public static IMessage SyncDispatchMessage(IMessage msg) { }

	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	private static bool IsLocalCall(IMessage callMsg) { }

	internal static object[] GetCurrentChannelInfo() { }

	private static void .cctor() { }

}

